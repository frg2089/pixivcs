using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class IllustCommentsResult : ResultBase
    {
        [JsonPropertyName("total_comments")]
        public long TotalComments { get; set; }

        [JsonPropertyName("comments")]
        public Comment[] Comments { get; set; }

        [JsonPropertyName("next_url")]
        public Uri NextUrl { get; set; }
    }
}
