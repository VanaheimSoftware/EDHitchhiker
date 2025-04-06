using EDHitchhiker.VanaheimSoftware.Api.Objects;
using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class Loadout : BaseEvent
    {
        [JsonProperty("Ship")]
        public string? ShipType { get; set; }

        [JsonProperty("ShipID")]
        public int ShipId { get; set; } = 0;

        [JsonProperty(nameof(ShipName))]
        public string? ShipName { get; set; }

        [JsonProperty("ShipIdent")]
        public string? ShipIdentification { get; set; }

        [JsonProperty(nameof(HullValue))]
        public long HullValue { get; set; } = 0;

        [JsonProperty(nameof(ModulesValue))]
        public long ModulesValue { get; set; } = 0;

        [JsonProperty(nameof(HullHealth))]
        public float HullHealth { get; set; } = 0;

        [JsonProperty(nameof(UnladenMass))]
        public double UnladenMass { get; set; } = 0;

        [JsonProperty(nameof(CargoCapacity))]
        public int CargoCapacity { get; set; } = 0;

        [JsonProperty(nameof(MaxJumpRange))]
        public float MaxJumpRange { get; set; } = 0; // light years

        [JsonProperty(nameof(FuelCapacity))]
        public FuelCapacity? FuelCapacity { get; set; }

        [JsonProperty(nameof(Rebuy))]
        public long Rebuy { get; set; } = 0;

        // todo - Add Hot (boolean?) and Modules (large object array)
    }
}
