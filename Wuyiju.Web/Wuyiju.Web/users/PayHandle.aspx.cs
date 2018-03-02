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
    public partial class PayHandle : UserPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ("POST".Equals(Request.RequestType.ToUpper()))
            {
                var orderSvr = unity.GetInstance<IOrderService>();

                var userService = unity.GetInstance<IUserService>();

                var productService = unity.GetInstance<IProductService>();

                var sn = Request.Form["sn"];

                var order = orderSvr.GetOrder(sn);



                if (order == null)
                {
                    ViewState["Error"] = "订单不存在";
                    Response.End();
                }

                if (order.Uid != LoggedUser.Id || order.Uid == 0)
                {
                    ViewState["Error"] = "非法操作";
                }
                else
                {

                    var seller = userService.GetUser(order.Seller_Id);


                    var paypass = Request.Form["pwd"];
                    var payway = Request.Form["payfang"].TryParseToInt32(-1);

                    try
                    {

                        orderSvr.PayOrder(order, payway, paypass);
                        ViewState["Message"] = "付款成功";

                        var sms = new SmsHelper();

                        //sms.SendText(order.Sell_Phone ,"您的店铺已经出售成功");

                        //var payedOrder = orderSvr.GetOrder(order.Id);

                        //payedOrder.Send_Mail = 1;
                        //orderSvr.Modify(payedOrder);


                        var product = productService.GetProduct(order.Product_Id);
                        sms.SendOrder(order.Sell_Phone, product.Subname, order.Sn);


                    }
                    catch (ApplicationException ex)
                    {
                        ViewState["Error"] = ex.Message;
                    }
                }
            }
        }
    }
}