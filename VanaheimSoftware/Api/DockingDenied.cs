using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class DockingDenied : BaseEvent
    {
        [JsonProperty(nameof(StationName))]
        public string? StationName { get; set; }

        [JsonProperty(nameof(StationType))]
        public string? StationType { get; set; }

        [JsonProperty("MarketID")]
        public string? MarketId { get; set; }

        [JsonProperty(nameof(Reason))]
        public string? Reason { get; set; }
    }
}
