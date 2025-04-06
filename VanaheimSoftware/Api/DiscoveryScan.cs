// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class DiscoveryScan : BaseEvent
    {
        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty(nameof(Bodies))]
        public int Bodies { get; set; } = 0;
    }
}
