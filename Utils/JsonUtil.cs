using System.Text.Json;

namespace PixivCS.Utils
{
    public static class JsonUtil
    {
        public static string ToJson<T>(this T self)
            => JsonSerializer.Serialize(self);

        public static T FromJson<T>(this string json)
            => JsonSerializer.Deserialize<T>(json);
    }
}
