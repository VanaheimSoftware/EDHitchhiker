// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class FSSAllBodiesFound : BaseEvent
    {
        [JsonProperty(nameof(SystemName))]
        public string? SystemName { get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty(nameof(Count))]
        public int Count { get; set; } = 0;
    }
}
