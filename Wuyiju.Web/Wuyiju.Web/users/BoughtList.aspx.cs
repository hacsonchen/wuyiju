using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Model;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web.users
{
    public partial class BoughtList : UserPage
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            var svr = unity.GetInstance<IOrderService>();

            var query = new Model.Order.Query { Uid = LoggedUser.Id };


            string PostStatus = Request.Form["pay_status"];
            string GetStatus = Request.QueryString["pay_status"];


            ViewState["type"] = string.IsNullOrWhiteSpace(PostStatus) ? GetStatus : PostStatus;

            if (ViewState["type"].TryParseToInt32(-1) != -1)
                query.Pay_Status = ViewState["type"].TryParseToInt32(-1);

            var pagestart = Request.QueryString[this.paging.UrlPageIndexName].TryParseToInt32(1);
            var pagesize = this.paging.PageSize;

            var data = svr.GetBoughtPaged(new Core.PagedQuery<Model.Order.Query>
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