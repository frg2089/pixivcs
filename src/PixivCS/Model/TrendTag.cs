using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class TrendTag
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("translated_name")]
        public string TranslatedName { get; set; }

        [JsonPropertyName("illust")]
        public UserPreviewIllust Illust { get; set; }
    }


}
