// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using EDHitchhiker.VanaheimSoftware.Api.Objects;
using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class Location : BaseEvent
    {
        [JsonProperty("StarPos")]
        public IList<double>? StarPositions { get; set; }

        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem { get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty(nameof(Body))]
        public string? Body { get; set; }

        [JsonProperty("BodyID")]
        public int BodyId { get; set; } = -1;

        [JsonProperty(nameof(BodyType))]
        public string? BodyType { get; set; }

        [JsonProperty("DistFromStarLS")]    // Light seconds
        public double DistanceFromStar { get; set; } = 0;

        [JsonProperty("Docked")]
        public bool Docked { get; set; } = false;

        [JsonProperty(nameof(StationName))]
        public string? StationName { get; set; }

        [JsonProperty(nameof(StationType))]
        public string? StationType { get; set; }

        [JsonProperty("MarketID")]
        public long MarketId { get; set; } = 0;

        [JsonProperty(nameof(SystemFaction))]
        public Faction? SystemFaction { get; set; }

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

        [JsonProperty(nameof(Wanted))]
        public bool Wanted { get; set; } = false;

        [JsonProperty(nameof(Factions))]
        public IList<Faction>? Factions { get; set; }

        [JsonProperty(nameof(Conflicts))]
        public IList<Conflict>? Conflicts { get; set; }

        [JsonProperty(nameof(StationFaction))]
        public Faction? StationFaction { get; set; }

        [JsonProperty(nameof(StationAllegiance))]
        public string? StationAllegiance { get; set; }

        [JsonProperty(nameof(StationGovernment))]
        public string? StationGovernment { get; set; }

        [JsonProperty("StationGovernment_Localised")]
        public string? LocalisedStationGovernment { get; set; }

        [JsonProperty(nameof(StationServices))]
        public IList<string>? StationServices { get; set; }

        [JsonProperty(nameof(StationEconomies))]
        public IList<StationEconomy>? StationEconomies { get; set; }

        [JsonProperty(nameof(Taxi))]
        public bool Taxi { get; set; } = false;

        [JsonProperty("Multicrew")]
        public bool MultiCrew { get; set; } = false;

        [JsonProperty(nameof(InSRV))]
        public bool InSRV { get; set; } = false;

        [JsonProperty("onFoot")]
        public bool OnFoot { get; set; } = false;

        [JsonProperty(nameof(Latitude))]
        public double Latitude { get; set; } = 0;

        [JsonProperty(nameof(Longitude))]
        public double Longitude { get; set; } = 0;
    }
}
