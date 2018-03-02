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
    public partial class TakecashRecords : UserPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var svr = unity.GetInstance<IDepositTakecashService>();

            var query = new Model.DepositTakecash.Query
            {
                User_Id = LoggedUser.Id

            };

            ViewState["type"] = Request.Form["sztype"];

            if (ViewState["type"].TryParseToInt32(-1) != -1)
                query.Status = ViewState["type"].TryParseToInt32(-1);


            if (!((string)ViewState["startdate"]).IsNullOrWhiteSpace())
                query.StartDate = ViewState["startdate"].TryParseToDateTime();

            if (!((string)ViewState["enddate"]).IsNullOrWhiteSpace())
                query.EndDate = ViewState["enddate"].TryParseToDateTime();

            var pagestart = Request.QueryString[this.paging.UrlPageIndexName].TryParseToInt32(1);
            var pagesize = this.paging.PageSize;

            var data = svr.GetPaged(new Core.PagedQuery<Model.DepositTakecash.Query>
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