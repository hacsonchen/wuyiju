using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.Core;
using Wuyiju.IService;
using Wuyiju.Model;

namespace Wuyiju.Web
{
    public partial class Taobao : BasePage
    {
        public IList<ProductAttr> Attributes;

        public IList<KeyValuePair<string, string>> param;

        public string HasCat = null;
        public string HasLevel = null;
        public string HasPrice = null;
        protected void Page_Load(object sender, EventArgs e)
        {


            var svr = unity.GetInstance<IProductService>();
            var attrSvr = unity.GetInstance<IAttributeService>();
            var productAttrSvr = unity.GetInstance<IProductAttrService>();

            var attrs = new List<KeyValuePair<int, string>>();

            var query = new Model.Product.Query { Status = 1, Type = 1, Attrs = attrs };


            #region 参数处理

            var cat = Request.QueryString["c"];
            var key = Request.QueryString["q"];
            var qLevel = Request.QueryString["l"];
            var qPrice = Request.QueryString["d"];
            var qSort = Request.QueryString["s"];

            param = new List<KeyValuePair<string, string>>();

            if (!cat.IsNullOrWhiteSpace())
            {
                param.Add(new KeyValuePair<string, string>("c", cat));

                query.Cat_Id = cat;

                var catSvr = unity.GetInstance<ICategoryService>();

                var nav = catSvr.GetCategory(cat.TryParseToInt32());
                if (nav != null)
                    HasCat = nav.Name;
            }


            if (!qLevel.IsNullOrWhiteSpace())
            {
                param.Add(new KeyValuePair<string, string>("l", qLevel.ToString()));

                attrs.Add(new KeyValuePair<int, string>(3, qLevel));

                var nav = attrSvr.GetAttribute(qLevel.TryParseToInt32(0));
                if (nav != null)
                    HasLevel = nav.Name;
            }

            if (!qPrice.IsNullOrWhiteSpace())
            {
                param.Add(new KeyValuePair<string, string>("d", qPrice.ToString()));

                var priceType = qPrice.TryParseToInt32();

                if (priceType == 20)
                {
                    query.StartPrice = 1000;
                    query.EndPrice = 10000;
                }
                else if (priceType == 21)
                {
                    query.StartPrice = 10000;
                    query.EndPrice = 50000;
                }
                else if (priceType == 22)
                {
                    query.StartPrice = 50000;
                    query.EndPrice = 100000;
                }
                else if (priceType == 23)
                {
                    query.StartPrice = 100000;
                    query.EndPrice = 200000;
                }
                else if (priceType == 24)
                {
                    query.StartPrice = 200000;
                    query.EndPrice = 500000;
                }
                else if (priceType == 25)
                {
                    query.StartPrice = 500000;
                }

                var nav = attrSvr.GetAttribute(qPrice.TryParseToInt32(0));
                if (nav != null)
                    HasPrice = nav.Name;
            }

            if (!key.IsNullOrWhiteSpace())
                param.Add(new KeyValuePair<string, string>("q", key));


            #endregion

            #region 排序

            var orderRule = new List<OrderRule>();

            if (!qSort.IsNullOrWhiteSpace())
            {
                var sortType = qSort.TryParseToInt32(0);

                if (sortType == 1)
                {
                    orderRule.Add(new OrderRule { Column = "v.add_time", dir = "desc" });
                    orderRule.Add(new OrderRule { Column = "v.sort", dir = "desc" });
                    orderRule.Add(new OrderRule { Column = "v.id", dir = "asc" });
                }
                else if (sortType == 2)
                {
                    orderRule.Add(new OrderRule { Column = "v.price", dir = "asc" });
                    orderRule.Add(new OrderRule { Column = "v.sort", dir = "desc" });
                    orderRule.Add(new OrderRule { Column = "v.id", dir = "asc" });
                }
                else if (sortType == 3)
                {
                    orderRule.Add(new OrderRule { Column = "v.click", dir = "desc" });
                    orderRule.Add(new OrderRule { Column = "v.sort", dir = "desc" });
                    orderRule.Add(new OrderRule { Column = "v.id", dir = "asc" });
                }
                else if (sortType == 4)
                {
                    orderRule.Add(new OrderRule { Column = "v.price", dir = "desc" });
                    orderRule.Add(new OrderRule { Column = "v.sort", dir = "desc" });
                    orderRule.Add(new OrderRule { Column = "v.id", dir = "asc" });
                }
                else if (sortType == 5)
                {
                    orderRule.Add(new OrderRule { Column = "v.click", dir = "asc" });
                    orderRule.Add(new OrderRule { Column = "v.sort", dir = "desc" });
                    orderRule.Add(new OrderRule { Column = "v.id", dir = "asc" });
                }
                if (sortType == 6)
                {
                    orderRule.Add(new OrderRule { Column = "v.add_time", dir = "asc" });
                    orderRule.Add(new OrderRule { Column = "v.sort", dir = "desc" });
                    orderRule.Add(new OrderRule { Column = "v.id", dir = "asc" });
                }
                else
                {
                    orderRule.Add(new OrderRule { Column = "v.sort", dir = "desc" });
                    orderRule.Add(new OrderRule { Column = "v.id", dir = "asc" });
                }

            }


            #endregion

            attrSvr.GetList(new Model.Attribute.Query { Pid = 2, Recommend = 1, Level = 2, Status = 1 });

            var pagestart = Request.QueryString[this.paging.UrlPageIndexName].TryParseToInt32(1);
            var pagesize = this.paging.PageSize;

            var data = svr.GetPagedWithAttr(new Core.PagedQuery<Model.Product.Query>
            {
                PageStart = pagestart,
                PageSize = pagesize,
                Filter = query
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