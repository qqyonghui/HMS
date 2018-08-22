using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HMS.Common.Helper
{
    public class MD5Helper
    {
        public static string MD5Encrypt(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(text));
            return System.Text.Encoding.Default.GetString(result);
        }
    }
}
