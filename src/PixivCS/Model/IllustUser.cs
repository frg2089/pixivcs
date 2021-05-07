using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class IllustUser
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("account")]
        public string Account { get; set; }

        [JsonPropertyName("profile_image_urls")]
        public Urls ProfileImageUrls { get; set; }

        [JsonPropertyName("is_followed")]
        public bool? IsFollowed { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }


}
