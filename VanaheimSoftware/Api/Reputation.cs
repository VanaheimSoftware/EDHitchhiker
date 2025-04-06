using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class Reputation : BaseEvent
    {
        [JsonProperty(nameof(Empire))]
        public double Empire { get; set; } = 0;

        [JsonProperty(nameof(Federation))]
        public double Federation { get; set; } = 0;

        [JsonProperty(nameof(Independent))]
        public double Independent { get; set; } = 0;

        [JsonProperty(nameof(Alliance))]
        public double Alliance { get; set; } = 0;
    }
}
