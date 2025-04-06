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
