using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.Web.Utils;
using Wuyiju.Core;
using Wuyiju.IService;

namespace Wuyiju.Web.users
{
    public partial class AuthEmail : UserPage
    {
        private static byte[] key = { 201, 202, 23, 24, 215, 216, 27, 208 };
        private static byte[] iv = { 101, 12, 113, 114, 15, 116, 17, 108 };

        protected void Page_Load(object sender, EventArgs e)
        {

            if (LoggedUser.Is_Email_Validated == 0)
            {
                if ("POST".Equals(Request.RequestType.ToUpper()))
                {
                    var stamp = DateTime.Now.ToUnixTimestamp();
                    var userid = LoggedUser.Id;

                    var s = string.Format("WUYIJU{0}{1}{0}{2}", Environment.NewLine, userid, stamp);
                    var b = s.AsEncryptor().DESEncrypto(key, iv);
                    var secret = Convert.ToBase64String(b);

                    try
                    {
                        var authEmail =  Request.Form["renzemail"];

                        if (!authEmail.IsNullOrWhiteSpace())
                        {

                            SmsHelper.SendEmail("1501404140@qq.com", "选猫网帐号认证", string.Format("请点击此链接进行完成验证http://{0}:{1}{2}?authkey={3}",
                                this.Request.Url.Host,
                                this.Request.Url.Port,
                                this.Request.Path,
                                secret.UrlEncode()));

                            ViewState["Message"] = "请登陆邮箱进行验证";
                        }
                        else
                        {
                            ViewState["Error"] = "请输入正确的邮箱";
                        }
                    }
                    catch
                    {
                        ViewState["Error"] = "系统异常，请稍候再试";
                    }

                }

                var authkey = Request.QueryString["authkey"];

                if (!authkey.IsNullOrWhiteSpace())
                {
                    var d = Convert.FromBase64String(authkey);
                    var s = d.AsDecryptor().DESDecrypto(key, iv);
                    var args = s.Split(Environment.NewLine);


                    if (args.Length == 3 && args[1].Equals(LoggedUser.Id.ToString()))
                    {
                        var time = args[2].TryParseToInt64();
                        try
                        {
                            if (DateTime.Now.Subtract(time.ToDateTime2()).Minutes > 30)
                                ViewState["Message"] = "链接已过期，请重新发送验证";

                           var svr = unity.GetInstance<IUserService>();

                           var user =  svr.GetUser(LoggedUser.Name);

                            user.Is_Email_Validated = 1;
                            svr.Modify(user);

                            LoggedState.Refresh();

                            ViewState["Message"] = "邮箱验证成功";
                        }
                        catch
                        {
                            ViewState["Message"] = "系统异常，请重新发送验证";
                        }
                    }
                    else
                    {
                        ViewState["Message"] = "非法链接验证不通过";
                    }
                }

            }
            else if (LoggedUser.Is_Email_Validated == 1)
            {

            }
        }
    }
}