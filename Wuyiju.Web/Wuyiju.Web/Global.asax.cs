using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Wuyiju.Core;
using Wuyiju.Domain.Model;
using Wuyiju.IService;

namespace Wuyiju.Web
{
    
    public class Global : System.Web.HttpApplication
    {
        public UnityContext unity = new UnityContext();

        protected void Application_Start(object sender, EventArgs e)
        {
            //读取系统配置信息
            var configService = unity.GetInstance<IConfigService>();
            var config = configService.GetConfig("base");

            ApplicationConfig.SysFee = config.GetValue("sysfee").TryParseToDecimal(0.03m);

            Application.Add("name", config.GetValue("name"));
            Application.Add("site", config.GetValue("site"));
            Application.Add("slogan", config.GetValue("slogan"));
            Application.Add("seo_title", config.GetValue("seo_title"));
            Application.Add("seo_keys", config.GetValue("seo_keys"));
            Application.Add("seo_desc", config.GetValue("seo_desc"));
            Application.Add("beian", config.GetValue("beian"));
            Application.Add("tel", config.GetValue("tel"));
            Application.Add("fax", config.GetValue("fax"));
            Application.Add("hot_line", config.GetValue("hot_line"));
            Application.Add("qqkefu1", config.GetValue("qqkefu1"));
            Application.Add("qqkefu2", config.GetValue("qqkefu2"));
            Application.Add("qqkefu3", config.GetValue("qqkefu3"));
            Application.Add("address", config.GetValue("address"));
            Application.Add("keywords", config.GetValue("keywords"));
            Application.Add("description", config.GetValue("description"));
            Application.Add("copyright", config.GetValue("copyright"));
            Application.Add("sysfee", ApplicationConfig.SysFee);
            Application.Add("lowest_get_cash", config.GetValue("lowest_get_cash"));
            Application.Add("lowest_get_points_cash", config.GetValue("lowest_get_points_cash"));
            Application.Add("money_points_ratio", config.GetValue("money_points_ratio"));
            Application.Add("make_good", config.GetValue("make_good"));

            
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}