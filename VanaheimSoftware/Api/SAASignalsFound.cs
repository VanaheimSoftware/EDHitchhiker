using EDHitchhiker.VanaheimSoftware.Api.Objects;
using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class SAASignalsFound : BaseEvent
    {
        [JsonProperty(nameof(BodyName))]
        public string? BodyName { get; set; }

        [JsonProperty(nameof(Signals))]
        public IList<Signal>? Signals { get; set; }
    }
}
