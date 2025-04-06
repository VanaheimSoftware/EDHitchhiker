using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    // honk!
    public class FSSDiscoveryScan : BaseEvent
    {
        [JsonProperty(nameof(SystemName))]
        public string? SystemName { get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty(nameof(Progress))]
        public double Progress { get; set; } = 0;

        [JsonProperty(nameof(BodyCount))]
        public int BodyCount { get; set; } = 0;

        [JsonProperty(nameof(NonBodyCount))]
        public int NonBodyCount { get; set; } = 0;
    }
}
