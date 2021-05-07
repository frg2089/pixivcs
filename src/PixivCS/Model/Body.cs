using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class Body
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("lang")]
        public string Lang { get; set; }

        [JsonPropertyName("entry")]
        public Entry Entry { get; set; }

        [JsonPropertyName("tags")]
        public EntryTag[] Tags { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        public Uri ThumbnailUrl { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("publishDate")]
        public long PublishDate { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("subCategory")]
        public string SubCategory { get; set; }

        [JsonPropertyName("subCategoryLabel")]
        public string SubCategoryLabel { get; set; }

        [JsonPropertyName("subCategoryIntroduction")]
        public string SubCategoryIntroduction { get; set; }

        [JsonPropertyName("introduction")]
        public string Introduction { get; set; }

        [JsonPropertyName("footer")]
        public string Footer { get; set; }

        [JsonPropertyName("illusts")]
        public BodyIllust[] Illusts { get; set; }

        [JsonPropertyName("relatedArticles")]
        public RelatedArticle[] RelatedArticles { get; set; }

        [JsonPropertyName("followingUserIds")]
        public dynamic[] FollowingUserIds { get; set; }

        [JsonPropertyName("isOnlyOneUser")]
        public bool IsOnlyOneUser { get; set; }
    }
}
