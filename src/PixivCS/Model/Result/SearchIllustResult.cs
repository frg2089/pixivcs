using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class SearchIllustResult : ResultBase
    {
        [JsonPropertyName("illusts")]
        public UserPreviewIllust[] Illusts { get; set; }

        [JsonPropertyName("next_url")]
        public Uri NextUrl { get; set; }

        [JsonPropertyName("search_span_limit")]
        public long SearchSpanLimit { get; set; }
    }
}
