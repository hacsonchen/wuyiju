using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Core;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web.users
{
    public partial class AuthMobileHandle : UserPage
    {
        public int RandomNumber(int minValue, int maxValue)
        {
            Random ran = new Random();
            return ran.Next(minValue, maxValue);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if ("POST".Equals(Request.RequestType.ToUpper()))
            {
                var smsService = unity.GetInstance<ISmsService>();
                var usrService = unity.GetInstance<IUserService>();

                var code = Request.Form["yanzhNum"];

                var sms = smsService.GetSms(LoggedUser.Mobile);

                if (sms == null || code.IsNullOrWhiteSpace())
                    ViewState["Error"] = "验证码错误";

                bool IsValid = false;

                try
                {
                    IsValid = (DateTime.Now.Subtract(sms.Add_Time.ToDateTime2()).Minutes < 30);
                }
                catch
                {
                    ViewState["Error"] = "验证码错误";
                }


                if (IsValid && code.Equals(sms.Validatecode))
                {
                    var usr = LoggedUser;
                    usr.Is_Mobile_Validated = 1;
                    usrService.Modify(usr);
                    LoggedState.Refresh();

                    Response.Redirect("/Users/AuthMobile.aspx");
                }
                else
                {
                    ViewState["Error"] = "验证码错误";
                }
            }

            if ("GET".Equals(Request.RequestType.ToUpper()))
            {
                var code = RandomNumber(1000, 9999).ToString();
                var smsHelper = new SmsHelper();

                var smsService = unity.GetInstance<ISmsService>();

                var sms_code = LoggedUser.Mobile;

                if (!sms_code.IsNullOrWhiteSpace())
                {

                    var mobile = sms_code.ToString();

                    var sms = smsService.GetSms(mobile);

                    var isValid = sms != null && smsService.CheckCode(mobile, sms.Validatecode);

                    smsHelper.SendText(sms_code.ToString(), string.Format("【巨店网】你正在进行巨店网旗下网站的短信验证，验证码{0}，请在15分钟内按页面提示提交，打死也不能告诉别人哦", code));

                    if (sms == null)
                    {
                        sms = new Model.Sms();
                        sms.Add_Time = DateTime.Now.ToUnixTimestamp();
                        sms.Validatecode = code;
                        sms.Mobile = mobile;

                        smsService.Add(sms);
                    }
                    else
                    {
                        sms.Validatecode = code;
                        smsService.Modify(sms);
                    }
                }
                else
                {
                    ViewState["Error"] = "请完善手机号";
                }
            }
        }
    }
}