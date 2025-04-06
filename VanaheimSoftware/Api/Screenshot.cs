// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class Screenshot : BaseEvent
    {
        [JsonProperty(nameof(Filename))]
        public string? Filename { get; set; }

        [JsonProperty(nameof(Width))]
        public int Width { get; set; } = 0;

        [JsonProperty(nameof(Height))]
        public int Height { get; set; } = 0;

        [JsonProperty(nameof(System))]
        public string? System { get; set; }

        [JsonProperty(nameof(Altitude))]
        public double Altitude { get; set; } = 0;

        [JsonProperty(nameof(Heading))]
        public int Heading { get; set; } = 0;

        [JsonProperty(nameof(Latitude))]
        public double Latitude { get; set; } = 0;

        [JsonProperty(nameof(Longitude))]
        public double Longitude { get; set; } = 0;
    }
}
