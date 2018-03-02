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
    public partial class RechargeRecords : UserPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var svr = unity.GetInstance<IDepositRechargeService>();

            var query = new Model.DepositRecharge.Query
            {
                User_Id = LoggedUser.Id

            };

            ViewState["type"] = Request.Form["sztype"];

            if (!ViewState["type"].IsNull())
                query.Status = ViewState["type"].TryParseToInt32(0);


            if (!((string)ViewState["startdate"]).IsNullOrWhiteSpace())
                query.StartDate = ViewState["startdate"].TryParseToDateTime();

            if (!((string)ViewState["enddate"]).IsNullOrWhiteSpace())
                query.EndDate = ViewState["enddate"].TryParseToDateTime();


            var pagestart = Request.QueryString[this.paging.UrlPageIndexName].TryParseToInt32(1);
            var pagesize = this.paging.PageSize;

            var data = svr.GetPaged(new Core.PagedQuery<Model.DepositRecharge.Query>
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