using System;
using System.Text.Json.Serialization;

namespace PixivCS.Model.Result
{
    public class UserFollowListResult : ResultBase
    {
        [JsonPropertyName("user_previews")]
        public UserPreview[] UserPreviews { get; set; }

        [JsonPropertyName("next_url")]
        public Uri NextUrl { get; set; }
    }
}
