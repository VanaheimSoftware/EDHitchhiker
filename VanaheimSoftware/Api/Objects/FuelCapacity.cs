using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class FuelCapacity
    {
        [JsonProperty(nameof(Main))]
        public float Main { get; set; } = 0;

        [JsonProperty(nameof(Reserve))]
        public float Reserve { get; set; } = 0;
    }
}
