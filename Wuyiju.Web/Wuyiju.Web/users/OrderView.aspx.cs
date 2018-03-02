using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Model;

namespace Wuyiju.Web.users
{
    public partial class OrderView : Utils.UserPage
    {
        public Product Model;
        public Order Order;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoggedState.Refresh();
            var qid = Request.QueryString["id"];

            if (qid == null)
            {
                Response.Write("非法操作");
            }

            var orderSvr = unity.GetInstance<IOrderService>();

            var productSvr = unity.GetInstance<IProductService>();

            Order = orderSvr.GetOrder(qid.TryParseToInt32());

            if (Order != null)
            {
                Model = productSvr.GetProduct(Order.Product_Id);
            }

            if (Model == null)
            {
                Response.Write("商品已经删除或者下架了");
            }


        }
    }
}