using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class IllustBookmarkDetailResult : ResultBase
    {
        [JsonPropertyName("bookmark_detail")]
        public BookmarkDetail BookmarkDetail { get; set; }
    }
}
