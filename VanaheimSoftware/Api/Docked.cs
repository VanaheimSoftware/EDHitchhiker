using EDHitchhiker.VanaheimSoftware.Api.Objects;
using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class Docked : BaseEvent
    {
        [JsonProperty(nameof(StationName))]
        public string? StationName { get; set; }

        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem { get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty("MarketID")]
        public long MarketId { get; set; } = 0;

        [JsonProperty(nameof(StationType))]
        public string? StationType { get; set; }

        [JsonProperty(nameof(CockpitBreach))]
        public bool CockpitBreach { get; set; } = false;

        [JsonProperty(nameof(StationFaction))]
        public Faction? StationFaction{ get; set; }

        [JsonProperty(nameof(StationGovernment))]
        public string? StationGovernment { get; set; }

        [JsonProperty("StationGovernment_Localised")]
        public string? LocalisedStationGovernment { get; set; }

        [JsonProperty(nameof(SystemEconomy))]
        public string? SystemEconomy { get; set; }

        [JsonProperty("SystemEconomy_Localised")]
        public string? LocalisedSystemEconomy { get; set; }

        [JsonProperty(nameof(StationEconomies))]
        public IList<StationEconomy>? StationEconomies{ get; set; }

        [JsonProperty(nameof(StationAllegiance))]
        public string? StationAllegiance { get; set; }

        [JsonProperty("DistFromStarLS")]
        public double DistanceFromStarLS { get; set; } = 0;   // Light seconds

        [JsonProperty(nameof(StationServices))]
        public IList<string>? StationServices{ get; set; }

        [JsonProperty(nameof(Wanted))]
        public bool Wanted { get; set; } = false;

        [JsonProperty(nameof(ActiveFine))]
        public bool ActiveFine { get; set; } = false;

        [JsonProperty(nameof(LandingPads))]
        public LandingPads? LandingPads{ get; set; }

        [JsonProperty(nameof(Taxi))]
        public bool Taxi { get; set; } = false;

        [JsonProperty("Multicrew")]
        public bool MultiCrew { get; set; } = false;
    }
}
