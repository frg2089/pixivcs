using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class TrendingTagsIllustResult : ResultBase
    {
        [JsonPropertyName("trend_tags")]
        public TrendTag[] TrendTags { get; set; }
    }
}
