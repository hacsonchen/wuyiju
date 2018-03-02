using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Core
{
    [ReflectionPermission(SecurityAction.Demand, MemberAccess = false)]
    public class ApplicationAuthorizationInfo
    {
        internal ApplicationAuthorizationInfo(string licenseKey)
        {
            this.LicenseKey = licenseKey;
            this.Parse();
        }

        public string LicenseKey { get; private set; }
        public string LicenseDescription { get; private set; }

        /// <summary>
        /// 是否已授权
        /// </summary>
        public bool IsAuthorized { get; private set; }

        private void Parse()
        {
#if DEBUG
            this.LicenseDescription = "DevTesting";
            this.IsAuthorized = true;
#else
            //var bytes = Encoding.UTF8.GetBytes(this.LicenseKey);
            //var decoded = bytes.AsDecryptor().DESDecrypto(null, null);

            //var lines = decoded.Split(Environment.NewLine).Select(d => d.Trim()).ToList();
            //var variables = lines[0];
#endif
        }
    }
}
