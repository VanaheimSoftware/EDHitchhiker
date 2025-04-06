using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class SAAScanComplete : BaseEvent
    {
        [JsonProperty(nameof(BodyName))]
        public string? BodyName { get; set; }

        [JsonProperty(nameof(ProbesUsed))]
        public int ProbesUsed { get; set; } = 0;

        [JsonProperty(nameof(EfficiencyTarget))]
        public int EfficiencyTarget { get; set; } = 0;
    }
}
