// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using EDHitchhiker.VanaheimSoftware.Api;
using EDHitchhiker.VanaheimSoftware.Utils;

namespace EDHitchhiker.VanaheimSoftware.DisplayHandlers {
    internal class Fuel : LabelHandler {
        private readonly object lockFuelDetail = new();

        private FuelDetail fuelDetail = new();

        public Fuel(JsonParser jsonParser, Label label) : base(jsonParser, label) {
            ShowFuel();
            this.jsonParser.OnLoadGame += JsonParser_OnLoadGame;
            this.jsonParser.OnFuelScoop += JsonParser_OnFuelScoop;
            this.jsonParser.OnFSDJump += JsonParser_OnFSDJump;
            this.jsonParser.OnLoadout += JsonParser_OnLoadout;
        }

        ~Fuel() {
            jsonParser.OnLoadGame -= JsonParser_OnLoadGame;
            jsonParser.OnFuelScoop -= JsonParser_OnFuelScoop;
            jsonParser.OnFSDJump -= JsonParser_OnFSDJump;
            jsonParser.OnLoadout -= JsonParser_OnLoadout;
        }

        private void JsonParser_OnLoadout(object? sender, Loadout e) {
            if (e.FuelCapacity != null)
                UpdateFuel(e.FuelCapacity.Main, e.FuelCapacity.Main);
            else
                UpdateFuel(0, 0);
        }

        private void JsonParser_OnLoadGame(object? sender, LoadGame e) {
            UpdateFuel(e.FuelLevel, e.FuelCapacity);
        }

        private void JsonParser_OnFuelScoop(object? sender, FuelScoop e) {
            UpdateFuel(e.Total, fuelDetail.Capacity);
        }

        private void JsonParser_OnFSDJump(object? sender, FSDJump e) {
            UpdateFuel(e.FuelLevel, fuelDetail.Capacity);
        }

        private void UpdateFuel(float current, float capacity) {
            lock (lockFuelDetail) {
                fuelDetail.Current = current;
                fuelDetail.Capacity = capacity;
            }
            ShowFuel();
        }

        private void ShowFuel() {
            if (label.InvokeRequired) {
                label.Invoke(new EventHandler(delegate (object? o, EventArgs a) {
                    ShowFuel();
                }));
            } else {
                lock (lockFuelDetail) {
                    label.Text = String.Format("{0:0.####}/{1:0.##}", fuelDetail.Current, fuelDetail.Capacity);
                }
            }
        }

        private struct FuelDetail {
            public float Capacity;
            public float Current;
        }
    }
}
