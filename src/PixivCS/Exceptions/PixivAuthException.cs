using System;

namespace PixivCS.Exceptions
{
    /// <summary>
    /// Pixiv 认证异常
    /// </summary>
    [Serializable]
    public class PixivAuthException : PixivException
    {
        public PixivAuthException() { }
        public PixivAuthException(string message) : base(message) { }
        public PixivAuthException(string message, Exception inner) : base(message, inner) { }
        protected PixivAuthException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}