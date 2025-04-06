using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class StationEconomy
    {
        [JsonProperty(nameof(Name))]
        public string? Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string? LocalisedName { get; set; }

        [JsonProperty(nameof(Proportion))]
        public long Proportion { get; set; } = 0;
    }
}
