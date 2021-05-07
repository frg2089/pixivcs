using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class AuthResult : ResultBase
    {
        [JsonPropertyName("response")]
        public Response Response { get; set; }
    }
}
