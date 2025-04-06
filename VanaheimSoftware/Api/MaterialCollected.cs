using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class MaterialCollected : BaseEvent
    {
        [JsonProperty(nameof(Category))]
        public string? Category { get; set; }

        [JsonProperty(nameof(Name))]
        public string? Name { get; set; }

        [JsonProperty(nameof(Count))]
        public int Count { get; set; } = 0;
    }
}
