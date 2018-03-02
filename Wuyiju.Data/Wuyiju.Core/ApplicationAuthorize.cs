using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Wuyiju.Core
{
    [ReflectionPermission(SecurityAction.Demand, MemberAccess = false)]
    public class ApplicationAuthorize : IConfigurationSectionHandler
    {
        private ApplicationAuthorize()
        {
        }

        public static ApplicationAuthorizationInfo GetAuthorizationInfo()
        {
            var section = ConfigurationManager.GetSection("app-auth").ToString();
            return new ApplicationAuthorizationInfo(section);
        }

        public object Create(object parent, object configContext, XmlNode section)
        {
            return section.InnerText;
        }
    }
}
