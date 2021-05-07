using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using PixivCS.Exceptions;
using PixivCS.Utils;

namespace PixivCS.API
{
    /// <summary>
    /// 客户端输出委托
    /// </summary>
    /// <param name="b">数据</param>
    /// <returns>异步函数</returns>
    public delegate Task ClientOutput(byte[] b);

    /// <summary>
    /// Pixiv客户端
    /// </summary>
    public class PixivAPIClient
    {
        private static HttpClient _client = new HttpClient();

        /// <summary>
        /// 客户端日志回调
        /// </summary>
        /// <remarks>
        /// 需要客户端实现以下ClientLog方法以输出httpclient request log
        /// </remarks>
        public ClientOutput ClientLog { get; set; }

        /// <summary>
        /// 启用实验性亚空间远航
        /// </summary>
        public bool IsExperimentalConnection { get; set; }

        /// <summary>
        /// 实验性亚空间远航目标地址地图
        /// </summary>
        public Dictionary<string, string> TargetIPMap { get; set; } = new Dictionary<string, string>()
        {
            {"oauth.secure.pixiv.net","210.140.131.199" },
            {"www.pixiv.net","210.140.131.199" },
            {"app-api.pixiv.net","210.140.131.199" }
        };

        /// <summary>
        /// 实验性亚空间远航证书序列号字典
        /// </summary>
        public Dictionary<string, string> TargetSNs { get; set; } = new Dictionary<string, string>()
        {
            {"210.140.131.199","346B03F05A00DD2FFAE58853" },
            {"210.140.92.142","2387DB20E84EFCF82492545C" }
        };

        /// <summary>
        /// 实验性亚空间远航证书字典
        /// </summary>
        public Dictionary<string, string> TargetSubjects { get; set; } = new Dictionary<string, string>()
        {
            {"210.140.131.199","CN=*.pixiv.net, O=pixiv Inc., OU=Development department, L=Shibuya-ku, S=Tokyo, C=JP" },
            {"210.140.92.142","CN=*.pximg.net, OU=Domain Control Validated" }
        };

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> TargetTPs { get; set; } = new Dictionary<string, string>()
        {
            {"210.140.131.199","07954CC4735FA33B629899E1DC2591500B090FB5" },
            {"210.140.92.142","F4A431620F42E4D10EB42621C6948E3CD5014FB0" }
        };

        /// <summary>
        /// 清除Client代理
        /// </summary>
        public static void ClearProxy()
        {
            _client = new HttpClient();
        }

        /// <summary>
        /// 为Client设置代理
        /// </summary>
        /// <param name="Proxy"></param>
        public static void SetProxy(IWebProxy Proxy)
        {
            HttpClientHandler handler = new HttpClientHandler
            {
                Proxy = Proxy
            };
            _client = new HttpClient(handler, true);
        }

        /// <summary>
        /// 发送请求
        /// </summary>
        /// <param name="Method">请求方法</param>
        /// <param name="Url">请求地址</param>
        /// <param name="Headers">请求头</param>
        /// <param name="Query">请求查询</param>
        /// <param name="Body">请求主体</param>
        /// <returns></returns>
        public virtual Task<HttpResponseMessage> RequestCall(
                    string Method,
                    string Url,
                    Dictionary<string, string> Headers = null,
                    List<(string, string)> Query = null,
                    HttpContent Body = null)
        {
            string queryUrl = Url;
            if (Query?.Count > 0)
                queryUrl += GetQueryString(Query);

            return IsExperimentalConnection && TargetIPMap.ContainsKey(new Uri(queryUrl).Host)
                ? ExperimentalConnect(Method, queryUrl, Headers, Body)
                : Connect(Method, queryUrl, Headers, Body);
        }

        /// <summary>
        /// 传统手段连接
        /// </summary>
        /// <param name="Method">连接方式</param>
        /// <param name="queryUrl">url地址</param>
        /// <param name="Headers">HTTP首部信息</param>
        /// <param name="Body">HTTP主题信息</param>
        /// <returns></returns>
        protected virtual async Task<HttpResponseMessage> Connect(
            string Method,
            string queryUrl,
            Dictionary<string, string> Headers = null,
            HttpContent Body = null)
        {
            var allowMethods = new string[] { "get", "post" };
            if (!allowMethods.Any(m => m.Equals(Method, StringComparison.OrdinalIgnoreCase)))
                throw new PixivException("Unsupported method");

            var request = new HttpRequestMessage(new HttpMethod(Method), queryUrl);
            if (Headers != null)
                foreach (var pair in Headers)
                    request.Headers.Add(pair.Key, pair.Value);

            if (Body != null)
                request.Content = Body;
            return await _client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
        }

