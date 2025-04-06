// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class BuyExplorationData : BaseEvent
    {
        [JsonProperty(nameof(System))]
        public string? System { get; set; }

        [JsonProperty(nameof(Cost))]
        public long Cost { get; set; } = 0;
    }
}
