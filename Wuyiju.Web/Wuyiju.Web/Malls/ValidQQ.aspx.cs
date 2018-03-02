using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;

namespace Wuyiju.Web.Malls
{
    public partial class ValidQQ : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var qq = Request.Form["qq"];

            var adminService = unity.GetInstance<IAdminService>();

            var lst = adminService.GetList(new Model.Admin.Query { QQ = qq });
            if (lst != null && lst.Count > 0)
            {
                Response.Write("true");
                Response.End();
            }
            else
            {
                Response.Write("非本站客服QQ号码");
                Response.End();
            }
        }
    }
}