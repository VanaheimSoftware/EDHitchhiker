using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class State
    {
        [JsonProperty("State")]
        public string? StateName { get; set; }  // note: State is a reserved name

        [JsonProperty(nameof(Trend))]
        public long Trend { get; set; } = 0;
    }
}
