using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class Entry
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("pure_title")]
        public string PureTitle { get; set; }

        [JsonPropertyName("catchphrase")]
        public string Catchphrase { get; set; }

        [JsonPropertyName("header")]
        public string Header { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        [JsonPropertyName("footer")]
        public string Footer { get; set; }

        [JsonPropertyName("sidebar")]
        public string Sidebar { get; set; }

        [JsonPropertyName("publish_date")]
        public long PublishDate { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("pixivision_category_slug")]
        public string PixivisionCategorySlug { get; set; }

        [JsonPropertyName("pixivision_category")]
        public PixivisionCategory PixivisionCategory { get; set; }

        [JsonPropertyName("pixivision_subcategory_slug")]
        public string PixivisionSubcategorySlug { get; set; }

        [JsonPropertyName("pixivision_subcategory")]
        public PixivisionSubcategory PixivisionSubcategory { get; set; }

        [JsonPropertyName("tags")]
        public EntryTag[] Tags { get; set; }

        [JsonPropertyName("article_url")]
        public Uri ArticleUrl { get; set; }

        [JsonPropertyName("intro")]
        public string Intro { get; set; }

        [JsonPropertyName("facebook_count")]
        public string FacebookCount { get; set; }

        [JsonPropertyName("twitter_count")]
        public string TwitterCount { get; set; }
    }
}
