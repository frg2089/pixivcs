using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class UgoiraMetadataClass
    {
        [JsonPropertyName("zip_urls")]
        public Urls ZipUrls { get; set; }

        [JsonPropertyName("frames")]
        public Frame[] Frames { get; set; }
    }
}
