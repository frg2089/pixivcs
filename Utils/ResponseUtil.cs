using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PixivCS.Utils
{
    public static class ResponseUtil
    {
        /// <summary>
        /// 以字符串形式拿回Response
        /// </summary>
        public static async Task<string> GetResponseString(HttpResponseMessage Response)
            => await Response.Content.ReadAsStringAsync();
        internal static Task<string> GetResponseStringEx(this HttpResponseMessage Response)
            => GetResponseString(Response);

        /// <summary>
        /// 以流形式拿回Response
        /// </summary>
        public static async Task<Stream> GetResponseStream(HttpResponseMessage Response)
            => await Response.Content.ReadAsStreamAsync();
        internal static Task<Stream> GetResponseStreamEx(this HttpResponseMessage Response)
            => GetResponseStream(Response);
    }
}
