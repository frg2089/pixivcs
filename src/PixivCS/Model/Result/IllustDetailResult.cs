using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class IllustDetailResult : ResultBase
    {
        [JsonPropertyName("illust")]
        public UserPreviewIllust Illust { get; set; }
    }
}
