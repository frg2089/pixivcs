using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{

    public class ErrorResult
    {
        [JsonPropertyName("has_error")]
        public bool HasError { get; set; }

        [JsonPropertyName("errors")]
        public Errors Errors { get; set; }

        [JsonPropertyName("error")]
        public object Error { get; set; }
    }
}
