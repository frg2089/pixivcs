using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class BodyIllust
    {
        [JsonPropertyName("spotlight_article_id")]
        public long SpotlightArticleId { get; set; }

        [JsonPropertyName("illust_id")]
        public long IllustId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("illust_user_id")]
        public string IllustUserId { get; set; }

        [JsonPropertyName("illust_title")]
        public string IllustTitle { get; set; }

        [JsonPropertyName("illust_ext")]
        public string IllustExt { get; set; }

        [JsonPropertyName("illust_width")]
        public string IllustWidth { get; set; }

        [JsonPropertyName("illust_height")]
        public string IllustHeight { get; set; }

        [JsonPropertyName("illust_restrict")]
        public string IllustRestrict { get; set; }

        [JsonPropertyName("illust_x_restrict")]
        public string IllustXRestrict { get; set; }

        [JsonPropertyName("illust_create_date")]
        public string IllustCreateDate { get; set; }

        [JsonPropertyName("illust_upload_date")]
        public string IllustUploadDate { get; set; }

        [JsonPropertyName("illust_server_id")]
        public string IllustServerId { get; set; }

        [JsonPropertyName("illust_hash")]
        public string IllustHash { get; set; }

        [JsonPropertyName("illust_type")]
        public string IllustType { get; set; }

        [JsonPropertyName("illust_sanity_level")]
        public long IllustSanityLevel { get; set; }

        [JsonPropertyName("illust_book_style")]
        public string IllustBookStyle { get; set; }

        [JsonPropertyName("illust_page_count")]
        public string IllustPageCount { get; set; }

        [JsonPropertyName("illust_custom_thumbnail_upload_datetime")]
        public dynamic IllustCustomThumbnailUploadDatetime { get; set; }

        [JsonPropertyName("illust_comment")]
        public string IllustComment { get; set; }

        [JsonPropertyName("user_account")]
        public string UserAccount { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        [JsonPropertyName("user_comment")]
        public string UserComment { get; set; }

        [JsonPropertyName("url")]
        public Url Url { get; set; }

        [JsonPropertyName("ugoira_meta")]
        public dynamic UgoiraMeta { get; set; }

        [JsonPropertyName("user_icon")]
        public Uri UserIcon { get; set; }
    }
}
