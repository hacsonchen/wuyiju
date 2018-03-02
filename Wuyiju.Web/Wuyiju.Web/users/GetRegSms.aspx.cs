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
    public partial class GetRegSms : BasePage
    {
        private const string KEY_SESSION = "__WYJ_REG_SESN__";
        protected void Page_Load(object sender, EventArgs e)
        {
            var sms_code = Request.Form["sms_code"];
            if (sms_code != null)
            {
                var code = RandomNumber(1000, 9999).ToString();
                var smsHelper = new SmsHelper();

                var smsService = unity.GetInstance<ISmsService>();

                var mobile = sms_code.ToString();

                var sms = smsService.GetSms(mobile);

                var isValid = sms != null && smsService.CheckCode(mobile, sms.Validatecode);

                if(isValid) code = sms.Validatecode;

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

                Response.Write("true");
                Response.End();

            }
        }

        public int RandomNumber(int minValue, int maxValue)
        {
            Random ran = new Random();
            return ran.Next(minValue, maxValue);
        }
    }
}