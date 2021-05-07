using System;

namespace PixivCS.Exceptions
{
    /// <summary>
    /// 表示一个Pixiv API异常
    /// </summary>
    [Serializable]
    public class PixivException : Exception
    {
        public PixivException() { }
        public PixivException(string message) : base(message) { }
        public PixivException(string message, Exception inner) : base(message, inner) { }
        protected PixivException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}