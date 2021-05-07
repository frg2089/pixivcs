using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class Workspace
    {
        [JsonPropertyName("pc")]
        public string Pc { get; set; }

        [JsonPropertyName("monitor")]
        public string Monitor { get; set; }

        [JsonPropertyName("tool")]
        public string Tool { get; set; }

        [JsonPropertyName("scanner")]
        public string Scanner { get; set; }

        [JsonPropertyName("tablet")]
        public string Tablet { get; set; }

        [JsonPropertyName("mouse")]
        public string Mouse { get; set; }

        [JsonPropertyName("printer")]
        public string Printer { get; set; }

        [JsonPropertyName("desktop")]
        public string Desktop { get; set; }

        [JsonPropertyName("music")]
        public string Music { get; set; }

        [JsonPropertyName("desk")]
        public string Desk { get; set; }

        [JsonPropertyName("chair")]
        public string Chair { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("workspace_image_url")]
        public Uri WorkspaceImageUrl { get; set; }
    }


}
