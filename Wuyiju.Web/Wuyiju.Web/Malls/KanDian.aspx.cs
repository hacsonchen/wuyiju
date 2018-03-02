using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Model;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web.Malls
{
    public partial class KanDian : UserPage
    {
        private Product product;
        protected void Page_Load(object sender, EventArgs e)
        {
            var productService = unity.GetInstance<IProductService>();

            var userService = unity.GetInstance<IUserService>();

            var id = Request.QueryString["id"].TryParseToInt32(0);

            LoggedState.Refresh();

            if (LoggedUser.Rank_Points < 1)
            {
                var error = new { result = "error", msg = "没有足够的看店卡" };
                Response.Write(error.SerializeToJson());
                Response.End();
            }

            try
            {
                product = productService.GetProduct(id);



                LoggedUser.Rank_Points = LoggedUser.Rank_Points - 1;
                userService.Modify(LoggedUser);
            }
            catch
            {
                var excetions = new { result = "error", msg = "网络异常请稍候再试" };

                Response.Write(excetions.SerializeToJson());
                Response.End();
            }

            if (product.Name.Contains("官"))
            {
                var json = new { result = "success", TM = product.TrademarkType, Contact = product.Seller_Phone, Url = product.Url, ShopDesc = "" };

                Response.Write(json.SerializeToJson());
                Response.End();
            }
            else {

                var excetions = new { result = "error", msg = "无法查看此类店铺,详情请咨询客服" };

                Response.Write(excetions.SerializeToJson());
                Response.End();
            }
        }
    }
}