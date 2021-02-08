using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PixivCS.Objects
{
    public class SystemError
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }
    }

    public class Errors
    {
        [JsonPropertyName("system")]
        public SystemError System { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> UnknownErrors { get; set; }
    }

    public class ErrorResult
    {
        [JsonPropertyName("has_error")]
        public bool HasError { get; set; }

        [JsonPropertyName("errors")]
        public Errors Errors { get; set; }

        [JsonPropertyName("error")]
        public object Error { get; set; }
    }
    public class ResultBase : ErrorResult
    {
        [JsonExtensionData]
        public Dictionary<string, object> ExtensionData { get; set; }
    }
}
