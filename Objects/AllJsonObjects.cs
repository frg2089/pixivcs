//此文件由app.quicktype.io生成
//我吹爆！

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PixivCS.Objects
{

    public partial class ShowcaseArticle : ResultBase
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("body")]
        public Body[] Body { get; set; }
    }

    public partial class Body
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("lang")]
        public string Lang { get; set; }

        [JsonPropertyName("entry")]
        public Entry Entry { get; set; }

        [JsonPropertyName("tags")]
        public EntryTag[] Tags { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        public Uri ThumbnailUrl { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("publishDate")]
        public long PublishDate { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("subCategory")]
        public string SubCategory { get; set; }

        [JsonPropertyName("subCategoryLabel")]
        public string SubCategoryLabel { get; set; }

        [JsonPropertyName("subCategoryIntroduction")]
        public string SubCategoryIntroduction { get; set; }

        [JsonPropertyName("introduction")]
        public string Introduction { get; set; }

        [JsonPropertyName("footer")]
        public string Footer { get; set; }

        [JsonPropertyName("illusts")]
        public BodyIllust[] Illusts { get; set; }

        [JsonPropertyName("relatedArticles")]
        public RelatedArticle[] RelatedArticles { get; set; }

        [JsonPropertyName("followingUserIds")]
        public dynamic[] FollowingUserIds { get; set; }

        [JsonPropertyName("isOnlyOneUser")]
        public bool IsOnlyOneUser { get; set; }
    }

    public partial class Entry
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("pure_title")]
        public string PureTitle { get; set; }

        [JsonPropertyName("catchphrase")]
        public string Catchphrase { get; set; }

        [JsonPropertyName("header")]
        public string Header { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        [JsonPropertyName("footer")]
        public string Footer { get; set; }

        [JsonPropertyName("sidebar")]
        public string Sidebar { get; set; }

        [JsonPropertyName("publish_date")]
        public long PublishDate { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("pixivision_category_slug")]
        public string PixivisionCategorySlug { get; set; }

        [JsonPropertyName("pixivision_category")]
        public PixivisionCategory PixivisionCategory { get; set; }

        [JsonPropertyName("pixivision_subcategory_slug")]
        public string PixivisionSubcategorySlug { get; set; }

        [JsonPropertyName("pixivision_subcategory")]
        public PixivisionSubcategory PixivisionSubcategory { get; set; }

        [JsonPropertyName("tags")]
        public EntryTag[] Tags { get; set; }

        [JsonPropertyName("article_url")]
        public Uri ArticleUrl { get; set; }

        [JsonPropertyName("intro")]
        public string Intro { get; set; }

        [JsonPropertyName("facebook_count")]
        public string FacebookCount { get; set; }

        [JsonPropertyName("twitter_count")]
        public string TwitterCount { get; set; }
    }

    public partial class PixivisionCategory
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("introduction")]
        public string Introduction { get; set; }
    }

    public partial class PixivisionSubcategory
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("label_en")]
        public string LabelEn { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("introduction")]
        public string Introduction { get; set; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("big_image_url")]
        public string BigImageUrl { get; set; }
    }

    public partial class EntryTag
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public partial class BodyIllust
    {
        [JsonPropertyName("spotlight_article_id")]
        public long SpotlightArticleId { get; set; }

        [JsonPropertyName("illust_id")]
        public long IllustId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("illust_user_id")]
        public string IllustUserId { get; set; }

        [JsonPropertyName("illust_title")]
        public string IllustTitle { get; set; }

        [JsonPropertyName("illust_ext")]
        public string IllustExt { get; set; }

        [JsonPropertyName("illust_width")]
        public string IllustWidth { get; set; }

        [JsonPropertyName("illust_height")]
        public string IllustHeight { get; set; }

        [JsonPropertyName("illust_restrict")]
        public string IllustRestrict { get; set; }

        [JsonPropertyName("illust_x_restrict")]
        public string IllustXRestrict { get; set; }

        [JsonPropertyName("illust_create_date")]
        public string IllustCreateDate { get; set; }

        [JsonPropertyName("illust_upload_date")]
        public string IllustUploadDate { get; set; }

        [JsonPropertyName("illust_server_id")]
        public string IllustServerId { get; set; }

        [JsonPropertyName("illust_hash")]
        public string IllustHash { get; set; }

        [JsonPropertyName("illust_type")]
        public string IllustType { get; set; }

        [JsonPropertyName("illust_sanity_level")]
        public long IllustSanityLevel { get; set; }

        [JsonPropertyName("illust_book_style")]
        public string IllustBookStyle { get; set; }

        [JsonPropertyName("illust_page_count")]
        public string IllustPageCount { get; set; }

        [JsonPropertyName("illust_custom_thumbnail_upload_datetime")]
        public dynamic IllustCustomThumbnailUploadDatetime { get; set; }

        [JsonPropertyName("illust_comment")]
        public string IllustComment { get; set; }

        [JsonPropertyName("user_account")]
        public string UserAccount { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        [JsonPropertyName("user_comment")]
        public string UserComment { get; set; }

        [JsonPropertyName("url")]
        public Url Url { get; set; }

        [JsonPropertyName("ugoira_meta")]
        public dynamic UgoiraMeta { get; set; }

        [JsonPropertyName("user_icon")]
        public Uri UserIcon { get; set; }
    }

    public partial class Url
    {
        [JsonPropertyName("1200x1200")]
        public Uri The1200X1200 { get; set; }

        [JsonPropertyName("768x1200")]
        public Uri The768X1200 { get; set; }

        [JsonPropertyName("ugoira600x600")]
        public string Ugoira600X600 { get; set; }

        [JsonPropertyName("ugoira1920x1080")]
        public string Ugoira1920X1080 { get; set; }
    }

    public partial class RelatedArticle
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("ja")]
        public PrivacyPolicy Ja { get; set; }

        [JsonPropertyName("en")]
        public PrivacyPolicy En { get; set; }

        [JsonPropertyName("zh")]
        public PrivacyPolicy Zh { get; set; }

        [JsonPropertyName("zh_tw")]
        public PrivacyPolicy ZhTw { get; set; }

        [JsonPropertyName("publish_date")]
        public long PublishDate { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("pixivision_category_slug")]
        public string PixivisionCategorySlug { get; set; }

        [JsonPropertyName("pixivision_subcategory_slug")]
        public string PixivisionSubcategorySlug { get; set; }

        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonPropertyName("thumbnail_illust_id")]
        public string ThumbnailIllustId { get; set; }

        [JsonPropertyName("has_body")]
        public string HasBody { get; set; }

        [JsonPropertyName("is_pr")]
        public string IsPr { get; set; }

        [JsonPropertyName("pr_client_name")]
        public string PrClientName { get; set; }

        [JsonPropertyName("edit_status")]
        public string EditStatus { get; set; }

        [JsonPropertyName("translation_status")]
        public string TranslationStatus { get; set; }

        [JsonPropertyName("is_sample")]
        public string IsSample { get; set; }

        [JsonPropertyName("illusts")]
        public dynamic[] Illusts { get; set; }

        [JsonPropertyName("novel_ids")]
        public dynamic[] NovelIds { get; set; }

        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        [JsonPropertyName("facebook_count")]
        public string FacebookCount { get; set; }

        [JsonPropertyName("tweet_count")]
        public string TweetCount { get; set; }

        [JsonPropertyName("tweet_max_count")]
        public string TweetMaxCount { get; set; }

        [JsonPropertyName("tags")]
        public dynamic[] Tags { get; set; }

        [JsonPropertyName("tag_ids")]
        public dynamic TagIds { get; set; }

        [JsonPropertyName("numbered_tags")]
        public dynamic[] NumberedTags { get; set; }

        [JsonPropertyName("main_abtest_pattern_id")]
        public string MainAbtestPatternId { get; set; }

        [JsonPropertyName("advertisement_id")]
        public string AdvertisementId { get; set; }
    }

    public partial class PrivacyPolicy
    {
    }

    public partial class UgoiraMetadata : ResultBase
    {
        [JsonPropertyName("ugoira_metadata")]
        public UgoiraMetadataClass UgoiraMetadataUgoiraMetadata { get; set; }
    }

    public partial class UgoiraMetadataClass
    {
        [JsonPropertyName("zip_urls")]
        public Urls ZipUrls { get; set; }

        [JsonPropertyName("frames")]
        public Frame[] Frames { get; set; }
    }

    public partial class Frame
    {
        [JsonPropertyName("file")]
        public string File { get; set; }

        [JsonPropertyName("delay")]
        public long Delay { get; set; }
    }

    public partial class Urls
    {
        [JsonPropertyName("medium")]
        public Uri Medium { get; set; }
    }

    public partial class UserList : ResultBase
    {
        [JsonPropertyName("users")]
        public dynamic[] Users { get; set; }
    }

    public partial class UserFollowList : ResultBase
    {
        [JsonPropertyName("user_previews")]
        public UserPreview[] UserPreviews { get; set; }

        [JsonPropertyName("next_url")]
        public Uri NextUrl { get; set; }
    }

    public partial class UserPreview
    {
        [JsonPropertyName("user")]
        public IllustUser User { get; set; }

        [JsonPropertyName("illusts")]
        public UserPreviewIllust[] Illusts { get; set; }

        [JsonPropertyName("novels")]
        public dynamic[] Novels { get; set; }

        [JsonPropertyName("is_muted")]
        public bool IsMuted { get; set; }
    }

    public partial class UserPreviewIllust
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("image_urls")]
        public ImageUrls ImageUrls { get; set; }

        [JsonPropertyName("caption")]
        public string Caption { get; set; }

        [JsonPropertyName("restrict")]
        public long Restrict { get; set; }

        [JsonPropertyName("user")]
        public IllustUser User { get; set; }

        [JsonPropertyName("tags")]
        public IllustTag[] Tags { get; set; }

        [JsonPropertyName("tools")]
        public string[] Tools { get; set; }

        [JsonPropertyName("create_date")]
        public string CreateDate { get; set; }

        [JsonPropertyName("page_count")]
        public long PageCount { get; set; }

        [JsonPropertyName("width")]
        public long Width { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("sanity_level")]
        public long SanityLevel { get; set; }

        [JsonPropertyName("x_restrict")]
        public long XRestrict { get; set; }

        [JsonPropertyName("series")]
        public Series Series { get; set; }

        [JsonPropertyName("meta_single_page")]
        public MetaSinglePage MetaSinglePage { get; set; }

        [JsonPropertyName("meta_pages")]
        public MetaPage[] MetaPages { get; set; }

        [JsonPropertyName("total_view")]
        public long TotalView { get; set; }

        [JsonPropertyName("total_bookmarks")]
        public long TotalBookmarks { get; set; }

        [JsonPropertyName("is_bookmarked")]
        public bool IsBookmarked { get; set; }

        [JsonPropertyName("visible")]
        public bool Visible { get; set; }

        [JsonPropertyName("is_muted")]
        public bool IsMuted { get; set; }

        [JsonPropertyName("total_comments")]
        public long? TotalComments { get; set; }
    }

    public partial class ImageUrls
    {
        [JsonPropertyName("square_medium")]
        public Uri SquareMedium { get; set; }

        [JsonPropertyName("medium")]
        public Uri Medium { get; set; }

        [JsonPropertyName("large")]
        public Uri Large { get; set; }

        [JsonPropertyName("original")]
        public Uri Original { get; set; }
    }

    public partial class MetaPage
    {
        [JsonPropertyName("image_urls")]
        public ImageUrls ImageUrls { get; set; }
    }

    public partial class MetaSinglePage
    {
        [JsonPropertyName("original_image_url")]
        public Uri OriginalImageUrl { get; set; }
    }

    public partial class Series
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }

    public partial class IllustTag
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("translated_name")]
        public string TranslatedName { get; set; }
    }

    public partial class IllustUser
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("account")]
        public string Account { get; set; }

        [JsonPropertyName("profile_image_urls")]
        public Urls ProfileImageUrls { get; set; }

        [JsonPropertyName("is_followed")]
        public bool? IsFollowed { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }

    public partial class UserBookmarkTags : ResultBase
    {
        [JsonPropertyName("bookmark_tags")]
        public dynamic[] BookmarkTags { get; set; }

        [JsonPropertyName("next_url")]
        public Uri NextUrl { get; set; }
    }

    public partial class IllustBookmarkDetail : ResultBase
    {
        [JsonPropertyName("bookmark_detail")]
        public BookmarkDetail BookmarkDetail { get; set; }
    }

    public partial class BookmarkDetail
    {
        [JsonPropertyName("is_bookmarked")]
        public bool IsBookmarked { get; set; }

        [JsonPropertyName("tags")]
        public BookmarkDetailTag[] Tags { get; set; }

        [JsonPropertyName("restrict")]
        public string Restrict { get; set; }
    }

    public partial class BookmarkDetailTag
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("is_registered")]
        public bool IsRegistered { get; set; }
    }

    public partial class SearchIllustResult : ResultBase
    {
        [JsonPropertyName("illusts")]
        public UserPreviewIllust[] Illusts { get; set; }

        [JsonPropertyName("next_url")]
        public Uri NextUrl { get; set; }

        [JsonPropertyName("search_span_limit")]
        public long SearchSpanLimit { get; set; }
    }

    public partial class TrendingTagsIllust : ResultBase
    {
        [JsonPropertyName("trend_tags")]
        public TrendTag[] TrendTags { get; set; }
    }

    public partial class TrendTag
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("translated_name")]
        public string TranslatedName { get; set; }

        [JsonPropertyName("illust")]
        public UserPreviewIllust Illust { get; set; }
    }

    public partial class UserIllusts : ResultBase
    {
        [JsonPropertyName("illusts")]
        public UserPreviewIllust[] Illusts { get; set; }

        [JsonPropertyName("next_url")]
        public Uri NextUrl { get; set; }
    }

    public partial class IllustRecommended : ResultBase
    {
        [JsonPropertyName("illusts")]
        public UserPreviewIllust[] Illusts { get; set; }

        [JsonPropertyName("ranking_illusts")]
        public dynamic[] RankingIllusts { get; set; }

        [JsonPropertyName("contest_exists")]
        public bool ContestExists { get; set; }

        [JsonPropertyName("privacy_policy")]
        public PrivacyPolicy PrivacyPolicy { get; set; }

        [JsonPropertyName("next_url")]
        public Uri NextUrl { get; set; }
    }

    public partial class IllustCommentAddResult : ResultBase
    {
        [JsonPropertyName("comment")]
        public Comment Comment { get; set; }
    }

    public partial class Comment
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("comment")]
        public string CommentComment { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("user")]
        public IllustUser User { get; set; }

        [JsonPropertyName("has_replies")]
        public bool? HasReplies { get; set; }

        [JsonPropertyName("parent_comment")]
        public Comment ParentComment { get; set; }
    }

    public partial class IllustComments : ResultBase
    {
        [JsonPropertyName("total_comments")]
        public long TotalComments { get; set; }

        [JsonPropertyName("comments")]
        public Comment[] Comments { get; set; }

        [JsonPropertyName("next_url")]
        public Uri NextUrl { get; set; }
    }

    public partial class IllustDetail : ResultBase
    {
        [JsonPropertyName("illust")]
        public UserPreviewIllust Illust { get; set; }
    }

    public partial class UserDetail : ResultBase
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

    public partial class Profile
    {
        [JsonPropertyName("webpage")]
        public dynamic Webpage { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("birth")]
        public string Birth { get; set; }

        [JsonPropertyName("birth_day")]
        public string BirthDay { get; set; }

        [JsonPropertyName("birth_year")]
        public long BirthYear { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("address_id")]
        public long AddressId { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("job")]
        public string Job { get; set; }

        [JsonPropertyName("job_id")]
        public long JobId { get; set; }

        [JsonPropertyName("total_follow_users")]
        public long TotalFollowUsers { get; set; }

        [JsonPropertyName("total_mypixiv_users")]
        public long TotalMypixivUsers { get; set; }

        [JsonPropertyName("total_illusts")]
        public long TotalIllusts { get; set; }

        [JsonPropertyName("total_manga")]
        public long TotalManga { get; set; }

        [JsonPropertyName("total_novels")]
        public long TotalNovels { get; set; }

        [JsonPropertyName("total_illust_bookmarks_public")]
        public long TotalIllustBookmarksPublic { get; set; }

        [JsonPropertyName("total_illust_series")]
        public long TotalIllustSeries { get; set; }

        [JsonPropertyName("total_novel_series")]
        public long TotalNovelSeries { get; set; }

        [JsonPropertyName("background_image_url")]
        public Uri BackgroundImageUrl { get; set; }

        [JsonPropertyName("twitter_account")]
        public string TwitterAccount { get; set; }

        [JsonPropertyName("twitter_url")]
        public Uri TwitterUrl { get; set; }

        [JsonPropertyName("pawoo_url")]
        public Uri PawooUrl { get; set; }

        [JsonPropertyName("is_premium")]
        public bool IsPremium { get; set; }

        [JsonPropertyName("is_using_custom_profile_image")]
        public bool IsUsingCustomProfileImage { get; set; }
    }

    public partial class ProfilePublicity
    {
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("birth_day")]
        public string BirthDay { get; set; }

        [JsonPropertyName("birth_year")]
        public string BirthYear { get; set; }

        [JsonPropertyName("job")]
        public string Job { get; set; }

        [JsonPropertyName("pawoo")]
        public bool Pawoo { get; set; }
    }

    public partial class Workspace
    {
        [JsonPropertyName("pc")]
        public string Pc { get; set; }

        [JsonPropertyName("monitor")]
        public string Monitor { get; set; }

        [JsonPropertyName("tool")]
        public string Tool { get; set; }

        [JsonPropertyName("scanner")]
        public string Scanner { get; set; }

        [JsonPropertyName("tablet")]
        public string Tablet { get; set; }

        [JsonPropertyName("mouse")]
        public string Mouse { get; set; }

        [JsonPropertyName("printer")]
        public string Printer { get; set; }

        [JsonPropertyName("desktop")]
        public string Desktop { get; set; }

        [JsonPropertyName("music")]
        public string Music { get; set; }

        [JsonPropertyName("desk")]
        public string Desk { get; set; }

        [JsonPropertyName("chair")]
        public string Chair { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("workspace_image_url")]
        public Uri WorkspaceImageUrl { get; set; }
    }

    public partial class AuthResult : ResultBase
    {
        [JsonPropertyName("response")]
        public Response Response { get; set; }
    }

    public partial class Response
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("expires_in")]
        public long ExpiresIn { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonPropertyName("user")]
        public ResponseUser User { get; set; }

        [JsonPropertyName("device_token")]
        public string DeviceToken { get; set; }
    }

    public partial class ResponseUser
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

    public partial class ProfileImageUrls
    {
        [JsonPropertyName("px_16x16")]
        public Uri Px16X16 { get; set; }

        [JsonPropertyName("px_50x50")]
        public Uri Px50X50 { get; set; }

        [JsonPropertyName("px_170x170")]
        public Uri Px170X170 { get; set; }
    }

    public partial class ShowcaseArticle
    {
        [Obsolete]
        public static ShowcaseArticle FromJson(string json) => JsonSerializer.Deserialize<ShowcaseArticle>(json);
    }

    public partial class UgoiraMetadata
    {
        [Obsolete]
        public static UgoiraMetadata FromJson(string json) => JsonSerializer.Deserialize<UgoiraMetadata>(json);
    }

    public partial class UserList
    {
        [Obsolete]
        public static UserList FromJson(string json) => JsonSerializer.Deserialize<UserList>(json);
    }

    public partial class UserMyPixiv
    {
        [Obsolete]
        public static UserFollowList FromJson(string json) => JsonSerializer.Deserialize<UserFollowList>(json);
    }

    public partial class UserFollower
    {
        [Obsolete]
        public static UserFollowList FromJson(string json) => JsonSerializer.Deserialize<UserFollowList>(json);
    }

    public partial class UserFollowList
    {
        [Obsolete]
        public static UserFollowList FromJson(string json) => JsonSerializer.Deserialize<UserFollowList>(json);
    }

    public partial class UserBookmarkTags
    {
        [Obsolete]
        public static UserBookmarkTags FromJson(string json) => JsonSerializer.Deserialize<UserBookmarkTags>(json);
    }

    public partial class IllustBookmarkDetail
    {
        [Obsolete]
        public static IllustBookmarkDetail FromJson(string json) => JsonSerializer.Deserialize<IllustBookmarkDetail>(json);
    }

    public partial class SearchIllustResult
    {
        [Obsolete]
        public static SearchIllustResult FromJson(string json) => JsonSerializer.Deserialize<SearchIllustResult>(json);
    }

    public partial class TrendingTagsIllust
    {
        [Obsolete]
        public static TrendingTagsIllust FromJson(string json) => JsonSerializer.Deserialize<TrendingTagsIllust>(json);
    }

    public partial class IllustRanking
    {
        [Obsolete]
        public static UserIllusts FromJson(string json) => JsonSerializer.Deserialize<UserIllusts>(json);
    }

    public partial class IllustRecommended
    {
        [Obsolete]
        public static IllustRecommended FromJson(string json) => JsonSerializer.Deserialize<IllustRecommended>(json);
    }

    public partial class IllustRelated
    {
        [Obsolete]
        public static UserIllusts FromJson(string json) => JsonSerializer.Deserialize<UserIllusts>(json);
    }

    public partial class IllustCommentAddResult
    {
        [Obsolete]
        public static IllustCommentAddResult FromJson(string json) => JsonSerializer.Deserialize<IllustCommentAddResult>(json);
    }

    public partial class IllustComments
    {
        [Obsolete]
        public static IllustComments FromJson(string json) => JsonSerializer.Deserialize<IllustComments>(json);
    }

    public partial class IllustDetail
    {
        [Obsolete]
        public static IllustDetail FromJson(string json) => JsonSerializer.Deserialize<IllustDetail>(json);
    }

    public partial class IllustFollow
    {
        [Obsolete]
        public static UserIllusts FromJson(string json) => JsonSerializer.Deserialize<UserIllusts>(json);
    }

    public partial class UserBookmarksIllust
    {
        [Obsolete]
        public static UserIllusts FromJson(string json) => JsonSerializer.Deserialize<UserIllusts>(json);
    }

    public partial class UserIllusts
    {
        [Obsolete]
        public static UserIllusts FromJson(string json) => JsonSerializer.Deserialize<UserIllusts>(json);
    }

    public partial class UserDetail
    {
        [Obsolete]
        public static UserDetail FromJson(string json) => JsonSerializer.Deserialize<UserDetail>(json);
    }

    public partial class AuthResult
    {
        [Obsolete]
        public static AuthResult FromJson(string json) => JsonSerializer.Deserialize<AuthResult>(json);
    }
    [Obsolete]
    public static class Serialize
    {
        [Obsolete]
        public static string ToJson(this ShowcaseArticle self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this UgoiraMetadata self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this UserList self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this UserFollowList self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this UserBookmarkTags self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this IllustBookmarkDetail self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this SearchIllustResult self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this TrendingTagsIllust self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this UserIllusts self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this IllustRecommended self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this IllustCommentAddResult self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this IllustComments self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this IllustDetail self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this UserDetail self) => JsonSerializer.Serialize(self);
        [Obsolete]
        public static string ToJson(this AuthResult self) => JsonSerializer.Serialize(self);
    }
}
