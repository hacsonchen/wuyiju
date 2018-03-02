using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web.users
{
    public partial class Login : UserPage
    {
        public string ErrorMessage;
        protected override void OnPreLoad(EventArgs e)
        {
        }


        protected override void OnLoad(EventArgs e)
        {
            var username = Request.Form["name"].TryParseToString(string.Empty);
            var password = Request.Form["password"].TryParseToString(string.Empty);

            var return_url = Request.QueryString["return"].TryParseToString(string.Empty);

            ErrorMessage = Request.QueryString["error"].TryParseToString(string.Empty);

            if (!username.IsNullOrEmpty() && !password.IsNullOrEmpty())
            {
                var svr = unity.GetInstance<IUserService>();
                Model.User user = null;

                try
                {
                    user = svr.CheckUser(username, password);
                }
                catch (ApplicationException ex)
                {
                    Response.Redirect("Login.aspx?error=" + ex.Message.UrlEncode());
                }
                catch (Exception)
                {
                    Response.Redirect("Login.aspx?error=" + "系统异常".UrlEncode());
                }

                


                if (!user.IsNull())
                {
                    user.Last_Ip = user.Login_Ip;
                    user.Login_Ip = Request.ServerVariables["REMOTE_ADDR"];
                    user.Login_Count = user.Login_Count + 1;
                    svr.Modify(user);

                    this.LoggedState.Clear();
                    this.LoggedState.DisplayName = user.Name;

                    this.LoggedState.UserId = user.Id.TryParseToString();
                    this.LoggedState.Entry = user;

                    this.LoggedState.Save();
                    if (return_url.IsNullOrWhiteSpace())
                        Response.Redirect("/Users/", true);
                    else
                        Response.Redirect(return_url);
                }
            }
        }
    }
}