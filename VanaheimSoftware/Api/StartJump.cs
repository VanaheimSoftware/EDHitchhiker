// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class StartJump : BaseEvent
    {
        [JsonProperty(nameof(JumpType))]
        public string? JumpType{ get; set; }

        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem{ get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty(nameof(StarClass))]
        public string? StarClass { get; set; }
    }
}
