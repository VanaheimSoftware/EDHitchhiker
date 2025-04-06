// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using EDHitchhiker.VanaheimSoftware.Api.Objects;
using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class DockingRequested : BaseEvent
    {
        [JsonProperty(nameof(StationName))]
        public string? StationName { get; set; }

        [JsonProperty(nameof(StationType))]
        public string? StationType { get; set; }

        [JsonProperty("MarketID")]
        public string? MarketId { get; set; }

        [JsonProperty(nameof(LandingPads))]
        public LandingPads? LandingPads { get; set; }
    }
}
