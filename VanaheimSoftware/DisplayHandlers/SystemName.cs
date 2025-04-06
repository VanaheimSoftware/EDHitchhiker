// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using EDHitchhiker.VanaheimSoftware.Utils;
using EDHitchhiker.VanaheimSoftware.Api;

namespace EDHitchhiker.VanaheimSoftware.DisplayHandlers {
    internal class SystemName : LabelHandler {
        public SystemName(JsonParser jsonParser, Label label) : base(jsonParser, label) {
            ShowSystemName("");
            this.jsonParser.OnLocation += JsonParser_OnLocation;
            this.jsonParser.OnFSDJump += JsonParser_OnFSDJump;
        }


        ~SystemName() {
            jsonParser.OnLocation -= JsonParser_OnLocation;
            jsonParser.OnFSDJump -= JsonParser_OnFSDJump;
        }

        private void JsonParser_OnLocation(object? sender, Location e) {
            ShowSystemName(e.StarSystem);
        }

        private void JsonParser_OnFSDJump(object? sender, FSDJump e) {
            ShowSystemName(e.StarSystem);
        }

        private void ShowSystemName(string? name) {
            if (label.InvokeRequired) {
                label.Invoke(new EventHandler(delegate (object? o, EventArgs a) {
                    ShowSystemName(name);
                }));
            } else {
                label.Text = string.IsNullOrWhiteSpace(name) ? "" : name;
            }
        }
    }
}
