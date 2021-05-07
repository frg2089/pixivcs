using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class Comment
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("comment")]
        public string CommentComment { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("user")]
        public IllustUser User { get; set; }

        [JsonPropertyName("has_replies")]
        public bool? HasReplies { get; set; }

        [JsonPropertyName("parent_comment")]
        public Comment ParentComment { get; set; }
    }


}
