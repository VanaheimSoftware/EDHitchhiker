using EDHitchhiker.VanaheimSoftware.Api;
using EDHitchhiker.VanaheimSoftware.Utils;

namespace EDHitchhiker.VanaheimSoftware.DisplayHandlers {
    // note:
    //          This really is a quick hack. If entering a system previously scanned, nothing will show. Or only what is newly scanned.
    //          In the future, may be an idea to also incorporate SQLite database to track previous scans. Including pre-scan old journal files
    //          Of course, that is only if I care to. Could always use existing tools out there.

    internal class SystemBodies {
        private readonly object countLock = new();
        private readonly object scanLock = new();

        private readonly static Color ED_ORANGE = Color.FromArgb(1, 255, 113, 0);

        private readonly Stars stars = new();
        private readonly Planets planets = new();

        private readonly JsonParser jsonParser;
        private readonly DataGridView dataGridViewBodies;
        private readonly Label bodiesCount;
        private readonly ImageList imageList;

        private BodyCounts bodyCounts = new() { Scanned = 0, Total = 0 };
        private string systemName = "";

        private readonly List<string> scannedBodies = new();

        public SystemBodies(JsonParser jsonParser, DataGridView bodiesView, Label bodiesCount, ImageList imageList) {
            this.jsonParser = jsonParser;
            this.dataGridViewBodies = bodiesView;
            this.bodiesCount = bodiesCount;
            this.imageList = imageList;

            SetupGrid();
            ShowCounts();

            jsonParser.OnFSDJump += JsonParser_OnFSDJump;
            jsonParser.OnMusic += JsonParser_OnMusic;
            jsonParser.OnScan += JsonParser_OnScan;
            jsonParser.OnFSSDiscoveryScan += JsonParser_OnFSSDiscoveryScan;
            jsonParser.OnFSSAllBodiesFound += JsonParser_OnFSSAllBodiesFound;
            jsonParser.OnSAAScanComplete += JsonParser_OnSAAScanComplete;
            jsonParser.OnLocation += JsonParser_OnLocation;
        }

        ~SystemBodies() {
            jsonParser.OnFSDJump -= JsonParser_OnFSDJump;
            jsonParser.OnMusic -= JsonParser_OnMusic;
            jsonParser.OnScan -= JsonParser_OnScan;
            jsonParser.OnFSSDiscoveryScan -= JsonParser_OnFSSDiscoveryScan;
            jsonParser.OnFSSAllBodiesFound -= JsonParser_OnFSSAllBodiesFound;
            jsonParser.OnSAAScanComplete -= JsonParser_OnSAAScanComplete;
            jsonParser.OnLocation -= JsonParser_OnLocation;
        }

        private void JsonParser_OnLocation(object? sender, Location e) {
            lock (scanLock) {
                systemName = string.IsNullOrWhiteSpace(e.StarSystem) ? "" : e.StarSystem.ToUpper();   // should be present
            }
        }

        private void JsonParser_OnSAAScanComplete(object? sender, SAAScanComplete e) {
            if (dataGridViewBodies.InvokeRequired) {
                dataGridViewBodies.Invoke(new EventHandler(delegate (object? o, EventArgs a) {
                    JsonParser_OnSAAScanComplete(sender, e);
                }));
            } else {
                if (string.IsNullOrWhiteSpace(e.BodyName)) return;

                string bodyName = ShortBodyName(e.BodyName);

                for (int idx = 0; idx < dataGridViewBodies.Rows.Count; idx++) {
                    string? cellBodyName = (string?)dataGridViewBodies.Rows[idx].Cells[2].Value;
                    if (cellBodyName != null && cellBodyName.Trim() == bodyName) {
                        dataGridViewBodies.Rows[idx].Cells[8].Value = true;
                        break;
                    }
                }
            }
        }

        private void JsonParser_OnMusic(object? sender, Music e) {
            if (e.MusicTrack?.ToLower() == "mainmenu") {
                lock (countLock) {
                    bodyCounts.Scanned = 0;
                    bodyCounts.Total = 0;
                }
                ClearBodies();
                ShowCounts();
            }
        }

        private void SetupGrid() {
            dataGridViewBodies.DefaultCellStyle.SelectionBackColor = dataGridViewBodies.DefaultCellStyle.BackColor;
            dataGridViewBodies.DefaultCellStyle.SelectionForeColor = dataGridViewBodies.DefaultCellStyle.ForeColor;
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dataGridViewBodies, new object[] { true }
            );
        }

