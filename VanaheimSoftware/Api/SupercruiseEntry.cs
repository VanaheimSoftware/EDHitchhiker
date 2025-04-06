// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class SupercruiseEntry : BaseEvent
    {
        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem { get; set; }

        [JsonProperty(nameof(Taxi))]
        public bool Taxi { get; set; } = false;

        [JsonProperty("Multicrew")]
        public bool MultiCrew { get; set; } = false;
    }
}
