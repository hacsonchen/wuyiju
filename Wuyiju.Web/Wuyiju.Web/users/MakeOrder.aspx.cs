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
    public partial class MakeOrder : Utils.UserPage
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

            Model = productSvr.GetProduct(qid.TryParseToInt32());

            


            var exists = orderSvr.GetList(new Order.Query { Product_Id = qid.TryParseToInt32(0), Uid = LoggedUser.Id });

            if (exists != null && exists.Count > 0 )
            {
                ViewState["Message"] = "您的订单已存在此网店无需再添加";
                Response.Redirect("/Users/BoughtList.aspx?Message=" + "您的订单已存在此网店无需再添加".UrlEncode());
            }
            else {
                Order = orderSvr.MakeOrder(Model, LoggedUser.Id);


            }


        }
    }
}