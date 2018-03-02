using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;

namespace Wuyiju.Web.Malls
{
    public partial class AddLikeShop : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.Form["id"];

            if (id.IsNullOrWhiteSpace())
            {
                Response.Write("网店已经下架");
                Response.End();
            }

            var productService = unity.GetInstance<IProductService>();

            var product = productService.GetProduct(id.TryParseToInt32(0));

            if (product == null)
            {
                Response.Write("此网店已经下架了");
                Response.End();
            }

            try
            {
                

                product.Click += 1;

                productService.Modify(product);
                
            } catch
            {
                Response.Write("网络繁忙，请稍候再试");
                Response.End();
            }

            Response.Write(product.Click);
            Response.End();
        }
    }
}