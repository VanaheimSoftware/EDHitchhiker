using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class BuyExplorationData : BaseEvent
    {
        [JsonProperty(nameof(System))]
        public string? System { get; set; }

        [JsonProperty(nameof(Cost))]
        public long Cost { get; set; } = 0;
    }
}
