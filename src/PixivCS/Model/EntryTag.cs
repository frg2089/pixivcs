using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class EntryTag
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
