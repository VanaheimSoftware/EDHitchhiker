// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class Progress : BaseEvent
    {
        [JsonProperty(nameof(Combat))]
        public int Combat { get; set; } = 0;

        [JsonProperty(nameof(Trade))]
        public int Trade { get; set; } = 0;

        [JsonProperty(nameof(Explore))]
        public int Explore { get; set; } = 0;

        [JsonProperty(nameof(Soldier))]
        public int Soldier { get; set; } = 0;

        [JsonProperty("Exobiologist")]
        public int ExoBiologist { get; set; } = 0;

        [JsonProperty(nameof(Empire))]
        public int Empire { get; set; } = 0;

        [JsonProperty(nameof(Federation))]
        public int Federation { get; set; } = 0;

        [JsonProperty("CQC")]
        public int Cqc { get; set; } = 0;
    }
}
