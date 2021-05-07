using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class Urls
    {
        [JsonPropertyName("medium")]
        public Uri Medium { get; set; }
    }
}
