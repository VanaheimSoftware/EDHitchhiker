// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using System.Numerics;
using EDHitchhiker.VanaheimSoftware.Utils;
using EDHitchhiker.VanaheimSoftware.Api;

namespace EDHitchhiker.VanaheimSoftware.DisplayHandlers {
    internal class Route {
        private const string JUMPS = " jumps";

        private readonly JsonParser jsonParser;
        private readonly DataGridView dataGridView;
        private readonly Label numberOfJumps;
        private readonly ImageList imageList;

        private readonly Stars stars = new();

        public Route(JsonParser jsonParser, DataGridView routesView, Label jumps, ImageList imageList) {
            this.jsonParser = jsonParser;
            this.dataGridView = routesView;
            this.numberOfJumps = jumps;
            this.imageList = imageList;

            SetupGrid();

            AddRoute([]);

            this.jsonParser.OnNavRoute += JsonParser_OnNavRoute;
            this.jsonParser.OnFSDJump += JsonParser_OnFSDJump;
            this.imageList = imageList;
        }

        ~Route() { 
            jsonParser.OnFSDJump -= JsonParser_OnFSDJump;
            jsonParser.OnNavRoute -= JsonParser_OnNavRoute;
        }

        private void JsonParser_OnFSDJump(object? sender, FSDJump e) {
            if (string.IsNullOrWhiteSpace(e.StarSystem)) return;

            RemoveTopRoute(e.StarSystem);
        }

        private void JsonParser_OnNavRoute(object? sender, NavRoute e) {
            if (e.Route == null || e.Route.Count < 1) return;

            Vector3 currentPosition = GetStarPosition(e.Route[0].StarPosition);
            e.Route.RemoveAt(0);    // remove current system from route

            List<object[]> route = new(e.Route.Count);

            foreach (EDHitchhiker.VanaheimSoftware.Api.Objects.Route r in e.Route) {
                Vector3 routePosition = GetStarPosition(r.StarPosition);
                float distance = Vector3.Distance(currentPosition, routePosition);
                Stars.StarDetail starDetail = stars.TypeToDetail(r.StarClass);

                route.Add([
                    imageList.Images[starDetail.Scoopable ? 0 : 1],
                    string.IsNullOrWhiteSpace(r.StarSystem) ? "Undefined" : r.StarSystem.ToUpper(), 
                    starDetail == null ? "Undefined" : starDetail.ShortName, 
                    String.Format("{0:0.00}", distance)
                ]);

                currentPosition = routePosition;
            }

            AddRoute(route);
        }

        private static Vector3 GetStarPosition(IList<float>? position) {
            if (position == null || position.Count == 0) return new();

            return new() { X = position[0], Y = position[1], Z = position[2] };
        }

        private void SetupGrid() {
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
            dataGridView.DefaultCellStyle.SelectionForeColor = dataGridView.DefaultCellStyle.ForeColor;
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dataGridView, new object[] { true }
            );
        }

        private void RemoveTopRoute(string starSystem) {
            if (dataGridView.InvokeRequired) {
                dataGridView.Invoke(new EventHandler(delegate (object? o, EventArgs a) {
                    RemoveTopRoute(starSystem);
                }));
            } else {
                if (dataGridView.RowCount > 0 && dataGridView.Rows[0].Cells.Count > 0) {
                    object? topSystemName = dataGridView.Rows[0].Cells[1].Value;

                    if (topSystemName != null && topSystemName.GetType() == typeof(String)) {
                        if (((string)topSystemName).Equals(starSystem, StringComparison.CurrentCultureIgnoreCase)) {
                            dataGridView.ClearSelection();
                            dataGridView.Rows.RemoveAt(0);
                        }
                        ShowJumps(dataGridView.RowCount);
                    }
                }
            }
        }


        private void ShowJumps(int count) {
            if (numberOfJumps.InvokeRequired) {
                numberOfJumps.Invoke(new EventHandler(delegate (object? o, EventArgs a) {
                    ShowJumps(count);
                }));
            } else {
                numberOfJumps.Text = count + JUMPS;
            }
        }

        private void AddRoute(List<object[]> data) {
            if (dataGridView.InvokeRequired) {
                dataGridView.Invoke(new EventHandler(delegate (object? o, EventArgs a) {
                    AddRoute(data);
                }));
            } else {
                dataGridView.Rows.Clear();
                foreach (object[] routeData in data) {
                    dataGridView.Rows.Add(routeData);
                }
                dataGridView.ClearSelection();
                ShowJumps(dataGridView.RowCount);
            }
        }

    }
}
