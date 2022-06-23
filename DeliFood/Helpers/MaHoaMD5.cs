using System;
using System.Security.Cryptography;

namespace DeliFood.Helpers
{
    public static class MaHoaMD5
    {
        public static string ToMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str; ;
        }
    }
}
