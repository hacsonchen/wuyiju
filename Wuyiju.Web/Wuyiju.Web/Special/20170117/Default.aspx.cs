using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Model;

namespace Wuyiju.Web.Special._20170117
{
    public partial class Default : BasePage
    {

        public string MainKefu;

        protected void Page_Load(object sender, EventArgs e)
        {
            var adminService = unity.GetInstance<IAdminService>();
            var kefuList = adminService.GetList(new Admin.Query { IsKefu = 1 });

            MainKefu = Page.Application["qqkefu1"].TryParseToString(string.Empty);

            if (kefuList != null && kefuList.Count > 0)
            {
                Random ran = new Random(unchecked((int)DateTime.Now.Ticks));
                int RandKey = ran.Next(0, kefuList.Count - 1);
                MainKefu = kefuList[RandKey].Qq;
            }

        }
    }
}