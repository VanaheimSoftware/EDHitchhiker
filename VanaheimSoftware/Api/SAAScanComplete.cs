// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class SAAScanComplete : BaseEvent
    {
        [JsonProperty(nameof(BodyName))]
        public string? BodyName { get; set; }

        [JsonProperty(nameof(ProbesUsed))]
        public int ProbesUsed { get; set; } = 0;

        [JsonProperty(nameof(EfficiencyTarget))]
        public int EfficiencyTarget { get; set; } = 0;
    }
}
