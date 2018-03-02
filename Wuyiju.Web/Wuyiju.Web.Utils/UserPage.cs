using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Web.Utils
{
    public class UserPage : BasePage
    {
        protected override void OnAuthorityValidation(Model.User loggedUser)
        {
            if (loggedUser.IsNull())
            {
                
                Response.Redirect("/Users/Login.aspx?return="+ Request.RawUrl.UrlEncode(), true);
            }
                

            if (!OnAuthorityPermissionValidate(loggedUser))
            {
                Response.Write("没有权限");
                Response.End();
            }
        }

        protected override void OnPreLoad(EventArgs e)
        {
            if (!this.LoggedState.IsLogged)
                Response.Redirect("/Users/Login.aspx?return=" + Request.RawUrl.UrlEncode(), true);

            OnAuthorityValidation(this.LoggedUser);
        }

        protected virtual bool OnAuthorityPermissionValidate(Model.User loggedUser)
        {
            return true;
        }
    }
}
