using EDHitchhiker.VanaheimSoftware.Api.Objects;
using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class NavRoute : BaseEvent
    {
        [JsonProperty(nameof(Route))]
        public IList<Route>? Route { get; set; }
    }
}
