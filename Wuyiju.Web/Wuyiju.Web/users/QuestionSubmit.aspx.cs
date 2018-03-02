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
    public partial class QuestionSubmit : UserPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var questionSvr = unity.GetInstance<IQuestionService>();

            if ("POST".Equals(Request.RequestType.ToUpper()))
            {
                var question = new Model.Question();
                question.Title = Request.Form["title"];
                question.Info = Request.Form["content"];
                question.Type_Id = Request.Form["default1"].TryParseToInt32(0);
                question.User_Id = LoggedUser.Id;
                question.Add_Time = DateTime.Now.ToUnixTimestamp();

                question.From = "";
                question.Img = "";
                question.Url = "";
                question.Resp = "";
                question.Seo_Title = "";
                question.Seo_Keys = "";
                question.Seo_Desc = "";
                question.Filename = "";

                try
                {
                    questionSvr.Add(question);
                    ViewState["Message"] = "问题发布成功。";
                }
                catch (ApplicationException ex)
                {
                    ViewState["Message"] = ex.Message;
                }
                catch
                {
                    ViewState["Message"] = "系统异常";
                }
            }
        }
    }
}