using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class SystemError
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }
    }
}
