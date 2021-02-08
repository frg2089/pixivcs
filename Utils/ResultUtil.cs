using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace PixivCS.Utils
{
    public static class ResultUtil
    {
        public static async ValueTask<T> GetResult<T>(Stream stream, CancellationToken cancellationToken = default)
            where T : Objects.ResultBase
        {
            var result = await JsonSerializer.DeserializeAsync<T>(stream, cancellationToken: cancellationToken);
            result.ResultValidator();
            return result;
        }

        internal static async ValueTask<T> GetResult<T>(this HttpResponseMessage response, CancellationToken cancellationToken = default)
            where T : Objects.ResultBase
        {
            response.HttpStatusValidator();
            using (var stream = await response.GetResponseStreamEx().ConfigureAwait(false))
                return await GetResult<T>(stream, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
