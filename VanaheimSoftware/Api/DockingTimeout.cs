using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class DockingTimeout : BaseEvent
    {
        [JsonProperty(nameof(StationName))]
        public string? StationName { get; set; }

        [JsonProperty(nameof(StationType))]
        public string? StationType { get; set; }

        [JsonProperty("MarketID")]
        public string? MarketId { get; set; }
    }
}
