using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class BookmarkDetailTag
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("is_registered")]
        public bool IsRegistered { get; set; }
    }


}
