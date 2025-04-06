using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api
{
    public class ReceiveText : BaseEvent
    {
        [JsonProperty(nameof(From))]
        public string? From { get; set; }

        [JsonProperty(nameof(Channel))]
        public string? Channel { get; set; }

        [JsonProperty(nameof(Message))]
        public string? Message { get; set; }

        [JsonProperty("Message_Localised")]
        public string? LocalisedMessage { get; set; }
    }
}
