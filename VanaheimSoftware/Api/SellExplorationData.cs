﻿// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class SellExplorationData : BaseEvent
    {
        [JsonProperty(nameof(Systems))]
        public IList<string>? Systems { get; set; }

        [JsonProperty(nameof(Discovered))]
        public IList<string>? Discovered { get; set; }

        [JsonProperty(nameof(BaseValue))]
        public long BaseValue { get; set; } = 0;

        [JsonProperty(nameof(Bonus))]
        public long Bonus { get; set; } = 0;

        [JsonProperty(nameof(TotalEarnings))]
        public long TotalEarnings { get; set; } = 0;

    }
}
