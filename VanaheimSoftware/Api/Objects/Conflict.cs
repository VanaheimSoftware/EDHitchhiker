using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class Conflict
    {
        [JsonProperty(nameof(WarType))]
        public string? WarType { get; set; }

        [JsonProperty(nameof(Status))]
        public string? Status { get; set; }

        [JsonProperty("Faction1")]
        public ConflictFaction? FactionOne { get; set; }

        [JsonProperty("Faction2")]
        public ConflictFaction? FactionTwo { get; set; }
    }
}
