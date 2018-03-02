using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;

namespace Wuyiju.Web.users
{
    public partial class CheckMobile : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var mobile = Request.QueryString["mobile"];

            if (!mobile.IsNullOrWhiteSpace())
            {
               var userSvr = unity.GetInstance<IUserService>();
               var exists = userSvr.ExistsMobile(mobile.ToString());

                if (!exists)
                {
                    Response.Write(1);
                    Response.End();
                }
            }

            Response.Write(0);
            Response.End();
        }
    }
}