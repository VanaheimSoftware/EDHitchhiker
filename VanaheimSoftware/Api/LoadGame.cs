using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class LoadGame : BaseEvent
    {
        [JsonProperty(nameof(Commander))]
        public string? Commander { get; set; }

        [JsonProperty("FID")]
        public string? FrontierId { get; set; }

        [JsonProperty(nameof(Horizons))]
        public bool Horizons { get; set; } = false;

        [JsonProperty(nameof(Odyssey))]
        public bool Odyssey { get; set; } = false;

        [JsonProperty("Ship")]
        public string? ShipType { get; set; }

        [JsonProperty("ShipID")]
        public int ShipId { get; set; } = 0;

        [JsonProperty(nameof(ShipName))]
        public string? ShipName { get; set; }

        [JsonProperty("ShipIdent")]
        public string? ShipIdentifier { get; set; }

        [JsonProperty(nameof(FuelLevel))]
        public float FuelLevel { get; set; } = 0;

        [JsonProperty(nameof(FuelCapacity))]
        public float FuelCapacity { get; set; } = 0;

        [JsonProperty(nameof(GameMode))]
        public string? GameMode { get; set; }

        [JsonProperty(nameof(Credits))]
        public long Credits { get; set; } = 0;

        [JsonProperty(nameof(Loan))]
        public long Loan { get; set; } = 0;

        [JsonProperty(nameof(Language))]
        public string? Language { get; set; }

        [JsonProperty("gameversion")]
        public string? GameVersion { get; set; }
    }
}
