using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class Route
    {
        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem { get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty("StarPos")]
        public IList<float>? StarPosition { get; set; }

        [JsonProperty(nameof(StarClass))]
        public string? StarClass { get; set; }
    }
}
