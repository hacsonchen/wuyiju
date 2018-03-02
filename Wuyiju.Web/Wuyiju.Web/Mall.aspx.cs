using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Model;

namespace Wuyiju.Web
{
    public partial class Mall : BasePage
    {
        public IList<ProductAttr> Attributes;
        protected void Page_Load(object sender, EventArgs e)
        {
            var cat = Request.QueryString["c"];
            var key = Request.QueryString["q"];

            if (cat != null)
            {
                var c = cat.TryParseToString();
                ViewState["catid"] = cat.TryParseToString();
            }

            var svr = unity.GetInstance<IProductService>();
            var attrSvr = unity.GetInstance<IAttributeService>();
            var productAttrSvr = unity.GetInstance<IProductAttrService>();

            attrSvr.GetList(new Model.Attribute.Query { Pid = 2, Recommend = 1, Level = 2, Status = 1 });

            var pagestart = Request.QueryString[this.paging.UrlPageIndexName].TryParseToInt32(1);
            var pagesize = this.paging.PageSize;

            var data = svr.GetPagedWithAttr(new Core.PagedQuery<Model.Product.Query>
            {
                PageStart = pagestart,
                PageSize = pagesize,
                Filter = new Model.Product.Query { Status = 1, Cat_Id = cat.TryParseToString(null), Keyword = key, Type = 3 }
            });

            var recommends = svr.GetListWithAttr(new Product.Query
            {
                Status = 1,
                Best = 1
            }, 2);

            rptRecommend.DataSource = recommends;
            rptRecommend.DataBind();

            this.paging.RecordCount = data.RecordsTotal;
            this.paging.CurrentPageIndex = pagestart;
            rptTmalls.DataSource = data.Records;

            rptTmalls.DataBind();
        }
    }
}