using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class MetaSinglePage
    {
        [JsonPropertyName("original_image_url")]
        public Uri OriginalImageUrl { get; set; }
    }


}
