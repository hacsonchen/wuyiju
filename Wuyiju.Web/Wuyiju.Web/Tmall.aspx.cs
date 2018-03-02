using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.Core;
using Wuyiju.IService;
using Wuyiju.Model;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web
{
    public partial class Tmall : BasePage
    {
        public string MainKefu;

        public IList<ProductAttr> Attributes;

        public IList<KeyValuePair<string, string>> param;

        public string HasCat = null;
        public string HasMallType = null;
        public string HasTM = null;
        public string HasLevel = null;
        public string HasPrice = null;
        public string HasArea = null;
        public string HasKey = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            var adminService = unity.GetInstance<IAdminService>();
            var kefuList = adminService.GetList(new Admin.Query { IsKefu = 1 });

            MainKefu = Page.Application["qqkefu1"].TryParseToString(string.Empty);

            if (kefuList != null && kefuList.Count > 0)
            {
                Random ran = new Random(unchecked((int)DateTime.Now.Ticks));
                int RandKey = ran.Next(0, kefuList.Count - 1);
                MainKefu = kefuList[RandKey].Qq;
            }

            var svr = unity.GetInstance<IProductService>();
            var attrSvr = unity.GetInstance<IAttributeService>();
            var productAttrSvr = unity.GetInstance<IProductAttrService>();

            var attrs = new List<KeyValuePair<int, string>>();
            
            var query = new Model.Product.Query { Status = 1 , Type = 2, Attrs = attrs };


            #region 参数处理

            var cat = Request.QueryString["c"];
            var key = Request.QueryString["q"];
            var mallType = Request.QueryString["t"].TryParseToInt32(0);
            var tm = Request.QueryString["m"];
            var tm2 = Request.QueryString["m2"];
            var qLevel = Request.QueryString["l"];
            var qPrice = Request.QueryString["d"];
            var qSort = Request.QueryString["s"];
            var qArea = Request.QueryString["a"];
            var qComType = Request.QueryString["ct"];
            var qChannel = Request.QueryString["new"].TryParseToInt32(0);

            var qSell = Request.QueryString["sell"].TryParseToInt32(0);

            if (qSell > 0)
            {
                query.Admin_Id = qSell;
            }

            if (!string.IsNullOrWhiteSpace(qComType))
            {
                query.Company_Level = qComType.TryParseToInt32(0);
            }

            
            param = new List<KeyValuePair<string, string>>();

            

            #region 行业分类
            if (!cat.IsNullOrWhiteSpace())
            {
                param.Add(new KeyValuePair<string, string>("c", cat));

                query.Cat_Id = cat;

                var catSvr = unity.GetInstance<ICategoryService>();

                var nav = catSvr.GetCategory(cat.TryParseToInt32());
                if (nav != null)
                    HasCat = nav.Name;
            }
            #endregion

            #region  商城类型
            if (mallType > 0)
            {
                param.Add(new KeyValuePair<string, string>("t", mallType.ToString()));

                if (mallType == 27)
                    query.MallType = 1;
                else if (mallType == 28)
                    query.MallType = 2;
                else if (mallType == 29)
                    query.MallType = 3;

                var nav = attrSvr.GetAttribute(mallType);
                if (nav != null)
                    HasMallType = nav.Name;
            }
            #endregion

            #region 商标类型
            if (!tm.IsNullOrWhiteSpace())
            {
                param.Add(new KeyValuePair<string, string>("m", tm.ToString()));

                if (tm.TryParseToInt32(0) == 31)
                    query.TradeMark_Type = 1;
                else if (tm.TryParseToInt32(0) == 32)
                    query.TradeMark_Type = 2;

                var nav = attrSvr.GetAttribute(tm.TryParseToInt32(0));
                if (nav != null)
                    HasTM = nav.Name;
            }

            if (!tm2.IsNullOrWhiteSpace())
            {
                param.Add(new KeyValuePair<string, string>("m2", tm2.ToString()));

                attrs.Add(new KeyValuePair<int, string>(290, tm2));

            }
            #endregion

            if (!qLevel.IsNullOrWhiteSpace())
            {
                param.Add(new KeyValuePair<string, string>("l", qLevel.ToString()));

                attrs.Add(new KeyValuePair<int, string>(33, qLevel));

                var nav = attrSvr.GetAttribute(qLevel.TryParseToInt32(0));
                if (nav != null)
                    HasLevel = nav.Name;
            }
            #region 价格处理
            if (!qPrice.IsNullOrWhiteSpace())
            {
                param.Add(new KeyValuePair<string, string>("d", qPrice.ToString()));

                var priceType = qPrice.TryParseToInt32(0);

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
            #endregion

            if (!key.IsNullOrWhiteSpace())
            {
                param.Add(new KeyValuePair<string, string>("q", key));
                query.Keyword = key;
                HasKey = key;

                //名称公开店铺
                if (qChannel == 2)
                {
                    //query.Recommend = 1;
                    query.Whether_Goods = 1;
                    query.EndDate = null;
                    param.Add(new KeyValuePair<string, string>("new", qChannel.ToString()));
                }

            }
            else
            {
                //全新店铺
                if (qChannel == 1)
                {
                    //query.New = 1;
                    var now = new DateTime(DateTime.Now.Year, 1, 1);
                    param.Add(new KeyValuePair<string, string>("new", qChannel.ToString()));
                    query.StartDate = now;
                }
                else
                {
                    query.EndDate = new DateTime(DateTime.Now.Year, 1, 1);
                }

                //名称公开店铺
                if (qChannel == 2)
                {
                    //query.Recommend = 1;
                    query.Whether_Goods = 1;
                    query.EndDate = null;
                    param.Add(new KeyValuePair<string, string>("new", qChannel.ToString()));
                }
            }


            #region 
            if (!qArea.IsNullOrWhiteSpace())
            {
                param.Add(new KeyValuePair<string, string>("a", cat));

                query.Area = qArea;

                HasArea = qArea;
            }
            #endregion

            Page.Title = Page.Title + " " + HasArea + " " + HasCat + " " + HasMallType + " " + HasTM + " " + HasPrice + " " + HasKey + " " + HasLevel;
            Page.MetaDescription = Page.Title;


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
                    //orderRule.Add(new OrderRule { Column = "v.sort", dir = "desc" });
                    orderRule.Add(new OrderRule { Column = "v.add_time", dir = "desc" });
                    orderRule.Add(new OrderRule { Column = "v.id", dir = "asc" });
                }

            }
            else
            {
                orderRule.Add(new OrderRule { Column = "v.add_time", dir = "desc" });
                orderRule.Add(new OrderRule { Column = "v.id", dir = "asc" });
            }
           

            #endregion

            #region 网店列表
            var pagestart = Request.QueryString[this.paging.UrlPageIndexName].TryParseToInt32(1);
            var pagesize = this.paging.PageSize;

            var data = svr.GetPagedWithAttr(new Core.PagedQuery<Model.Product.Query>
            {
                PageStart = pagestart,
                PageSize = pagesize,
                Filter = query,
                Order = orderRule
            });

            this.paging.RecordCount = data.RecordsTotal;
            this.paging.CurrentPageIndex = pagestart;

            rptTmalls.DataSource = data.Records;
            rptTmalls.DataBind();
            #endregion

            #region 精选网店
            var recommends = svr.GetListWithAttr(new Product.Query
            {
                Status = 1,
                Best = 1
            }, 2);

            //rptRecommend.DataSource = recommends;
            //rptRecommend.DataBind();
            #endregion
        }
    }
}