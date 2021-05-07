using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class IllustTag
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("translated_name")]
        public string TranslatedName { get; set; }
    }


}
