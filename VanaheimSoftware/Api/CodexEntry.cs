using Newtonsoft.Json;

namespace EDHitchhiker.VanaheimSoftware.Api {
    public class CodexEntry : BaseEvent
    {
        [JsonProperty("EntryID")]
        public long EntryId { get; set; } = -1;

        [JsonProperty(nameof(Name))]
        public string? Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string? LocalisedName { get; set; }

        [JsonProperty(nameof(SubCategory))]
        public string? SubCategory { get; set; }

        [JsonProperty("SubCategory_Localised")]
        public string? LocalisedSubCategory { get; set; }

        [JsonProperty(nameof(Category))]
        public string? Category { get; set; }

        [JsonProperty("Category_Localised")]
        public string? LocalisedCategory { get; set; }

        [JsonProperty(nameof(Region))]
        public string? Region { get; set; }

        [JsonProperty("Region_Localised")]
        public string? LocalisedRegion { get; set; }

        [JsonProperty(nameof(System))]
        public string? System { get; set; }

        [JsonProperty(nameof(SystemAddress))]
        public long SystemAddress { get; set; } = 0;

        [JsonProperty(nameof(NearestDestination))]
        public string? NearestDestination { get; set; }

        [JsonProperty("NearestDestination_Localised")]
        public string? LocalisedNearestDestination { get; set; }

        [JsonProperty("IsNewEntry")]
        public bool NewEntry { get; set; } = false;

        [JsonProperty(nameof(NewTraitsDiscovered))]
        public bool NewTraitsDiscovered { get; set; } = false;

        [JsonProperty(nameof(Traits))]
        public IList<string>? Traits { get; set; }

        [JsonProperty(nameof(VoucherAmount))]
        public long VoucherAmount { get; set; } = 0;

        [JsonProperty(nameof(Latitude))]
        public double Latitude { get; set; } = 0;

        [JsonProperty(nameof(Longitude))]
        public double Longitude { get; set; } = 0;
    }
}
