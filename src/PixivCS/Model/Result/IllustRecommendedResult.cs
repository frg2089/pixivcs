using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class IllustRecommendedResult : ResultBase
    {
        [JsonPropertyName("illusts")]
        public UserPreviewIllust[] Illusts { get; set; }

        [JsonPropertyName("ranking_illusts")]
        public dynamic[] RankingIllusts { get; set; }

        [JsonPropertyName("contest_exists")]
        public bool ContestExists { get; set; }

        [JsonPropertyName("privacy_policy")]
        public PrivacyPolicy PrivacyPolicy { get; set; }

        [JsonPropertyName("next_url")]
        public Uri NextUrl { get; set; }
    }
}
