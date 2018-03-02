using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.Core;
using Wuyiju.IService;
using Wuyiju.Model;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web.users
{
    public partial class Register : UserPage
    {

        protected override void OnPreLoad(EventArgs e)
        {
        }


        protected override void OnLoad(EventArgs e)
        {
            if (LoggedState.IsLogged)
            {
                Response.Redirect("/Users/",true);
            }
        }
    }
}