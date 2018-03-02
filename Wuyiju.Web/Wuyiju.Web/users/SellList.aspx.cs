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
    public partial class SellList : UserPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var svr = unity.GetInstance<IProductService>();

            var query = new Model.Product.Query { Seller_Id = LoggedUser.Id.ToString() };
            ViewState["type"] = Request.Form["pay_status"];

            if (ViewState["type"].TryParseToInt32(-1) != -1)
                query.Pay_Status = ViewState["type"].TryParseToInt32(-1);

            var pagestart = Request.QueryString[this.paging.UrlPageIndexName].TryParseToInt32(1);
            var pagesize = this.paging.PageSize;

            var data = svr.GetPaged(new Core.PagedQuery<Model.Product.Query>
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