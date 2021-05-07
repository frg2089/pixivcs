using System.Text.Json.Serialization;

namespace PixivCS.Model
{
    public class ResponseUser
    {
        [JsonPropertyName("profile_image_urls")]
        public ProfileImageUrls ProfileImageUrls { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("account")]
        public string Account { get; set; }

        [JsonPropertyName("mail_address")]
        public string MailAddress { get; set; }

        [JsonPropertyName("is_premium")]
        public bool IsPremium { get; set; }

        [JsonPropertyName("x_restrict")]
        public long XRestrict { get; set; }

        [JsonPropertyName("is_mail_authorized")]
        public bool IsMailAuthorized { get; set; }
    }


}
