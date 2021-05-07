using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class RelatedArticle
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("ja")]
        public PrivacyPolicy Ja { get; set; }

        [JsonPropertyName("en")]
        public PrivacyPolicy En { get; set; }

        [JsonPropertyName("zh")]
        public PrivacyPolicy Zh { get; set; }

        [JsonPropertyName("zh_tw")]
        public PrivacyPolicy ZhTw { get; set; }

        [JsonPropertyName("publish_date")]
        public long PublishDate { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("pixivision_category_slug")]
        public string PixivisionCategorySlug { get; set; }

        [JsonPropertyName("pixivision_subcategory_slug")]
        public string PixivisionSubcategorySlug { get; set; }

        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonPropertyName("thumbnail_illust_id")]
        public string ThumbnailIllustId { get; set; }

        [JsonPropertyName("has_body")]
        public string HasBody { get; set; }

        [JsonPropertyName("is_pr")]
        public string IsPr { get; set; }

        [JsonPropertyName("pr_client_name")]
        public string PrClientName { get; set; }

        [JsonPropertyName("edit_status")]
        public string EditStatus { get; set; }

        [JsonPropertyName("translation_status")]
        public string TranslationStatus { get; set; }

        [JsonPropertyName("is_sample")]
        public string IsSample { get; set; }

        [JsonPropertyName("illusts")]
        public dynamic[] Illusts { get; set; }

        [JsonPropertyName("novel_ids")]
        public dynamic[] NovelIds { get; set; }

        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        [JsonPropertyName("facebook_count")]
        public string FacebookCount { get; set; }

        [JsonPropertyName("tweet_count")]
        public string TweetCount { get; set; }

        [JsonPropertyName("tweet_max_count")]
        public string TweetMaxCount { get; set; }

        [JsonPropertyName("tags")]
        public dynamic[] Tags { get; set; }

        [JsonPropertyName("tag_ids")]
        public dynamic TagIds { get; set; }

        [JsonPropertyName("numbered_tags")]
        public dynamic[] NumberedTags { get; set; }

        [JsonPropertyName("main_abtest_pattern_id")]
        public string MainAbtestPatternId { get; set; }

        [JsonPropertyName("advertisement_id")]
        public string AdvertisementId { get; set; }
    }
}
