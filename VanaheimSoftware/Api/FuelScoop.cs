using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class FuelScoop : BaseEvent
    {
        [JsonProperty(nameof(Scooped))]
        public float Scooped { get; set; } = 0;

        [JsonProperty(nameof(Total))]
        public float Total { get; set; } = 0;
    }
}
