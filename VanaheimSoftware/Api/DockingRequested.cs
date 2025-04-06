using EDHitchhiker.VanaheimSoftware.Api.Objects;
using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class DockingRequested : BaseEvent
    {
        [JsonProperty(nameof(StationName))]
        public string? StationName { get; set; }

        [JsonProperty(nameof(StationType))]
        public string? StationType { get; set; }

        [JsonProperty("MarketID")]
        public string? MarketId { get; set; }

        [JsonProperty(nameof(LandingPads))]
        public LandingPads? LandingPads { get; set; }
    }
}