        /// <summary>
        /// 实验性亚空间远航
        /// </summary>
        /// <param name="Method">连接方式</param>
        /// <param name="queryUrl">url地址</param>
        /// <param name="Headers">HTTP首部信息</param>
        /// <param name="Body">HTTP主题信息</param>
        /// <exception cref="KeyNotFoundException">实验性亚空间远航参数错误</exception>
        /// <returns></returns>
        protected virtual async Task<HttpResponseMessage> ExperimentalConnect(
            string Method,
            string queryUrl,
            Dictionary<string, string> Headers = null,
            HttpContent Body = null)
        {
            #region 无  底  深  坑

            var targetIP = TargetIPMap[new Uri(queryUrl).Host];
            var targetSubject = TargetSubjects[targetIP];
            var targetSN = TargetSNs[targetIP];
            var targetTP = TargetTPs[targetIP];


            using (var connection = await Utilities.CreateConnectionAsync(targetIP, (cert) =>
                cert.Subject == targetSubject && cert.SerialNumber == targetSN && cert.Thumbprint == targetTP))
            {
                var httpRequest = await Utilities.ConstructHTTPAsync(Method, queryUrl, Headers, Body);
                if (ClientLog != null)
                    await ClientLog(httpRequest);
                await connection.WriteAsync(httpRequest, 0, httpRequest.Length);
                using (var memory = new MemoryStream())
                {
                    await connection.CopyToAsync(memory);
                    memory.Position = 0;
                    var data = memory.ToArray();
                    var index = Utilities.BinaryMatch(data, Encoding.UTF8.GetBytes("\r\n\r\n")) + 4;
                    var headers = Encoding.UTF8.GetString(data, 0, index);
                    memory.Position = index;
                    byte[] result;
                    HttpStatusCode statusCode;
                    Dictionary<string, string> headersDictionary = new Dictionary<string, string>();
                    foreach (var header in headers.Split(new[] { "\r\n" }, StringSplitOptions.None))
                    {
                        if (string.IsNullOrWhiteSpace(header))
                            break;
                        if (!header.Contains(": "))
                        {
                            var status = header.Split(new[] { " " }, StringSplitOptions.None);
                            statusCode = (HttpStatusCode)Convert.ToInt32(status[1]);
                        }
                        else
                        {
                            var pair = header.Split(new[] { ": " }, StringSplitOptions.None);
                            headersDictionary.Add(pair[0], pair[1]);
                        }
                    }
                    if (headersDictionary.ContainsKey("Content-Encoding") &&
                        headersDictionary["Content-Encoding"].Contains("gzip"))
                    {
                        using (GZipStream decompressionStream = new GZipStream(memory, CompressionMode.Decompress))
                        using (var decompressedMemory = new MemoryStream())
                        {
                            await decompressionStream.CopyToAsync(decompressedMemory);
                            decompressedMemory.Position = 0;
                            result = decompressedMemory.ToArray();
                        }
                    }
                    else
                    {
                        using (var resultMemory = new MemoryStream())
                        {
                            await memory.CopyToAsync(resultMemory);
                            result = resultMemory.ToArray();
                        }
                    }
                    if (headersDictionary.ContainsKey("Transfer-Encoding") &&
                        headersDictionary["Transfer-Encoding"].Contains("chunked"))
                    {
                        //处理分块传输
                        using (MemoryStream parsedChunckedResult = new MemoryStream())
                        {
                            parsedChunckedResult.Position = 0;
                            int position = 0;
                            bool lengthOrContent = false;
                            int chunkLength = 0;
                            List<byte> lengthList = new List<byte>();
                            while (position < result.Length)
                            {
                                if (!lengthOrContent)
                                {
                                    //分块长度信息
                                    if (result[position] == '\r')
                                    {
                                        position += 2;
                                        lengthOrContent = true;
                                        var lengthArray = lengthList.ToArray();
                                        chunkLength = Convert.ToInt32(Encoding.UTF8.GetString(lengthArray), 16);
                                        lengthList.Clear();
                                    }
                                    else
                                    {
                                        lengthList.Add(result[position]);
                                        position++;
                                    }
                                }
                                else
                                {
                                    //末端
                                    if (chunkLength == 0)
                                        break;
                                    //分块内容
                                    await parsedChunckedResult.WriteAsync(result, position, chunkLength);
                                    position += chunkLength + 2;
                                    lengthOrContent = false;
                                }
                            }
                            result = parsedChunckedResult.ToArray();
                        }
                    }
                    var res = new HttpResponseMessage();
                    res.Content = new ByteArrayContent(result);
                    if (ClientLog != null)
                        await ClientLog(result);
                    foreach (var pair in headersDictionary)
                    {
                        var added = res.Headers.TryAddWithoutValidation(pair.Key, pair.Value);
                        if (!added)
                            res.Content.Headers.Add(pair.Key, pair.Value);
                    }
                    return res;
                }
            }
            #endregion
        }

        /// <summary>
        /// 用于生成Query字符串
        /// </summary>
        /// <returns></returns>
        protected static string GetQueryString(List<(string Key, string Value)> query)
            => "?" + string.Join("&", query.Select(i => $"{HttpUtility.UrlEncode(i.Key)}={HttpUtility.UrlEncode(i.Value)}"));
    }
}
