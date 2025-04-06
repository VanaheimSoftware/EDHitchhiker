using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class FSDTarget : BaseEvent
    {
        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem { get; set; }

        [JsonProperty(nameof(RemainingJumpsInRoute))]
        public int RemainingJumpsInRoute { get; set; } = 0;

        [JsonProperty(nameof(StarClass))]
        public string? StarClass { get; set; }
    }
}
