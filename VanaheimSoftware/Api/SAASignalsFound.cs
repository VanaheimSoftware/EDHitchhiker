// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using EDHitchhiker.VanaheimSoftware.Api.Objects;
using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class SAASignalsFound : BaseEvent
    {
        [JsonProperty(nameof(BodyName))]
        public string? BodyName { get; set; }

        [JsonProperty(nameof(Signals))]
        public IList<Signal>? Signals { get; set; }
    }
}
