using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Wuyiju.Model;

namespace Wuyiju.Domain.Model
{
    public static class JsonParse
    {
        public static string GetValue(this Article obj, string key)
        {
            var jss = new JavaScriptSerializer();

            if (!obj.From.IsNullOrWhiteSpace())
            {
                try
                {
                    var map = jss.Deserialize<Dictionary<string, string>>(obj.From);
                    return map[key];
                }
                catch
                {
                    return null;
                }
            }

            return null;
        }

        public static string GetArray(this Article obj, string key, int index)
        {
            var str = GetValue(obj, key);
            if (!str.IsNullOrWhiteSpace())
            {
                var arr = str.Split(',');
                if (index < arr.Length)
                    return arr[index];
            }

            return null;
        }

        public static string GetValue(this ProductFrontend obj, string key)
        {
            var jss = new JavaScriptSerializer();

            if (!obj.Score.IsNullOrWhiteSpace())
            {
                try
                {
                    var map = jss.Deserialize<Dictionary<string, string>>(obj.Score);
                    return map[key];
                }
                catch
                {
                    return null;
                }
            }

            return null;
        }

        public static string GetArray(this ProductFrontend obj, string key, int index)
        {
            var str = GetValue(obj, key);
            if (!str.IsNullOrWhiteSpace())
            {
                var arr = str.Split(',');
                if (index < arr.Length)
                    return arr[index];
            }

            return null;
        }
    }
}
