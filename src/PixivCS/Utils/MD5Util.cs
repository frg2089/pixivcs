using System;
using System.Security.Cryptography;
using System.Text;

namespace PixivCS.Utils
{
    public static class MD5Util
    {
        /// <summary>
        /// 计算字符串的MD5值
        /// </summary>
        /// <remarks>
        /// 这个方法将会返回一串16进制的表示MD5的字符串
        /// </remarks>
        /// <param name="Input">将要进行计算的字符串</param>
        /// <returns>MD5字符串</returns>
        public static string MD5Hash(string Input)
        {
            if (string.IsNullOrEmpty(Input))
                throw new ArgumentNullException(nameof(Input));

            using (var md5 = MD5.Create())
            {
                var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(Input.Trim()));

                var builder = new StringBuilder(bytes.Length << 1);
                for (var i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));
                return builder.ToString();
            }
        }
    }
}
