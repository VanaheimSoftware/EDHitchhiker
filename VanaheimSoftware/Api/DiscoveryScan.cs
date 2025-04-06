using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class DiscoveryScan : BaseEvent
    {
        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty(nameof(Bodies))]
        public int Bodies { get; set; } = 0;
    }
}
