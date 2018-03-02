using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.Core;
using Wuyiju.IService;
using Wuyiju.Model;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web.users
{
    public partial class RegisterHandle : UserPage
    {
        public User Model;

        protected override void OnPreLoad(EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            if ("POST".Equals(Request.RequestType.ToUpper()))
            {
                var userSvr = unity.GetInstance<IUserService>();

                var smsSvr = unity.GetInstance<ISmsService>();

                var user = new User();

                user.Name = Request.Form["name"];
                user.Password = Request.Form["pwd"];
                user.Mobile = Request.Form["mobile"];
                user.Introducer = Request.Form["introduce"];

                var sms_code = Request.Form["sms_code"].TryParseToString(string.Empty);

                try
                {

                    if (sms_code.IsNullOrWhiteSpace())
                        throw new ApplicationException("请输入短信验证码");

                    user.Login_Ip = Request.UserHostAddress;

                    var isValid = smsSvr.CheckCode(user.Mobile, sms_code);

                    if (!isValid)
                        Response.Redirect("Register.aspx?Message=" + "验证码错误".UrlEncode(), true);


                    userSvr.Register(user);
                    Model = user;


                    this.LoggedState.Clear();
                    this.LoggedState.DisplayName = user.Name;

                    this.LoggedState.UserId = user.Id.TryParseToString();
                    this.LoggedState.Entry = user;

                    this.LoggedState.Save();



                }
                catch (ThreadAbortException)
                {
                }
                catch (ApplicationException ex)
                {
                    //ViewState["Message"] = ex.Message;
                    Response.Redirect("Register.aspx?Message=" + ex.Message.UrlEncode());
                }
                catch (Exception ex)
                {
                    Logger.GetLogger().Error("用户注册\n", ex);
                    //ViewState["Message"] = "系统异常";
                    Response.Redirect("Register.aspx?Message=" + "系统异常".UrlEncode());
                }

            }
            else
            {
                Response.Redirect("Register.aspx");
            }

        }
    }
}