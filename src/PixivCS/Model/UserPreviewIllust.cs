using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class UserPreviewIllust
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("image_urls")]
        public ImageUrls ImageUrls { get; set; }

        [JsonPropertyName("caption")]
        public string Caption { get; set; }

        [JsonPropertyName("restrict")]
        public long Restrict { get; set; }

        [JsonPropertyName("user")]
        public IllustUser User { get; set; }

        [JsonPropertyName("tags")]
        public IllustTag[] Tags { get; set; }

        [JsonPropertyName("tools")]
        public string[] Tools { get; set; }

        [JsonPropertyName("create_date")]
        public string CreateDate { get; set; }

        [JsonPropertyName("page_count")]
        public long PageCount { get; set; }

        [JsonPropertyName("width")]
        public long Width { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("sanity_level")]
        public long SanityLevel { get; set; }

        [JsonPropertyName("x_restrict")]
        public long XRestrict { get; set; }

        [JsonPropertyName("series")]
        public Series Series { get; set; }

        [JsonPropertyName("meta_single_page")]
        public MetaSinglePage MetaSinglePage { get; set; }

        [JsonPropertyName("meta_pages")]
        public MetaPage[] MetaPages { get; set; }

        [JsonPropertyName("total_view")]
        public long TotalView { get; set; }

        [JsonPropertyName("total_bookmarks")]
        public long TotalBookmarks { get; set; }

        [JsonPropertyName("is_bookmarked")]
        public bool IsBookmarked { get; set; }

        [JsonPropertyName("visible")]
        public bool Visible { get; set; }

        [JsonPropertyName("is_muted")]
        public bool IsMuted { get; set; }

        [JsonPropertyName("total_comments")]
        public long? TotalComments { get; set; }
    }


}
