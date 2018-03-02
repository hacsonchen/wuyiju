using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web.Question
{
    public partial class Answer : UserPage
    {
        public Model.Question Model;

        protected override void OnPreLoad(EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            var id = Request.QueryString["id"].TryParseToInt32(0);

            if (id == 0) Response.Redirect("/Question/");

            var questionSvr = unity.GetInstance<IQuestionService>();

            Model = questionSvr.GetQuestion(id);

            Model.Click += 1;

            questionSvr.Modify(Model);


        }
    }
}