using EDHitchhiker.VanaheimSoftware.Api;
using EDHitchhiker.VanaheimSoftware.Utils;

namespace EDHitchhiker.VanaheimSoftware.DisplayHandlers {
    internal class FlyingShip : LabelHandler {
        public FlyingShip(JsonParser jsonParser, Label label) : base(jsonParser, label) {
            ShowFlyingShip("");
            this.jsonParser.OnLoadout += JsonParser_OnLoadout;
        }

        ~FlyingShip() {
            jsonParser.OnLoadout -= JsonParser_OnLoadout;
        }

        private void JsonParser_OnLoadout(object? sender, Loadout e) {
            if (String.IsNullOrWhiteSpace(e.ShipType)) {
                ShowFlyingShip("");
            } else {
                ShowFlyingShip(e.ShipName + " / " + e.ShipIdentification + " [" + e.ShipType + "]");
            }
        }

        private void ShowFlyingShip(string flying) {
            if (label.InvokeRequired) {
                label.Invoke(new EventHandler(delegate (object? o, EventArgs a) {
                    ShowFlyingShip(flying);
                }));
            } else {
                label.Text = flying;
            }
        }

    }
}
