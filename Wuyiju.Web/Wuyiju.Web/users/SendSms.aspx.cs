using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.Web.Utils;
using Wuyiju.Core;

namespace Wuyiju.Web.users
{
    public partial class SendSms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var smsHelper = new SmsHelper();

            string mobile;
            string orderid;
            string key;
            string timestamp;
            string subname;

            if ("GET".Equals(Request.RequestType.ToUpper()))
            {
                mobile = Request.QueryString["phone"];
                key = Request.QueryString["key"];
                timestamp = Request.QueryString["timestamp"];
                orderid = Request.QueryString["order"];

                subname = Request.QueryString["subname"].UrlDecode();
            }
            else
            {
                mobile = Request.Form["phone"];
                key = Request.Form["key"];
                timestamp = Request.Form["timestamp"];
                orderid = Request.Form["order"];

                subname = Request.Form["subname"].UrlDecode();
            }

           var scrt = (mobile + timestamp  + orderid  + Wuyiju.Core.Utils.key).ToMD5();

            if (scrt.Equals(key))
            {
                if (smsHelper.SendOrder(mobile,subname, orderid))
                {
                    Response.Write("");
                    Response.End();
                }
            }


            Response.Write("ERROR");
            Response.End();

        }
    }
}