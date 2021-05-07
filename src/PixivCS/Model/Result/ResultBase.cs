using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class ResultBase : ErrorResult
    {
        [JsonExtensionData]
        public Dictionary<string, object> ExtensionData { get; set; }
    }
}
