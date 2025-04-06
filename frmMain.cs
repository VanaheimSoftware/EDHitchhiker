// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using EDHitchhiker.VanaheimSoftware.Utils;
using EDHitchhiker.VanaheimSoftware.DisplayHandlers;
using System.ComponentModel;
using System.Diagnostics;

namespace EDHitchhiker
{
    public partial class frmMain : Form {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public frmSplash? SplashForm { get; set; }

        private JournalReader? logReader;
        private JsonParser jsonParser = new();

        private FlyingShip? flyingShipHandler;
        private Fuel? fuelHandler;
        private Honked? honked;
        private Route? routeHandler;
        private SystemBodies? systemBodies;
        private SystemName? systemNameHandler;
        private Title? titleHandler;

        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            InitializeHandlers();
            StartReader();
        }

        private void InitializeHandlers() {
            flyingShipHandler = new(jsonParser, lblFlying);
            fuelHandler = new(jsonParser, lblFuel);
            honked = new(jsonParser, lblHonked);
            routeHandler = new(jsonParser, gridRoute, lblJumps, imgList);
            systemBodies = new(jsonParser, gridBodies, lblBodyCount, imgList);
            systemNameHandler = new(jsonParser, lblSystemName);
            titleHandler = new(jsonParser, this);
        }

        private void StartReader() {
            logReader = new JournalReader(new JournalWatcher());
            logReader.OnRead += LogReader_OnRead;
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (logReader != null) {
                logReader.OnRead -= LogReader_OnRead;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e) {
            SplashForm?.CloseSplash();
        }

        private void LogReader_OnRead(object? sender, string e) {
            Debug.WriteLine(e);
            jsonParser.Parse(e);
        }

        // from designer setup
        private void gridRoute_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex == 3) {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void gridBodies_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 8 && e.RowIndex >= 0) {
                bool? bodyScanned = (bool?)gridBodies.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (bodyScanned == true) {
                    // todo - 20250425 - why did I reduce this? Possible back color issues on checkboxes.
                    //for (int cellIndex = 2; cellIndex < gridBodies.Rows[e.RowIndex].Cells.Count; cellIndex++) {
                    //    gridBodies.Rows[e.RowIndex].Cells[cellIndex].Style.BackColor = Color.Beige;
                    //}
                    gridBodies.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.Beige;
                }
            }
        }

    }
}
