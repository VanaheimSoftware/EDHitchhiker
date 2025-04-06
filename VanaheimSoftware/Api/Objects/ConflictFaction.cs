using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class ConflictFaction
    {
        [JsonProperty(nameof(Name))]
        public string? Name { get; set; }

        [JsonProperty(nameof(Stake))]
        public string? Stake { get; set; }

        [JsonProperty(nameof(WonDays))]
        public int WonDays { get; set; } = 0;

    }
}
