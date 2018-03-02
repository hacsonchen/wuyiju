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
    public partial class Favorites : UserPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var svr = unity.GetInstance<IProductService>();

            var query = new Model.Product.Query { User_Id = LoggedUser.Id };


            var pagestart = Request.QueryString[this.paging.UrlPageIndexName].TryParseToInt32(1);
            var pagesize = this.paging.PageSize;

            var data = svr.GetFavoritedPaged(new Core.PagedQuery<Model.Product.Query>
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