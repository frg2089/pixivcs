using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class PixivisionCategory
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("introduction")]
        public string Introduction { get; set; }
    }
}
