using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using PixivCS.Exceptions;
using PixivCS.Utils;


namespace PixivCS.API
{
    /// <summary>
    /// Pixiv 登录验证API
    /// </summary>
    public class PixivAuthorizeAPI
    {
        internal string _codeVerify;

        private readonly PixivAPIClient _client;

        public PixivAuthorizeAPI(PixivAPIClient client)
                    => _client = client ?? throw new ArgumentNullException(nameof(client));

        public DateTime AccessTime { get; internal set; }

        public string AccessToken { get; internal set; }

        public long ExpireTime { get; internal set; }

        public string RefreshToken { get; internal set; }

        public string UserID { get; internal set; }

        // 写成虚的 这样可以让其他开发者override
        internal virtual string ClientID { get; set; } = "MOBrBDS8blbauoSck0ZfDbtuzpyT";
        internal virtual string ClientSecret { get; set; } = "lsACyCD94FhDUtGTXi3QzcFE2uU1hqtDaKeqrdwj";
        internal virtual string HashSecret { get; set; } = "28c1fdd170a5204386cb1313c7077b34f83e4aaf4aa829ce78c231e05b0bae2c";

        /// <summary>
        ///  使用code完成登录
        /// </summary>
        /// <param name="code">使用WebView登录后返回的code</param>
        /// <returns></returns>
        public virtual async Task<Model.Result.AuthResult> AuthByCodeAsync(string code)
        {
            AccessTime = DateTime.UtcNow;
            var time = AccessTime.ToString("yyyy-MM-ddTHH:mm:ss+00:00");
            var headers = new Dictionary<string, string>
            {
                { "X-Client-Time", time},
                { "X-Client-Hash", MD5Util.MD5Hash(time + HashSecret)},
                { "User-Agent", "PixivAndroidApp/5.0.155 (Android 6.0; Pixel C)"},
                { "App-OS", "Android"},
                { "App-OS-Version", "Android 6.0"},
                { "App-Version", "5.0.166"},
                { "Host", "oauth.secure.pixiv.net"},
                { "Content-Type", "application/x-www-form-urlencoded"},
                { "Accept-Language","zh-CN"}
            };
            var body = new Dictionary<string, string>
            {
                { "client_id", ClientID },
                { "client_secret", ClientSecret },
                { "code", code },
                { "code_verifier", _codeVerify },
                { "redirect_uri", "https://app-api.pixiv.net/web/v1/users/auth/pixiv/callback" },
                { "grant_type", "authorization_code" },
                { "include_policy", "true" }
            };
            return await AuthAsync(headers, body);
        }

        /// <summary>
        /// RefreshToken登录
        /// </summary>
        /// <remarks>
        /// 通过RefreshToken登录账户<br/>
        /// 此方法将会调用<see cref="AuthAsync(Dictionary{string, string}, Dictionary{string, string})"/>
        /// </remarks>
        /// <exception cref="PixivException">尚不明确的其他错误</exception>
        /// <exception cref="PixivAuthException">用户名密码错误</exception>
        /// <exception cref="HttpRequestException">Http连接失败()</exception>
        public virtual async Task<Model.Result.AuthResult> AuthByRefreshTokenAsync(string RefreshToken)
        {
            AccessTime = DateTime.UtcNow;
            var headers = new Dictionary<string, string>
            {
                { "User-Agent", "PixivAndroidApp/5.0.64 (Android 6.0)" }
            };
            var data = new Dictionary<string, string>
            {
                { "get_secure_url", "1" },
                { "client_id", ClientID },
                { "client_secret", ClientSecret },
                { "grant_type", "refresh_token" },
                { "refresh_token", RefreshToken }
            };
            return await AuthAsync(headers, data);
        }

        /// <summary>
        /// 生成带有Code Challenge的WebView登录链接
        /// </summary>
        /// <returns>带有Code Challenge的WebView登录链接</returns>
        public virtual Uri GenerateWebViewUri()
        {
            _codeVerify = OAuthUtil.GenerateCodeVerify();
            var codeChallenge = OAuthUtil.GenerateCodeChallenge(_codeVerify);
            var uri = "https://app-api.pixiv.net/web/v1/login?code_challenge=" + codeChallenge + "&code_challenge_method=S256&client=pixiv-android";
            return new Uri(uri);
        }

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <exception cref="PixivAuthException">尚未登录</exception>
        public void RequireAuth()
        {
            if (AccessToken == null)
                throw new PixivAuthException("Authentication required!");
        }

        /// <summary>
        /// 登录逻辑
        /// </summary>
        /// <remarks>
        /// 负责发送请求以及验证返回内容的方法<br/>
        /// </remarks>
        /// <exception cref="HttpRequestException">Http连接失败</exception>
        /// <exception cref="PixivException">尚不明确的其他错误</exception>
        protected virtual async ValueTask<Model.Result.AuthResult> AuthAsync(
            Dictionary<string, string> headers,
            Dictionary<string, string> data)
        {
            const string url = "https://oauth.secure.pixiv.net/auth/token";
            var res = await _client.RequestCall(
                "POST",
                url,
                headers,
                Body: new FormUrlEncodedContent(data)
                ).ConfigureAwait(false);
            var resJSON = await res.GetResult<Model.Result.AuthResult>()
                                   .ConfigureAwait(false);
            //AccessToken = resJSON.Response.AccessToken;
            //UserID = resJSON.Response.User.Id;
            //RefreshToken = resJSON.Response.RefreshToken;
            //ExpireTime = resJSON.Response.ExpiresIn;
            return resJSON;
        }
    }
}
