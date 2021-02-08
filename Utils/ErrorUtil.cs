using System.Net.Http;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace PixivCS.Utils
{
    internal static class ErrorUtil
    {
        public static void ResultValidator(this Objects.ErrorResult error)
        {
            if (!error.HasError && error.Error is null)// 不存在错误
                return;
            var option = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };


            if (error.Error is string e)
            {
                Exceptions.PixivException inner = default;
                if (!(error.Errors is null))
                    inner = new Exceptions.PixivException(JsonSerializer.Serialize(error.Errors, option));

                switch (e)
                {
                    case "invalid_grant":
                        throw new Exceptions.PixivAuthException(e, inner);
                    default:
                        throw new Exceptions.PixivException(e, inner);
                }
            }
            else
            {
                if (!(error.Error is null))
                    throw new Exceptions.PixivException(JsonSerializer.Serialize(error.Error, option));
            }
        }
        public static void HttpStatusValidator(this HttpResponseMessage response)
        {
            int status = (int)response.StatusCode;
            if (status != 200 && status != 301 && status != 302)
                throw new HttpRequestException($"[ERROR] Http:{status} {response.StatusCode}");
        }
    }
}
