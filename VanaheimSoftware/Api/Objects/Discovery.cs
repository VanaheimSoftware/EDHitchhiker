using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class Discovery
    {
        [JsonProperty(nameof(SystemName))]
        public string? SystemName { get; set; }

        [JsonProperty("NumBodies")]
        public int NumberOfBodies { get; set; } = 0;
    }
}
