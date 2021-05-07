using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class PixivisionSubcategory
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("label_en")]
        public string LabelEn { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("introduction")]
        public string Introduction { get; set; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("big_image_url")]
        public string BigImageUrl { get; set; }
    }
}
