using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class Url
    {
        [JsonPropertyName("1200x1200")]
        public Uri The1200X1200 { get; set; }

        [JsonPropertyName("768x1200")]
        public Uri The768X1200 { get; set; }

        [JsonPropertyName("ugoira600x600")]
        public string Ugoira600X600 { get; set; }

        [JsonPropertyName("ugoira1920x1080")]
        public string Ugoira1920X1080 { get; set; }
    }
}
