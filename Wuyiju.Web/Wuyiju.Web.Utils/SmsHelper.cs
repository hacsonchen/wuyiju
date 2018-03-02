using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml;
using Wuyiju.Core;
using Wuyiju.Domain.Model;
using Wuyiju.IService;

namespace Wuyiju.Web.Utils
{
    public class SmsHelper
    {
        private string userid;
        private string account;
        private string password;
        private string baseUrl = "http://120.76.152.174:8888/sms.aspx";

        public SmsHelper()
        {
            this.userid = "134";
            this.account = "jdw01";
            this.password = "249525447";
        }

        public SmsHelper(string userid, string account, string password)
        {
            this.userid = userid;
            this.password = password;
        }

        public bool SendText(string mobile, string msg)
        {
            var net = new NetHelper();

            var now = DateTime.Now.ToString("yyyyMMddHHmmss");

            var sign = (this.account + this.password + now).ToMD5();


            var url = string.Format("{5}?action=send&userid={0}&password={1}&mobile={3}&content={4}&account={6}&sendTime=&extno=",
                this.userid,
                this.password,
                sign,
                mobile,
                msg.UrlEncode(),
                baseUrl,
                account);

            try
            {
                string res = net.InvokeWebPost(url, null);

                var xml = new XmlDocument();
                xml.LoadXml(res);

                var status = xml.SelectSingleNode("/returnsms/returnstatus");

                if (status.IsNull())
                {
                    return false;
                }
                else
                {
                    return "success".Equals(status.InnerText.ToLower());
                }


            }
            catch (Exception ex)
            {
                Logger.GetLogger().Error("发送短信出错\n", ex);
                return false;
            }

        }

        public bool SendOrder(string mobile,string subname, string orderid)
        { 
            string msg = string.Format("【巨店网】您出售的店铺[{0}]买家已经付款,如有疑问请联系选猫网", subname);

            var unity = new UnityContext();

            var orderService = unity.GetInstance<IOrderService>();

            var order = orderService.GetOrder(orderid);

#if !DEBUG
            if (order != null && order.Send_Mail != 1 && order.Mobile.Equals(mobile))
            {

                if (SendText(mobile, msg))
                {
                    order.Send_Mail = 1;
                    orderService.Modify(order);

                    return true;
                }
            }

#endif

#if DEBUG
            if (SendText(mobile, msg))
            {
                return true;
            }
#endif

            return false;
        }

        public static void SendEmail(string email, string subject, string body)
        {
            try
            {

                var unity = new UnityContext();
                var configService = unity.GetInstance<IConfigService>();


                var cfg = configService.GetConfig(1);

                var smtp = new SmtpClient();

                smtp.Host = cfg.GetValue("host");
                smtp.Port = cfg.GetValue("port").TryParseToInt32();
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = "ssl".Equals(cfg.GetValue("secure")) ? true : false;

                System.Net.NetworkCredential nc = new System.Net.NetworkCredential(cfg.GetValue("username"), cfg.GetValue("password"));
                smtp.Credentials = nc.GetCredential(smtp.Host, smtp.Port, "NTLM");

                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

                smtp.Send(cfg.GetValue("email"), email, subject, body);

            }
            catch (Exception ex)
            {
                Logger.GetLogger().Error("发送邮件出错\n", ex);
            }
        }


    }
}
