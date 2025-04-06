using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class LandingPads
    {
        [JsonProperty(nameof(Small))]
        public int Small { get; set; } = 0;     // todo - investigate if these could be boolean instead of integer

        [JsonProperty(nameof(Medium))]
        public int Medium { get; set; } = 0;

        [JsonProperty(nameof(Large))]
        public int Large { get; set; } = 0;
    }
}
