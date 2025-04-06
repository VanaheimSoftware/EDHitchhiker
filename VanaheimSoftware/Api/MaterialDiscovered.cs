using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class MaterialDiscovered : BaseEvent
    {
        [JsonProperty(nameof(Category))]
        public string? Category { get; set; }

        [JsonProperty(nameof(Name))]
        public string? Name { get; set; }

        [JsonProperty(nameof(DiscoveryNumber))]
        public int DiscoveryNumber { get; set; } = 0;
    }
}
