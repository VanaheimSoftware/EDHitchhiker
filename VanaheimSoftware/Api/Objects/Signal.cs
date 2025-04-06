using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class Signal
    {
        [JsonProperty(nameof(Type))]
        public string? Type { get; set; }

        [JsonProperty(nameof(Count))]
        public int Count { get; set; } = 0;
    }
}
