// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class StationEconomy
    {
        [JsonProperty(nameof(Name))]
        public string? Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string? LocalisedName { get; set; }

        [JsonProperty(nameof(Proportion))]
        public long Proportion { get; set; } = 0;
    }
}
