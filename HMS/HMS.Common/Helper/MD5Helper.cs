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
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string result = BitConverter.ToString(md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(text)));
            result = result.Replace("-", "");
            return result;
        }
    }
}
