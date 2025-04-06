using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class BaseEvent
    {
        [JsonProperty("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }

        [JsonProperty("event")]
        public string? EventType { get; set; }
    }
}
