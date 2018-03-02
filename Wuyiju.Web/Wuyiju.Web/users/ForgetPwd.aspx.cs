using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.Core;
using Wuyiju.IService;
using Wuyiju.Model;

namespace Wuyiju.Web.users
{
    public partial class ForgetPwd : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ("POST".Equals(Request.RequestType.ToUpper()))
            {
                var userSvr = unity.GetInstance<IUserService>();

                var smsSvr = unity.GetInstance<ISmsService>();

                var user = new User();

                user.Password = Request.Form["pwd"];
                user.Mobile = Request.Form["mobile"];


                var sms_code = Request.Form["sms_code"].TryParseToString(string.Empty);

                try
                {
                    user.Login_Ip = Request.UserHostAddress;

                    if (user.Mobile.IsNullOrWhiteSpace() || user.Password.IsNullOrWhiteSpace())
                        throw new ApplicationException("请输入手机号和要设置的密码！");

                    var isValid = smsSvr.CheckCode(user.Mobile, sms_code);

                    if (!isValid)
                        ViewState["Message"] = "验证码错误";

                    userSvr.ForgetPassword(user.Mobile, user.Password);

                    ViewState["Message"] = "设置成功，请前往登陆！";
                }

                catch (ApplicationException ex)
                {
                    //ViewState["Message"] = ex.Message;
                    ViewState["Message"] = ex.Message;
                }
                catch (Exception ex)
                {
                    Logger.GetLogger().Error("找回密码\n", ex);
                    //ViewState["Message"] = "系统异常";
                    ViewState["Message"] = ex.Message;
                }

            }

        }
    }
}