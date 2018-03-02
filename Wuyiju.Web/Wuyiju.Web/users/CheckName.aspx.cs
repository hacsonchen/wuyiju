using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;

namespace Wuyiju.Web.users
{
    public partial class CheckName : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var name = Request.QueryString["name"].TryParseToString(string.Empty);
            var svr = unity.GetInstance<IUserService>();
            var user = svr.GetUser(name);

            if (user == null)
            {
                Response.Write(1);
                Response.End();
            }
            else
            {
                Response.Write(0);
                Response.End();
            }

            
        }
    }
}