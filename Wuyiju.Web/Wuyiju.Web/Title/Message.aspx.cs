using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;

namespace Wuyiju.Web.Title
{
    public partial class Message : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ("POST".Equals(Request.RequestType.ToUpper()))
            {
                var msg = new Model.Message();
                var titleSvr = unity.GetInstance<IMessageService>();
                msg.message = Request.Form["message"];
                msg.Mobile = Request.Form["mobile"];
                msg.Msgtitle = Request.Form["message"];
                msg.Mail = Request.Form["mail"];
                msg.Qq = Request.Form["qq"];
                msg.Name = Request.Form["name"];
                msg.Type = 3;
                msg.Status = 0;
                msg.Time = DateTime.Now.ToUnixTimestamp();
                try
                {
                    titleSvr.Add(msg);
                    object json = new { status = 1 };

                    Response.Write(json.SerializeToJson());
                    Response.End();
                }
                catch (ApplicationException ex)
                {
                    object json = new { status = 0, msg = ex.Message };

                    Response.Write(json.SerializeToJson());
                    Response.End();
                }
            }
        }
    }
}