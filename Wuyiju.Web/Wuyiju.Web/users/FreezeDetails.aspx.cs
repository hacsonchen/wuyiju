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
    public partial class FreezeDetails : UserPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var svr = unity.GetInstance<IUserAccountRecordsService>();

            var query = new Model.UserAccountRecords.Query();

            //ViewState["way"] = Request.Form["way"];

            ViewState["type"] = Request.Form.GetValues("type");

            ViewState["smoney"] = Request.Form["smoney"];
            ViewState["emoney"] = Request.Form["emoney"];
            ViewState["startdate"] = Request.Form["startdate"];
            ViewState["enddate"] = Request.Form["enddate"];

            //if (!ViewState["way"].IsNull())
            //    query.Way = ViewState["way"].TryParseToInt32(0);

            query.Way = 3;
            query.User_Id = LoggedUser.Id;

            if (!((string)ViewState["smoney"]).IsNullOrWhiteSpace())
                query.Smoney = ViewState["smoney"].TryParseToDecimal();

            if (!((string)ViewState["emoney"]).IsNullOrWhiteSpace())
                query.Emoney = ViewState["emoney"].TryParseToDecimal();

            if (!((string)ViewState["startdate"]).IsNullOrWhiteSpace())
                query.StartDate = ViewState["startdate"].TryParseToDateTime();

            if (!((string)ViewState["enddate"]).IsNullOrWhiteSpace())
                query.EndDate = ViewState["enddate"].TryParseToDateTime();

            var qCheck = (string[])ViewState["type"];

            if (qCheck != null && qCheck.Length > 0)
            {

                query.Check = new int?[qCheck.Length];

                for (int i = 0; i < qCheck.Length; i++)
                {
                    query.Check[i] = qCheck[i].TryParseToInt32();
                }
            }


            var pagestart = Request.QueryString[this.paging.UrlPageIndexName].TryParseToInt32(1);
            var pagesize = this.paging.PageSize;

            var data = svr.GetPaged(new Core.PagedQuery<Model.UserAccountRecords.Query>
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