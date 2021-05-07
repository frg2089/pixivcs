using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class Frame
    {
        [JsonPropertyName("file")]
        public string File { get; set; }

        [JsonPropertyName("delay")]
        public long Delay { get; set; }
    }
}
