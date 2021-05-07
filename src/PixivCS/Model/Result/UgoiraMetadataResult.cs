using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class UgoiraMetadataResult : ResultBase
    {
        [JsonPropertyName("ugoira_metadata")]
        public UgoiraMetadataClass UgoiraMetadataUgoiraMetadata { get; set; }
    }
}
