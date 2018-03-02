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
    public partial class Default : UserPage
    {
        protected override void OnPreLoad(EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            var pagestart = Request.QueryString[this.paging.UrlPageIndexName].TryParseToInt32(1);
            var pagesize = this.paging.PageSize;

           int? typeId;

            if (Request.QueryString["t"].IsNullOrEmpty())
            {
                typeId = null;
            }
            else
            {
                typeId = Request.QueryString["t"].TryParseToInt32();
            }

            var questionSvr = unity.GetInstance<IQuestionService>();

            var paged = questionSvr.GetPaged(new Core.PagedQuery<Model.Question.Query> {
                PageStart = pagestart,
                PageSize = pagesize,
                Filter = new Model.Question.Query {
                    Type_Id = typeId
                } });

            this.paging.RecordCount = paged.RecordsTotal;

            rptQuestions.DataSource = paged.Records;

            rptQuestions.DataBind();

            
        }
    }
}