using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

using PixivCS.API;
using PixivCS.Utils;

namespace PixivCS
{
    public class PixivApp
    {
        private readonly PixivAuthorizeAPI _authApi;
        private readonly PixivAPIClient _client;
        public PixivApp(PixivAPIClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));

            _authApi = new PixivAuthorizeAPI(_client);
        }


        /// <summary>
        /// 作品收藏详情
        /// </summary>
        /// <param name="IllustID"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.IllustBookmarkDetailResult> GetIllustBookmarkDetailAsync(string IllustID, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v2/illust/bookmark/detail";
            var query = new List<(string, string)>
            {
                ("illust_id", IllustID)
            };
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.IllustBookmarkDetailResult>();
        }

        /// <summary>
        /// 作品评论
        /// </summary>
        /// <param name="IllustID"></param>
        /// <param name="Offset"></param>
        /// <param name="IncludeTotalComments">决定是否在返回的JSON中包含总评论数</param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.IllustCommentsResult> GetIllustCommentsAsync(string IllustID, string Offset = null,
            bool? IncludeTotalComments = null, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/illust/comments";
            var query = new List<(string, string)>
            {
                ("illust_id", IllustID)
            };
            if (!string.IsNullOrEmpty(Offset))
                query.Add(("offset", Offset));
            if (IncludeTotalComments != null)
            {
                query.Add(("include_total_comments",
IncludeTotalComments.Value ? "true" : "false"));
            }

            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.IllustCommentsResult>();
        }

        /// <summary>
        /// 作品详情
        /// </summary>
        /// <param name="IllustID"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.IllustDetailResult> GetIllustDetailAsync(string IllustID, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/illust/detail";
            var query = new List<(string, string)>
            {
                ("illust_id", IllustID)
            };
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.IllustDetailResult>();
        }

        /// <summary>
        /// 关注者的新作品
        /// </summary>
        /// <param name="Restrict"></param>
        /// <param name="Offset"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.UserIllustsResult> GetIllustFollowAsync(string Restrict = "public", string Offset = null,
            bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v2/illust/follow";
            var query = new List<(string, string)>
            {
                ("restrict", Restrict)
            };
            if (!string.IsNullOrEmpty(Offset))
                query.Add(("offset", Offset));
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.UserIllustsResult>();
        }

        /// <summary>
        /// 作品排行
        /// </summary>
        /// <param name="Mode">mode: [day, week, month, day_male, day_female, week_original, week_rookie, day_manga]</param>
        /// <param name="Filter"></param>
        /// <param name="Date">date: yyyy-mm-dd</param>
        /// <param name="Offset"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.UserIllustsResult> GetIllustRankingAsync(string Mode = "day", string Filter = "for_android",
            string Date = null, string Offset = null, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/illust/ranking";
            var query = new List<(string, string)>
            {
                ("mode", Mode),
                ("filter", Filter)
            };
            if (!string.IsNullOrEmpty(Date))
                query.Add(("date", Date));
            if (!string.IsNullOrEmpty(Offset))
                query.Add(("offset", Offset));
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.UserIllustsResult>();
        }

        /// <summary>
        /// 首页推荐
        /// </summary>
        /// <param name="ContentType">content_type: [illust, manga]</param>
        /// <param name="IncludeRankingLabel"></param>
        /// <param name="Filter"></param>
        /// <param name="MaxBookmarkIDForRecommended"></param>
        /// <param name="MinBookmarkIDForRecentIllust"></param>
        /// <param name="Offset"></param>
        /// <param name="IncludeRankingIllusts"></param>
        /// <param name="BookmarkIllustIDs"></param>
        /// <param name="IncludePrivacyPolicy"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.IllustRecommendedResult> GetIllustRecommendedAsync(string ContentType = "illust",
            bool IncludeRankingLabel = true, string Filter = "for_ios",
            string MaxBookmarkIDForRecommended = null,
            string MinBookmarkIDForRecentIllust = null, string Offset = null,
            bool? IncludeRankingIllusts = null, List<string> BookmarkIllustIDs = null,
            string IncludePrivacyPolicy = null, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = RequireAuth ? "https://app-api.pixiv.net/v1/illust/recommended" :
                "https://app-api.pixiv.net/v1/illust/recommended-nologin";
            var query = new List<(string, string)>
            {
                ("content_type", ContentType),
                ("include_ranking_label", IncludeRankingLabel ? "true" : "false"),
                ("filter", Filter)
            };
            if (!string.IsNullOrEmpty(MaxBookmarkIDForRecommended))
                query.Add(("max_bookmark_id_for_recommend", MaxBookmarkIDForRecommended));
            if (!string.IsNullOrEmpty(MinBookmarkIDForRecentIllust))
                query.Add(("min_bookmark_id_for_recent_illust", MinBookmarkIDForRecentIllust));
            if (!string.IsNullOrEmpty(Offset))
                query.Add(("offset", Offset));
            if (IncludeRankingIllusts != null)
                query.Add(("include_ranking_illusts", IncludeRankingIllusts.Value ? "true" : "false"));
            var ids = "";
            if (BookmarkIllustIDs != null)
            {
                foreach (var i in BookmarkIllustIDs)
                    ids += (i + ",");
            }

            if (ids != "")
            {
                ids.TrimEnd(',');
                query.Add(("bookmark_illust_ids", ids));
            }
            if (!string.IsNullOrEmpty(IncludePrivacyPolicy))
                query.Add(("include_privacy_policy", IncludePrivacyPolicy));
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.IllustRecommendedResult>();
        }

        /// <summary>
        /// 相关作品
        /// </summary>
        /// <param name="IllustID"></param>
        /// <param name="Filter"></param>
        /// <param name="SeedIllustIDs"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.UserIllustsResult> GetIllustRelatedAsync(string IllustID, string Filter = "for_android",
            List<string> SeedIllustIDs = null, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v2/illust/related";
            var query = new List<(string, string)>
            {
                ("illust_id", IllustID),
                ("filter", Filter)
            };
            if (SeedIllustIDs != null)
            {
                foreach (var i in SeedIllustIDs)
                    query.Add(("seed_illust_ids[]", i));
            }
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.UserIllustsResult>();
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="Word"></param>
        /// <param name="SearchTarget">
        /// search_target - 搜索类型<br/>
        /// <c>partial_match_for_tags</c>  - 标签部分一致<br/>
        /// <c>exact_match_for_tags</c>    - 标签完全一致<br/>
        /// <c>title_and_caption</c>       - 标题说明文<br/>
        /// </param>
        /// <param name="Sort">sort: [date_desc, date_asc]</param>
        /// <param name="Duration">duration: [within_last_day, within_last_week, within_last_month]</param>
        /// <param name="Filter"></param>
        /// <param name="Offset"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.SearchIllustResult> GetSearchIllustAsync(string Word, string SearchTarget = "partial_match_for_tags",
            string Sort = "date_desc", string Duration = null, string Filter = "for_ios", string Offset = null,
            bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/search/illust";
            var query = new List<(string, string)>
            {
                ("word", Word),
                ("search_target", SearchTarget),
                ("sort", Sort),
                ("filter", Filter)
            };
            if (!string.IsNullOrEmpty(Duration))
                query.Add(("duration", Duration));
            if (!string.IsNullOrEmpty(Offset))
                query.Add(("offset", Offset));
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.SearchIllustResult>();
        }

        /// <summary>
        /// 特辑详情
        /// </summary>
        /// <remarks>
        /// 伪装成Chrome
        /// </remarks>
        /// <param name="ShowcaseID"></param>
        /// <returns></returns>
        public async Task<Model.Result.ShowcaseArticleResult> GetShowcaseArticleAsync(string ShowcaseID)
        {
            var url = "https://www.pixiv.net/ajax/showcase/article";
            var headers = new Dictionary<string, string>
            {
                { "User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.132 Safari/537.36" },
                { "Referer", "https://www.pixiv.net" }
            };
            var query = new List<(string, string)>()
            {
                ("article_id", ShowcaseID)
            };
            var res = await RequestCall("GET", url, headers, Query: query, RequireAuth: false);
            return await res.GetResult<Model.Result.ShowcaseArticleResult>();
        }

        /// <summary>
        /// 趋势标签
        /// </summary>
        /// <param name="Filter"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.TrendingTagsIllustResult> GetTrendingTagsIllustAsync(string Filter = "for_android", bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/trending-tags/illust";
            var query = new List<(string, string)>
            {
                ("filter", Filter)
            };
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.TrendingTagsIllustResult>();
        }

        /// <summary>
        /// Ugoira信息
        /// </summary>
        /// <param name="IllustID"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.UgoiraMetadataResult> GetUgoiraMetadataAsync(string IllustID, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/ugoira/metadata";
            var query = new List<(string, string)>
            {
                ("illust_id", IllustID)
            };
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.UgoiraMetadataResult>();
        }

        /// <summary>
        /// 用户收藏
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="Restrict"></param>
        /// <param name="Filter"></param>
        /// <param name="MaxBookmarkID"></param>
        /// <param name="Tag"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.UserIllustsResult> GetUserBookmarksIllustAsync(string UserID, string Restrict = "public",
            string Filter = "for_ios", string MaxBookmarkID = null, string Tag = null,
            bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/user/bookmarks/illust";
            var query = new List<(string, string)>
            {
                ("user_id", UserID),
                ("restrict", Restrict),
                ("filter", Filter)
            };
            if (!string.IsNullOrEmpty(MaxBookmarkID))
                query.Add(("max_bookmark_id", MaxBookmarkID));
            if (!string.IsNullOrEmpty(Tag))
                query.Add(("tag", Tag));
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.UserIllustsResult>();
        }

        /// <summary>
        /// 用户收藏标签列表
        /// </summary>
        /// <param name="Restrict"></param>
        /// <param name="Offset"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.UserBookmarkTagsResult> GetUserBookmarkTagsIllustAsync(string Restrict = "public", string Offset = null,
            bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/user/bookmark-tags/illust";
            var query = new List<(string, string)>
            {
                ("restrict", Restrict)
            };
            if (!string.IsNullOrEmpty(Offset))
                query.Add(("offset", Offset));
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.UserBookmarkTagsResult>();
        }

        /// <summary>
        /// 用户详情
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="Filter"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.UserDetailResult> GetUserDetailAsync(string UserID, string Filter = "for_android",
            bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/user/detail";
            var query = new List<(string, string)>
            {
                ("user_id", UserID),
                ("filter", Filter)
            };
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.UserDetailResult>();
        }

        /// <summary>
        /// Followers用户列表
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="Restrict"></param>
        /// <param name="Offset"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.UserFollowListResult> GetUserFollowerAsync(string UserID, string Restrict = "public",
            string Offset = null, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/user/follower";
            var query = new List<(string, string)>
            {
                ("user_id", UserID),
                ("restrict", Restrict)
            };
            if (!string.IsNullOrEmpty(Offset))
                query.Add(("offset", Offset));
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.UserFollowListResult>();
        }

        /// <summary>
        /// Following用户列表
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="Restrict"></param>
        /// <param name="Offset"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.UserFollowListResult> GetUserFollowingAsync(string UserID, string Restrict = "public",
            string Offset = null, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/user/following";
            var query = new List<(string, string)>
            {
                ("user_id", UserID),
                ("restrict", Restrict)
            };
            if (!string.IsNullOrEmpty(Offset))
                query.Add(("offset", Offset));
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.UserFollowListResult>();
        }

        /// <summary>
        /// 用户作品
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="IllustType"></param>
        /// <param name="Filter"></param>
        /// <param name="Offset"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.UserIllustsResult> GetUserIllustsAsync(string UserID, string IllustType = "illust",
            string Filter = "for_ios", string Offset = null, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/user/illusts";
            var query = new List<(string, string)>
            {
                ("user_id", UserID),
                ("filter", Filter)
            };
            if (!string.IsNullOrEmpty(IllustType))
                query.Add(("type", IllustType));
            if (!string.IsNullOrEmpty(Offset))
                query.Add(("offset", Offset));
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.UserIllustsResult>();
        }

        /// <summary>
        /// 黑名单用户
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="Filter"></param>
        /// <param name="Offset"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.UserListResult> GetUserListAsync(string UserID, string Filter = "for_android",
            string Offset = null, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v2/user/list";
            var query = new List<(string, string)>
            {
                ("user_id", UserID),
                ("filter", Filter)
            };
            if (!string.IsNullOrEmpty(Offset))
                query.Add(("offset", Offset));
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.UserListResult>();
        }

        /// <summary>
        /// 好P友
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="Offset"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.UserFollowListResult> GetUserMyPixivAsync(string UserID, string Offset = null,
            bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/user/mypixiv";
            var query = new List<(string, string)>
            {
                ("user_id", UserID)
            };
            if (!string.IsNullOrEmpty(Offset))
                query.Add(("offset", Offset));
            var res = await RequestCall("GET", url, Query: query, RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.UserFollowListResult>();
        }

        /// <summary>
        /// 新增收藏
        /// </summary>
        /// <param name="IllustID"></param>
        /// <param name="Restrict"></param>
        /// <param name="Tags"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task PostIllustBookmarkAddAsync(string IllustID, string Restrict = "public",
            List<string> Tags = null, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v2/illust/bookmark/add";
            var data = new Dictionary<string, string>
            {
                { "illust_id", IllustID },
                { "restrict", Restrict }
            };
            var tags = "";
            if (Tags != null)
            {
                foreach (var i in Tags)
                    tags += (i + " ");
            }

            tags = tags.Trim();
            if (tags != "")
                data.Add("tags", HttpUtility.UrlEncode(tags));
            await RequestCall("POST", url, Body: new FormUrlEncodedContent(data),
                RequireAuth: RequireAuth);
        }

        /// <summary>
        /// 删除收藏
        /// </summary>
        /// <param name="IllustID"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task PostIllustBookmarkDeleteAsync(string IllustID, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/illust/bookmark/delete";
            var data = new Dictionary<string, string>
            {
                { "illust_id", IllustID }
            };
            await RequestCall("POST", url, Body: new FormUrlEncodedContent(data),
                RequireAuth: RequireAuth);
        }

        /// <summary>
        /// 发表评论
        /// </summary>
        /// <param name="IllustID"></param>
        /// <param name="Comment"></param>
        /// <param name="ParentCommentID"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task<Model.Result.IllustCommentAddResult> PostIllustCommentAddAsync(string IllustID, string Comment,
            string ParentCommentID = null, bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/illust/comment/add";
            var data = new Dictionary<string, string>
            {
                { "illust_id", IllustID },
                { "comment", Comment }
            };
            if (!string.IsNullOrWhiteSpace(ParentCommentID))
                data.Add("parent_comment_id", ParentCommentID);
            var res = await RequestCall("POST", url, Body: new FormUrlEncodedContent(data),
                RequireAuth: RequireAuth);
            return await res.GetResult<Model.Result.IllustCommentAddResult>();
        }

        /// <summary>
        /// 关注用户
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="Restrict"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task PostUserFollowAddAsync(string UserID, string Restrict = "public",
            bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/user/follow/add";
            var data = new Dictionary<string, string>
            {
                { "user_id", UserID },
                { "restrict", Restrict }
            };
            await RequestCall("POST", url, Body: new FormUrlEncodedContent(data),
                RequireAuth: RequireAuth);
        }

        /// <summary>
        /// 取关用户
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="Restrict"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public async Task PostUserFollowDeleteAsync(string UserID, string Restrict = "public",
            bool RequireAuth = true)
        {
            await AuthCheck(RequireAuth);
            var url = "https://app-api.pixiv.net/v1/user/follow/delete";
            var data = new Dictionary<string, string>
            {
                { "user_id", UserID },
                { "restrict", Restrict }
            };
            await RequestCall("POST", url, Body: new FormUrlEncodedContent(data),
                RequireAuth: RequireAuth);
        }

        /// <summary>
        /// 发送请求
        /// </summary>
        /// <param name="Method"></param>
        /// <param name="Url"></param>
        /// <param name="Headers"></param>
        /// <param name="Query"></param>
        /// <param name="Body"></param>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        public Task<HttpResponseMessage> RequestCall(
            string Method,
            string Url,
            Dictionary<string, string> Headers = null,
            List<(string, string)> Query = null,
            HttpContent Body = null, bool RequireAuth = true)
        {
            var headers = Headers ?? new Dictionary<string, string>();
            if (!(headers.ContainsKey("User-Agent") || headers.ContainsKey("user-agent")))
            {
                headers.Add("App-OS", "Android");
                headers.Add("App-OS-Version", "Android 6.0");
                headers.Add("App-Version", "5.0.166");
                headers.Add("User-Agent", "PixivAndroidApp/5.0.155 (Android 6.0; Pixel C)");
            }
            if (RequireAuth)
                headers.Add("Authorization", string.Format("Bearer {0}", _authApi.AccessToken));
            return RequestCall(Method, Url, headers, Query, Body);
        }

        /// <summary>
        /// 用户授权信息验证
        /// </summary>
        /// <param name="RequireAuth"></param>
        /// <returns></returns>
        protected virtual async Task AuthCheck(bool RequireAuth)
        {
            if ((DateTime.UtcNow - _authApi.AccessTime).TotalSeconds >= _authApi.ExpireTime && RequireAuth)
                await _authApi.AuthByRefreshTokenAsync(_authApi.RefreshToken);
        }
    }
}
