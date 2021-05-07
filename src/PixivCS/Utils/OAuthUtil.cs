using System;
using System.Security.Cryptography;
using System.Text;

namespace PixivCS.Utils
{
    internal static class OAuthUtil
    {
        private static readonly char[] padding = { '=' };

        public static string GenerateCodeVerify()
        {
            var byteArray = new byte[32];
            var provider = new RNGCryptoServiceProvider();
            provider.GetBytes(byteArray);
            return Convert.ToBase64String(byteArray).TrimEnd(padding).Replace('+', '-').Replace('/', '_');
        }

        public static string GenerateCodeChallenge(string code)
        {
            var toByteArray = Encoding.ASCII.GetBytes(code);
            byte[] hashValue = null;
            using (var mySHA256 = SHA256.Create())
            {
                try
                {
                    hashValue = mySHA256.ComputeHash(toByteArray);
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine($"Access Exception: {e.Message}");
                }
                return Convert.ToBase64String(hashValue).TrimEnd(padding).Replace('+', '-').Replace('/', '_');
            }
        }

    }

}
