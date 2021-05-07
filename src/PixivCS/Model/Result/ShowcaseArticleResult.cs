using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class ShowcaseArticleResult : ResultBase
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("body")]
        public Body[] Body { get; set; }
    }
}
