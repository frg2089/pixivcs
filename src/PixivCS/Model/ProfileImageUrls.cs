using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class ProfileImageUrls
    {
        [JsonPropertyName("px_16x16")]
        public Uri Px16X16 { get; set; }

        [JsonPropertyName("px_50x50")]
        public Uri Px50X50 { get; set; }

        [JsonPropertyName("px_170x170")]
        public Uri Px170X170 { get; set; }
    }


}
