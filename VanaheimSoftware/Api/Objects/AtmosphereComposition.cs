﻿using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class AtmosphereComposition
    {
        [JsonProperty(nameof(Name))]
        public string? Name { get; set; }

        [JsonProperty(nameof(Percent))]
        public double Percent { get; set; } = 0;
    }
}
