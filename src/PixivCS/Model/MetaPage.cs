using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class MetaPage
    {
        [JsonPropertyName("image_urls")]
        public ImageUrls ImageUrls { get; set; }
    }


}
