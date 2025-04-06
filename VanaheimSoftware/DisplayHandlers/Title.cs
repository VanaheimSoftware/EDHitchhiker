using EDHitchhiker.VanaheimSoftware.Api;
using EDHitchhiker.VanaheimSoftware.Utils;

namespace EDHitchhiker.VanaheimSoftware.DisplayHandlers {
    internal class Title {
        private const string FORM_TITLE = "ED Hitchhiker";

        private readonly JsonParser jsonParser;
        private readonly Form form;

        public Title(JsonParser jsonParser, Form form) {
            this.jsonParser = jsonParser;
            this.form = form;
            ShowTitle(FORM_TITLE);
            this.jsonParser.OnCommander += JsonParser_OnCommander;
        }

        ~Title() {
            this.jsonParser.OnCommander -= JsonParser_OnCommander;
        }

        private void JsonParser_OnCommander(object? sender, Commander e) {
            ShowTitle(FORM_TITLE + (string.IsNullOrWhiteSpace(e.Name) ? "" : " - CMDR " + e.Name));
        }

        private void ShowTitle(string title) {
            if (form.InvokeRequired) {
                form.Invoke(new EventHandler(delegate (object? o, EventArgs a) {
                    ShowTitle(title);
                }));
            } else {
                form.Text = title;
            }
        }
    }
}
