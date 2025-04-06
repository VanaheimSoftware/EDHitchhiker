using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class FSSAllBodiesFound : BaseEvent
    {
        [JsonProperty(nameof(SystemName))]
        public string? SystemName { get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty(nameof(Count))]
        public int Count { get; set; } = 0;
    }
}
