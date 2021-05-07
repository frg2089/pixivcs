using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class BookmarkDetail
    {
        [JsonPropertyName("is_bookmarked")]
        public bool IsBookmarked { get; set; }

        [JsonPropertyName("tags")]
        public BookmarkDetailTag[] Tags { get; set; }

        [JsonPropertyName("restrict")]
        public string Restrict { get; set; }
    }


}
