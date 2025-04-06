using Newtonsoft.Json;
using EDHitchhiker.VanaheimSoftware.Api.Objects;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class FSDJump : BaseEvent
    {
        [JsonProperty("StarPos")]
        public IList<double>? StarPosition { get; set; }

        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem { get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; }

        [JsonProperty(nameof(Body))]
        public string? Body { get; set; }

        [JsonProperty("BodyID")]
        public int BodyId { get; set; } = -1;

        [JsonProperty(nameof(BodyType))]
        public string? BodyType { get; set; }

        [JsonProperty("JumpDist")]
        public double JumpDistance { get; set; } = 0;   // Light years

        [JsonProperty(nameof(BoostUsed))]
        public bool BoostUsed { get; set; } = false;

        [JsonProperty(nameof(SystemFaction))]
        public SystemFaction? SystemFaction { get; set; }

        [JsonProperty(nameof(FuelUsed))]
        public float FuelUsed { get; set; } = 0;

        [JsonProperty(nameof(FuelLevel))]
        public float FuelLevel { get; set; } = 0;

        [JsonProperty(nameof(SystemAllegiance))]
        public string? SystemAllegiance { get; set; }

        [JsonProperty(nameof(SystemEconomy))]
        public string? SystemEconomy { get; set; }

        [JsonProperty("SystemEconomy_Localised")]
        public string? LocalisedSystemEconomy { get; set; }

        [JsonProperty(nameof(SystemSecondEconomy))]
        public string? SystemSecondEconomy { get; set; }

        [JsonProperty("SystemSecondEconomy_Localised")]
        public string? LocalisedSystemSecondEconomy { get; set; }

        [JsonProperty(nameof(SystemGovernment))]
        public string? SystemGovernment { get; set; }

        [JsonProperty("SystemGovernment_Localised")]
        public string? LocalisedSystemGovernment { get; set; }

        [JsonProperty(nameof(SystemSecurity))]
        public string? SystemSecurity { get; set; }

        [JsonProperty("SystemSecurity_Localised")]
        public string? LocalisedSystemSecurity { get; set; }

        [JsonProperty(nameof(Population))]
        public long Population { get; set; } = 0;

        [JsonProperty(nameof(Wanted))]
        public bool Wanted { get; set; } = false;

        [JsonProperty(nameof(Factions))]
        public IList<Faction>? Factions { get; set; }

        [JsonProperty(nameof(Conflicts))]
        public IList<Conflict>? Conflicts { get; set; }

        [JsonProperty(nameof(Taxi))]
        public bool Taxi { get; set; } = false;

        [JsonProperty("Multicrew")]
        public bool MultiCrew { get; set; } = false;
    }
}
