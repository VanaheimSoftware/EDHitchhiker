// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

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
