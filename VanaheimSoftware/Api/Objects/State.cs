// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class State
    {
        [JsonProperty("State")]
        public string? StateName { get; set; }  // note: State is a reserved name

        [JsonProperty(nameof(Trend))]
        public long Trend { get; set; } = 0;
    }
}
