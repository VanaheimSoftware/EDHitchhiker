using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class Commander : BaseEvent
    {
        [JsonProperty(nameof(Name))]
        public string? Name { get; set; }

        [JsonProperty("FID")]
        public string? FrontierId { get; set; }
    }
}
