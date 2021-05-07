using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class UserListResult : ResultBase
    {
        [JsonPropertyName("users")]
        public dynamic[] Users { get; set; }
    }
}
