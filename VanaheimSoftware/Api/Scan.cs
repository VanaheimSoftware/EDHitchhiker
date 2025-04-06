// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using EDHitchhiker.VanaheimSoftware.Api.Objects;
using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class Scan : BaseEvent
    {
        [JsonProperty(nameof(ScanType))]
        public string? ScanType { get; set; }

        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem { get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty("BodyID")]
        public int BodyId { get; set; } = -1;

        [JsonProperty(nameof(BodyName))]
        public string? BodyName { get; set; }

        [JsonProperty(nameof(DistanceFromArrivalLS))]
        public double DistanceFromArrivalLS { get; set; } = 0;

        [JsonProperty(nameof(StarType))]
        public string? StarType { get; set; }     // todo - maybe? serializer and deserializer converters

        [JsonProperty("Subclass")]
        public int SubClass { get; set; } = 0;

        [JsonProperty(nameof(StellarMass))]
        public double StellarMass { get; set; } = 0;

        [JsonProperty(nameof(Radius))]
        public double Radius { get; set; } = 0;

        [JsonProperty(nameof(AbsoluteMagnitude))]
        public double AbsoluteMagnitude { get; set; } = 0;

        [JsonProperty(nameof(RotationPeriod))]
        public double RotationPeriod { get; set; } = 0;     // in seconds

        [JsonProperty(nameof(SurfaceTemperature))]
        public double SurfaceTemperature { get; set; } = 0;

        [JsonProperty(nameof(Luminosity))]
        public string? Luminosity { get; set; }

        [JsonProperty("Age_MY")]
        public double AgeMillionYears { get; set; } = 0;    // in million years

        [JsonProperty(nameof(Rings))]
        public IList<Ring>? Rings { get; set; }

        [JsonProperty(nameof(WasDiscovered))]
        public bool WasDiscovered { get; set; } = false;

        [JsonProperty(nameof(WasMapped))]
        public bool WasMapped { get; set; } = false;

        [JsonProperty(nameof(Parents))]
        public IList<KeyValuePair<string, int>>? Parents { get; set; }

        [JsonProperty(nameof(TidalLock))]
        public bool TidalLock { get; set; } = false;

        [JsonProperty(nameof(TerraformState))]
        public string? TerraformState { get; set; }

        [JsonProperty(nameof(PlanetClass))]
        public string? PlanetClass { get; set; }    // todo - maybe? serializer and deserializer converters

        [JsonProperty(nameof(Atmosphere))]
        public string? Atmosphere { get; set; }

        [JsonProperty(nameof(AtmosphereType))]
        public string? AtmosphereType { get; set; }      // todo - enum? Section 5.14

        [JsonProperty(nameof(AtmosphereComposition))]
        public IList<AtmosphereComposition>? AtmosphereComposition { get; set; }

        [JsonProperty(nameof(Volcanism))]
        public string? Volcanism { get; set; }       // todo - enum? section 15.5

        [JsonProperty(nameof(SurfaceGravity))]
        public double SurfaceGravity { get; set; } = 0;

        [JsonProperty(nameof(SurfacePressure))]
        public double SurfacePressure { get; set; } = 0;

        [JsonProperty(nameof(Landable))]
        public bool Landable { get; set; } = false;

        [JsonProperty(nameof(Materials))]
        public IList<Material>? Materials { get; set; }

        [JsonProperty(nameof(Composition))]
        public Composition? Composition { get; set; }

        [JsonProperty(nameof(ReserveLevel))]
        public string? ReserveLevel { get; set; }

        [JsonProperty(nameof(AxialTilt))]
        public double AxialTilt { get; set; } = 0;

        [JsonProperty(nameof(SemiMajorAxis))]
        public double SemiMajorAxis { get; set; } = 0;

        [JsonProperty(nameof(Eccentricity))]
        public double Eccentricity { get; set; } = 0;

        [JsonProperty(nameof(OrbitalInclination))]
        public double OrbitalInclination { get; set; } = 0;

        [JsonProperty(nameof(Periapsis))]
        public double Periapsis { get; set; } = 0;

        [JsonProperty(nameof(OrbitalPeriod))]
        public double OrbitalPeriod { get; set; } = 0;

        [JsonProperty(nameof(AscendingNode))]
        public double AscendingNode { get; set; } = 0;

        [JsonProperty(nameof(MeanAnomaly))]
        public double MeanAnomaly { get; set; } = 0;
    }
}
