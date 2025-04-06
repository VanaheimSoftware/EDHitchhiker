// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class ScanBaryCentre : BaseEvent
    {
        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem { get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty("BodyID")]
        public int BodyId { get; set; } = -1;

        // todo - add remaining data items
    }
}
