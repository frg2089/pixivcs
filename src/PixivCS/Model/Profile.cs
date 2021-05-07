using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class Profile
    {
        [JsonPropertyName("webpage")]
        public dynamic Webpage { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("birth")]
        public string Birth { get; set; }

        [JsonPropertyName("birth_day")]
        public string BirthDay { get; set; }

        [JsonPropertyName("birth_year")]
        public long BirthYear { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("address_id")]
        public long AddressId { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("job")]
        public string Job { get; set; }

        [JsonPropertyName("job_id")]
        public long JobId { get; set; }

        [JsonPropertyName("total_follow_users")]
        public long TotalFollowUsers { get; set; }

        [JsonPropertyName("total_mypixiv_users")]
        public long TotalMypixivUsers { get; set; }

        [JsonPropertyName("total_illusts")]
        public long TotalIllusts { get; set; }

        [JsonPropertyName("total_manga")]
        public long TotalManga { get; set; }

        [JsonPropertyName("total_novels")]
        public long TotalNovels { get; set; }

        [JsonPropertyName("total_illust_bookmarks_public")]
        public long TotalIllustBookmarksPublic { get; set; }

        [JsonPropertyName("total_illust_series")]
        public long TotalIllustSeries { get; set; }

        [JsonPropertyName("total_novel_series")]
        public long TotalNovelSeries { get; set; }

        [JsonPropertyName("background_image_url")]
        public Uri BackgroundImageUrl { get; set; }

        [JsonPropertyName("twitter_account")]
        public string TwitterAccount { get; set; }

        [JsonPropertyName("twitter_url")]
        public Uri TwitterUrl { get; set; }

        [JsonPropertyName("pawoo_url")]
        public Uri PawooUrl { get; set; }

        [JsonPropertyName("is_premium")]
        public bool IsPremium { get; set; }

        [JsonPropertyName("is_using_custom_profile_image")]
        public bool IsUsingCustomProfileImage { get; set; }
    }


}
