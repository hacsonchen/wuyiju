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
    public partial class AddSuggest : UserPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var suggestSvr = unity.GetInstance<ISuggestService>();

            if ("POST".Equals(Request.RequestType.ToUpper()))
            {
                var suggest = new Model.Suggest();
                suggest.Title = Request.Form["jycontent"];


                if (suggest.Title.IsNullOrWhiteSpace())
                {
                    ViewState["Message"] = "请填写建议内容。";
                    return;
                }


                suggest.Info = suggest.Title;

                suggest.User_Id = LoggedUser.Id;
                suggest.Add_Time = DateTime.Now.ToUnixTimestamp();

                suggest.From = string.Format("{{\"name\":\"{0}\",\"contact\":\"{1}\"}}", "", "");
                suggest.Img = "";
                suggest.Url = "";
                suggest.Resp = "";
                suggest.Seo_Title = "";
                suggest.Seo_Keys = "";
                suggest.Seo_Desc = "";
                suggest.Filename = "";

                try
                {
                    suggestSvr.Add(suggest);
                }
                catch (ApplicationException ex)
                {
                    Response.Write(ex.Message);
                    Response.End();
                }
                catch
                {
                    Response.Write("系统异常");
                    Response.End();
                }

                Response.Write("");
                Response.End();
            }
        }
    }
}