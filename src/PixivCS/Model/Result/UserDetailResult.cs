using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class UserDetailResult : ResultBase
    {
        [JsonPropertyName("user")]
        public IllustUser User { get; set; }

        [JsonPropertyName("profile")]
        public Profile Profile { get; set; }

        [JsonPropertyName("profile_publicity")]
        public ProfilePublicity ProfilePublicity { get; set; }

        [JsonPropertyName("workspace")]
        public Workspace Workspace { get; set; }
    }
}
