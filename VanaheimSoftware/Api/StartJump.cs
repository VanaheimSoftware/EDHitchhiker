using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class StartJump : BaseEvent
    {
        [JsonProperty(nameof(JumpType))]
        public string? JumpType{ get; set; }

        [JsonProperty(nameof(StarSystem))]
        public string? StarSystem{ get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty(nameof(StarClass))]
        public string? StarClass { get; set; }
    }
}
