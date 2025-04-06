using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api.Objects {
    public class Faction
    {
        [JsonProperty(nameof(Name))]
        public string? Name { get; set; }

        [JsonProperty(nameof(FactionState))]
        public string? FactionState { get; set; }

        [JsonProperty(nameof(Government))]
        public string? Government { get; set; }

        [JsonProperty(nameof(Influence))]
        public double Influence { get; set; }

        [JsonProperty(nameof(Happiness))]
        public string? Happiness { get; set; }

        [JsonProperty("Happiness_Localised")]
        public string? LocalisedHappiness { get; set; }

        [JsonProperty(nameof(MyReputation))]
        public double MyReputation { get; set; }

        [JsonProperty(nameof(PendingStates))]
        public IList<State>? PendingStates { get; set; }

        [JsonProperty(nameof(RecoveringStates))]
        public IList<State>? RecoveringStates { get; set; }

        [JsonProperty(nameof(ActiveStates))]
        public IList<State>? ActiveStates { get; set; }

        [JsonProperty(nameof(SquadronFaction))]
        public bool SquadronFaction { get; set; }

        [JsonProperty(nameof(HappiestSystem))]
        public bool HappiestSystem { get; set; } = false;

        [JsonProperty(nameof(HomeSystem))]
        public bool HomeSystem { get; set; } = false;
    }
}
