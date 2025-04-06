// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class FSSSignalDiscovered : BaseEvent
    {
        [JsonProperty(nameof(SystemAddress))]
        public string? SystemAddress { get; set; }

        [JsonProperty(nameof(SignalName))]
        public string? SignalName { get; set; }

        [JsonProperty("SignalName_Localised")]
        public string? LocalisedSignalName { get; set; }

        [JsonProperty("USSType")]
        public string? UssType { get; set; }

        [JsonProperty("USSType_Localised")]
        public string? LocalisedUssType { get; set; }

        [JsonProperty(nameof(SpawningState))]
        public string? SpawningState { get; set; }

        [JsonProperty("SpawningState_Localised")]
        public string? LocalisedSpawningState { get; set; }

        [JsonProperty(nameof(SpawningFaction))]
        public string? SpawningFaction { get; set; }

        [JsonProperty(nameof(ThreatLevel))]
        public int ThreatLevel { get; set; } = 0;

        [JsonProperty(nameof(TimeRemaining))]
        public double TimeRemaining { get; set; } = 0;   // in seconds

        [JsonProperty(nameof(IsStation))]
        public bool IsStation { get; set; } = false;
    }
}
