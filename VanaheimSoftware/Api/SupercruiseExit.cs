// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class SupercruiseExit : BaseEvent
    {
        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem { get; set; }

        [JsonProperty(nameof(Body))]
        public string? Body { get; set; }

        [JsonProperty("BodyID")]
        public int BodyId { get; set; } = -1;

        [JsonProperty(nameof(Taxi))]
        public bool Taxi { get; set; } = false;

        [JsonProperty("Multicrew")]
        public bool IsMultiCrew { get; set; } = false;

        [JsonProperty(nameof(BodyType))]
        public string? BodyType { get; set; }
    }
}
