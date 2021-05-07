using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class Series
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }


}
