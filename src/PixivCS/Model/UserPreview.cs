using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class UserPreview
    {
        [JsonPropertyName("user")]
        public IllustUser User { get; set; }

        [JsonPropertyName("illusts")]
        public UserPreviewIllust[] Illusts { get; set; }

        [JsonPropertyName("novels")]
        public dynamic[] Novels { get; set; }

        [JsonPropertyName("is_muted")]
        public bool IsMuted { get; set; }
    }


}
