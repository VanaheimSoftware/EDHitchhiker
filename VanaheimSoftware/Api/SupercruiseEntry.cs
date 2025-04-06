using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class SupercruiseEntry : BaseEvent
    {
        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem { get; set; }

        [JsonProperty(nameof(Taxi))]
        public bool Taxi { get; set; } = false;

        [JsonProperty("Multicrew")]
        public bool MultiCrew { get; set; } = false;
    }
}
