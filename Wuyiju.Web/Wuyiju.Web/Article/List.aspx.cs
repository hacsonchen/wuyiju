using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;

namespace Wuyiju.Web.Article
{
    public partial class List : BasePage
    {
        public Model.Title Category;

        protected void Page_Load(object sender, EventArgs e)
        {
            var svr = unity.GetInstance<IArticleService>();
            var catService = unity.GetInstance<ITitleService>();

            var query = new Model.Article.Query { Status = 1 };

            ViewState["cat"] = Request.QueryString["cat"];

            if (ViewState["cat"].TryParseToInt32(-1) != -1)
                query.Cate_Id = ViewState["cat"].TryParseToInt32(-1);

            Category = catService.GetTitle(query.Cate_Id == null ? 0 : query.Cate_Id.Value);

            Category = Category ?? new Model.Title();

            var pagestart = Request.QueryString[this.paging.UrlPageIndexName].TryParseToInt32(1);
            var pagesize = this.paging.PageSize;

            var data = svr.GetPaged(new Core.PagedQuery<Model.Article.Query>
            {
                PageStart = pagestart,
                PageSize = pagesize,
                Filter = query
            });


            this.paging.RecordCount = data.RecordsTotal;
            this.paging.CurrentPageIndex = pagestart;

            rptList.DataSource = data.Records;
            rptList.DataBind();
        }
    }
}