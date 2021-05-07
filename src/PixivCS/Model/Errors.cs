using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class Errors
    {
        [JsonPropertyName("system")]
        public SystemError System { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> UnknownErrors { get; set; }
    }
}
