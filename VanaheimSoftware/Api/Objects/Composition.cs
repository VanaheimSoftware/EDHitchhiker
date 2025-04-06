// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class Composition
    {
        [JsonProperty(nameof(Ice))]
        public double Ice { get; set; } = 0;

        [JsonProperty(nameof(Rock))]
        public double Rock { get; set; } = 0;

        [JsonProperty(nameof(Metal))]
        public double Metal { get; set; } = 0;
    }
}
