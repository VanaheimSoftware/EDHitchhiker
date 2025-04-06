// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class FuelCapacity
    {
        [JsonProperty(nameof(Main))]
        public float Main { get; set; } = 0;

        [JsonProperty(nameof(Reserve))]
        public float Reserve { get; set; } = 0;
    }
}
