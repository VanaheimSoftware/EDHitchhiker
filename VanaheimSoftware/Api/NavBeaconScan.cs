using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class NavBeaconScan : BaseEvent
    {
        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty("NumBodies")]
        public int NumberOfBodies { get; set; } = 0;
    }
}
