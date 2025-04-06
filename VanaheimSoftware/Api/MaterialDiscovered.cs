// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class MaterialDiscovered : BaseEvent
    {
        [JsonProperty(nameof(Category))]
        public string? Category { get; set; }

        [JsonProperty(nameof(Name))]
        public string? Name { get; set; }

        [JsonProperty(nameof(DiscoveryNumber))]
        public int DiscoveryNumber { get; set; } = 0;
    }
}
