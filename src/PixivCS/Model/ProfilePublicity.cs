using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class ProfilePublicity
    {
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("birth_day")]
        public string BirthDay { get; set; }

        [JsonPropertyName("birth_year")]
        public string BirthYear { get; set; }

        [JsonPropertyName("job")]
        public string Job { get; set; }

        [JsonPropertyName("pawoo")]
        public bool Pawoo { get; set; }
    }


}
