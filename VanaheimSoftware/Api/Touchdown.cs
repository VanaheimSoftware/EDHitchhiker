using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class Touchdown : BaseEvent
    {
        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem { get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; }

        [JsonProperty(nameof(Body))]
        public string? Body { get; set; }

        [JsonProperty("BodyID")]
        public int BodyId { get; set; } = -1;

        [JsonProperty(nameof(OnStation))]
        public bool OnStation { get; set; } = false;

        [JsonProperty(nameof(OnPlanet))]
        public bool OnPlanet { get; set; } = false;

        [JsonProperty(nameof(Taxi))]
        public bool Taxi { get; set; } = false;

        [JsonProperty("Multicrew")]
        public bool MultiCrew { get; set; } = false;

        [JsonProperty(nameof(NearestDestination))]
        public string? NearestDestination { get; set; }

        [JsonProperty("NearestDestination_Localised")]
        public string? LocalisedNearestDestination { get; set; }

        [JsonProperty(nameof(PlayerControlled))]
        public bool PlayerControlled { get; set; } = false;

        [JsonProperty(nameof(Latitude))]
        public double Latitude { get; set; } = 0;

        [JsonProperty(nameof(Longitude))]
        public double Longitude { get; set; } = 0;
    }
}
