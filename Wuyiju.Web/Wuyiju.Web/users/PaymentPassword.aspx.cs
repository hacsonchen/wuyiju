using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;

namespace Wuyiju.Web.users
{
    public partial class PaymentPassword : Utils.UserPage
    {
        public string ErrorMessage;
        public string Message;

        public bool HasPaypwd;

        protected void Page_Load(object sender, EventArgs e)
        {
            var old_pwd = Request.Form["old_pwd"].TryParseToString(null);
            var new_pwd = Request.Form["new_pwd"].TryParseToString();
            var confirm_pwd = Request.Form["confirm_pwd"].TryParseToString();

            ErrorMessage = Request.QueryString["err"].UrlDecode();
            Message = Request.QueryString["msg"].UrlDecode();

            HasPaypwd = !LoggedUser.Pay_Password.IsNullOrWhiteSpace();

            var svr = unity.GetInstance<IUserService>();

            if (Request.Form.Count > 0 && LoggedUser.Id != 0)
            {
                try
                {
                    svr.SetPaymentPwd(LoggedUser.Name, old_pwd, new_pwd, confirm_pwd);
                    
                }
                catch
                {
                    Response.Redirect(string.Format("PaymentPassword.aspx?err={0}", "系统异常，请稍候再试".UrlEncode()));
                }

                Response.Redirect(string.Format("PaymentPassword.aspx?msg={0}", "成功修改支付密码".UrlEncode()));
            }
        }
    }
}