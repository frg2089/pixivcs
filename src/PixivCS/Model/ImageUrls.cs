using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class ImageUrls
    {
        [JsonPropertyName("square_medium")]
        public Uri SquareMedium { get; set; }

        [JsonPropertyName("medium")]
        public Uri Medium { get; set; }

        [JsonPropertyName("large")]
        public Uri Large { get; set; }

        [JsonPropertyName("original")]
        public Uri Original { get; set; }
    }


}
