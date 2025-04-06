using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class ScanBaryCentre : BaseEvent
    {
        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem { get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty("BodyID")]
        public int BodyId { get; set; } = -1;

        // todo - add remaining data items
    }
}
