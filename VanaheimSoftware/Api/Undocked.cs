// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class Undocked : BaseEvent
    {
        [JsonProperty(nameof(StationName))]
        public string? StationName { get; set; }

        [JsonProperty("MarketID")]
        public long MarketId { get; set; } = 0;

        [JsonProperty(nameof(StationType))]
        public string? StationType { get; set; }

        [JsonProperty(nameof(Taxi))]
        public bool Taxi { get; set; } = false;

        [JsonProperty("Multicrew")]
        public bool MultiCrew { get; set; } = false;
    }
}
