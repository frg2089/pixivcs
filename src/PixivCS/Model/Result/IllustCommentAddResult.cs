using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class IllustCommentAddResult : ResultBase
    {
        [JsonPropertyName("comment")]
        public Comment Comment { get; set; }
    }
}
