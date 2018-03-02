using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Web.Utils
{
    public static class UrlHelper
    {
        public static string BuildQueryString(IEnumerable<KeyValuePair<string, string>> param)
        {
            var str = new StringBuilder();
            str.AppendFormat("?go=0");
            if (param != null && param.Count() > 0)
            {
                int i = 0;
                foreach (var p in param)
                {
                    str.AppendFormat("{0}{1}={2}", "&", p.Key, p.Value);
                    i++;
                }
            }

            return str.ToString();
        }

        public static string BuildQueryString(IEnumerable<KeyValuePair<string, string>> param, string conclude)
        {
            var str = new StringBuilder();
            str.AppendFormat("?go=0");
            if (param != null && param.Count() > 0)
            {
                int i = 0;
                foreach (var p in param)
                {
                    if (p.Key.Equals(conclude))
                        break;

                    str.AppendFormat("{0}{1}={2}", "&", p.Key, p.Value);
                    i++;


                }
            }

            return str.ToString();
        }
    }
}
