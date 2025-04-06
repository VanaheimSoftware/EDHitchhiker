using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class Rank : BaseEvent
    {
        [JsonProperty(nameof(Combat))]
        public int Combat { get; set; } = 0;

        [JsonProperty(nameof(Trade))]
        public int Trade { get; set; } = 0;

        [JsonProperty(nameof(Explore))]
        public int Explore { get; set; } = 0;

        [JsonProperty(nameof(Soldier))]
        public int Soldier { get; set; } = 0;

        [JsonProperty("Exobiologist")]
        public int ExoBiologist { get; set; } = 0;

        [JsonProperty(nameof(Empire))]
        public int Empire { get; set; } = 0;

        [JsonProperty(nameof(Federation))]
        public int Federation { get; set; } = 0;

        [JsonProperty("CQC")]
        public int Cqc { get; set; } = 0;

    }
}
