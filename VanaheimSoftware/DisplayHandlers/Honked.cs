// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using EDHitchhiker.VanaheimSoftware.Api;
using EDHitchhiker.VanaheimSoftware.Utils;

namespace EDHitchhiker.VanaheimSoftware.DisplayHandlers {

    internal class Honked : LabelHandler {
        private readonly static Color ED_ORANGE = Color.FromArgb(1, 255, 113, 0);

        public Honked(JsonParser jsonParser, Label label) : base(jsonParser, label) {
            ShowHonked(false);
            this.jsonParser.OnFSSDiscoveryScan += JsonParser_OnFSSDiscoveryScan;
            this.jsonParser.OnFSDJump += JsonParser_OnFSDJump;
            this.jsonParser.OnMusic += JsonParser_OnMusic;
        }

        ~Honked() {
            jsonParser.OnFSSDiscoveryScan -= JsonParser_OnFSSDiscoveryScan;
            jsonParser.OnFSDJump -= JsonParser_OnFSDJump;
            jsonParser.OnMusic -= JsonParser_OnMusic;
        }

        private void JsonParser_OnFSSDiscoveryScan(object? sender, FSSDiscoveryScan e) {
            ShowHonked(true);
        }

        private void JsonParser_OnFSDJump(object? sender, global::EDHitchhiker.VanaheimSoftware.Api.FSDJump e) {
            ShowHonked(false);
        }

        private void JsonParser_OnMusic(object? sender, Music e) {
            if (e.MusicTrack?.ToLower() == "mainmenu") {
                ShowHonked(false);
            }
        }

        private void ShowHonked(bool active) {
            if (label.InvokeRequired) {
                label.Invoke(new EventHandler(delegate (object? o, EventArgs a) {
                    ShowHonked(active);
                }
                ));
            } else
                label.ForeColor = active ? ED_ORANGE : SystemColors.ControlDark;
        }
    }
}
