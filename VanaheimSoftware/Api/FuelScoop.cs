// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class FuelScoop : BaseEvent
    {
        [JsonProperty(nameof(Scooped))]
        public float Scooped { get; set; } = 0;

        [JsonProperty(nameof(Total))]
        public float Total { get; set; } = 0;
    }
}
