using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class Response
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("expires_in")]
        public long ExpiresIn { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonPropertyName("user")]
        public ResponseUser User { get; set; }

        [JsonPropertyName("device_token")]
        public string DeviceToken { get; set; }
    }


}
