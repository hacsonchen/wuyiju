using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Core
{
    public static class Utils
    {
        public static string ToMD5(this string inputString)
        {
            if (inputString == null) return null;

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encryptedBytes = md5.ComputeHash(Encoding.ASCII.GetBytes(inputString));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encryptedBytes.Length; i++)
            {
                sb.AppendFormat("{0:x2}", encryptedBytes[i]);
            }
            return sb.ToString();
        }

        #region 获取由SHA1加密的字符串
        public static string EncryptToSHA1(string str)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] str1 = Encoding.UTF8.GetBytes(str);
            byte[] str2 = sha1.ComputeHash(str1);
            sha1.Clear();
            (sha1 as IDisposable).Dispose();
            return Convert.ToBase64String(str2);
        }
        #endregion

        public static DateTime ToDateTime(this int timestamp)
        {
            var start = new DateTime(1970, 1, 1, 0, 0, 0);
            return start.AddSeconds(timestamp);
        }

        public static DateTime ToDateTime2(this long timestamp)
        {
            var start = new DateTime(1970, 1, 1, 0, 0, 0);
            return start.AddSeconds(timestamp);
        }

        public static long ToTimeStamp2(this DateTime datetime)
        {
            var start = new DateTime(1970, 1, 1, 0, 0, 0, datetime.Kind);
            return Convert.ToInt64((datetime - start).TotalSeconds);
        }

        

        public static string key = "9b4bd4598d3d52d87a796425c4007972";                 //加密密钥
        public static string url = "http://tmallzr.com/Users/SendSms.aspx";                                                 //发送短信接口地址
    }
}
