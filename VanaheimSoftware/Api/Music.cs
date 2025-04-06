using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class Music : BaseEvent
    {
        [JsonProperty(nameof(MusicTrack))]
        public string? MusicTrack { get; set; }
    }
}
