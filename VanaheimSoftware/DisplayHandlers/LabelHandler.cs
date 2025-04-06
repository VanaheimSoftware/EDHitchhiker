
using EDHitchhiker.VanaheimSoftware.Utils;

namespace EDHitchhiker.VanaheimSoftware.DisplayHandlers {
    internal abstract class LabelHandler {
        protected readonly JsonParser jsonParser;
        protected readonly Label label;

        public LabelHandler(JsonParser jsonParser, Label label) {
            this.jsonParser = jsonParser;
            this.label = label;
        }
    }
}
