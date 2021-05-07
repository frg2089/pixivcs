using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class UserBookmarkTagsResult : ResultBase
    {
        [JsonPropertyName("bookmark_tags")]
        public dynamic[] BookmarkTags { get; set; }

        [JsonPropertyName("next_url")]
        public Uri NextUrl { get; set; }
    }
}
