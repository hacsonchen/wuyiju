using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;

namespace Wuyiju.Web.users
{
    public partial class ProtectPassword : Utils.UserPage
    {
        public Model.User Model;
        public string ErrorMessage;
        public string Message;

        public bool HasQuestion;

        protected void Page_Load(object sender, EventArgs e)
        {
            var pwd_question = Request.Form["pwd_question"].TryParseToString();
            var pwd_answer = Request.Form["pwd_answer"].TryParseToString();
            var con_answer = Request.Form["con_answer"].TryParseToString();

            var answer = Request.Form["answer"].TryParseToString();

            ErrorMessage = Request.QueryString["err"].UrlDecode();
            Message = Request.QueryString["msg"].UrlDecode();

            var svr = unity.GetInstance<IUserService>();

            Model = svr.GetUser(LoggedUser.Name);

            HasQuestion = !Model.Pwd_Question.IsNullOrWhiteSpace();

            


            if (Request.Form.Count > 0 && LoggedUser.Id != 0)
            {
                try
                {
                    svr.SetPwdProtect(LoggedUser.Name, answer, pwd_question, pwd_answer, con_answer);
                    
                }
                catch(Exception ex)
                {
                    Response.Redirect(string.Format("ProtectPassword.aspx?err={0}", "系统异常，请稍候再试".UrlEncode()));
                }

                Response.Redirect(string.Format("ProtectPassword.aspx?msg={0}", "成功修改支付密码".UrlEncode()));
            }
        }
    }
}