        private void ShowCounts() {
            if (bodiesCount.InvokeRequired) {
                bodiesCount.Invoke(new EventHandler(delegate (object? o, EventArgs a) {
                    ShowCounts();
                }));
            } else {
                lock (countLock) {
                    bodiesCount.Text = bodyCounts.Scanned + "/" + (bodyCounts.Total == 0 ? "?" : "" + bodyCounts.Total);
                    bodiesCount.ForeColor = bodyCounts.Total > 0 && bodyCounts.Scanned == bodyCounts.Total ? ED_ORANGE : SystemColors.ControlText;
                }
            }

        }

        private void JsonParser_OnFSDJump(object? sender, FSDJump e) {
            lock (countLock) {
                bodyCounts.Scanned = 0;
                bodyCounts.Total = 0;
                lock (scanLock) {
                    systemName = string.IsNullOrWhiteSpace(e.StarSystem) ? "" : e.StarSystem.ToUpper();   // should be present
                    scannedBodies.Clear();
                }
            }
            ShowCounts();
            ClearBodies();
        }

        private void JsonParser_OnFSSDiscoveryScan(object? sender, FSSDiscoveryScan e) {
            lock (countLock) {
                bodyCounts.Total = e.BodyCount;
            }
            ShowCounts();
        }

        private void JsonParser_OnFSSAllBodiesFound(object? sender, FSSAllBodiesFound e) {
            lock (countLock) {
                bodyCounts.Scanned = e.Count;
            }
            ShowCounts();
        }


        private void ClearBodies() {
            if (dataGridViewBodies.InvokeRequired) {
                dataGridViewBodies.Invoke(new EventHandler(delegate (object? o, EventArgs a) {
                    ClearBodies();
                }));
            } else {
                dataGridViewBodies.Rows.Clear();
                dataGridViewBodies.ClearSelection();
            }
        }

        private string ShortBodyName(string name) {
            return name.ToUpper().Replace(systemName, "").TrimStart();     // if main star is called the same as system, then this should be empty. Allow for this
        }

        private void JsonParser_OnScan(object? sender, Scan e) {
            if (string.IsNullOrWhiteSpace(e.BodyName)) return;

            lock (scanLock) {
                string bodyName = ShortBodyName(e.BodyName);

                if (scannedBodies.Contains(bodyName)) return;   // duplicate (this happens), ignore

                bool star = !String.IsNullOrEmpty(e.StarType);
                bool planet = !String.IsNullOrEmpty(e.PlanetClass);

                if (star || planet) {
                    lock (bodiesCount) {
                        bodyCounts.Scanned++;
                    }
                    ShowCounts();

                    int index = FindIndex(bodyName);
                    scannedBodies.Insert(index, bodyName);

                    if (star) {
                        AddStar(e, bodyName, index);
                    } else {
                        AddPlanet(e, bodyName, index);
                    }
                }
            }
        }

        private int FindIndex(string bodyName) {
            if (bodyName.Length == 0 || scannedBodies.Count == 0) return 0;

            int index = 0;
            do {
                // for now just going by name order. Could create some off results. Really only for display for now.
                if (string.Compare(bodyName, scannedBodies[index], StringComparison.OrdinalIgnoreCase) < 0) {
                    break;
                } else {
                    index++;
                }
            } while (index < scannedBodies.Count);
            return index;
        }

        private void AddStar(Scan e, string bodyName, int insertPosition) {
            Stars.StarDetail starDetail = stars.TypeToDetail(e.StarType);

            AddBody(insertPosition, [
                imageList.Images[3], imageList.Images[starDetail.Scoopable ? 0 : 1], bodyName, starDetail.ShortName,
                false, false, false, false, false
            ]);
        }

        private void AddPlanet(Scan e, string bodyName, int insertPosition) {
            Planets.PlanetDetail planetDetail = planets.TypeToDetail(e.PlanetClass);

            AddBody(insertPosition, [
                imageList.Images[2], imageList.Images[1],bodyName, planetDetail.ShortName,
                planetDetail.IsEarthlike(), planetDetail.IsWater(), planetDetail.IsAmmonia(),
                (e.TerraformState?.ToLower() == "terraformable"), false
            ]);
        }

        private void AddBody(int index, object[] data) {
            if (dataGridViewBodies.InvokeRequired) {
                dataGridViewBodies.Invoke(new EventHandler(delegate (object? o, EventArgs a) {
                    // one day use DataSource instead...
                    AddBody(index, data);
                }));
            } else {
                dataGridViewBodies.Rows.Insert(index, data);
                dataGridViewBodies.ClearSelection();
            }
        }

        private struct BodyCounts {
            public int Scanned { get; set; }
            public int Total { get; set; }
        }
    }
}
