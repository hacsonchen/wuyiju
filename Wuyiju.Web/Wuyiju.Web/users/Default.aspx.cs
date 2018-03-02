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
    public partial class Default : UserPage
    {
        public int SellingCount = 0;
        public int BoughtCount = 0;

        public int SellingAuditCount = 0;
        public int SellingTradeCount = 0;

        public int BoughtDFCount = 0;
        public int BoughtYFDJCount = 0;
        public int BoughtYFQECount = 0;
        public int BoughtTKCount = 0;

        protected override void OnLoad(EventArgs e)
        {
            LoggedState.Refresh();
            var productService = unity.GetInstance<IProductService>();
            var orderService = unity.GetInstance<IOrderService>();
            SellingCount = productService.GetCount(new Model.Product.Query { Seller_Id = LoggedUser.Id.ToString() });
            BoughtCount = orderService.GetCount(new Wuyiju.Model.Order.Query { Uid = LoggedUser.Id });

            SellingAuditCount = productService.GetCount(new Model.Product.Query { Seller_Id = LoggedUser.Id.ToString() , Status = 0 });

            SellingTradeCount = productService.GetCount(new Model.Product.Query { Seller_Id = LoggedUser.Id.ToString(), Status = 1 });

            BoughtDFCount = orderService.GetCount(new Wuyiju.Model.Order.Query { Uid = LoggedUser.Id, Pay_Status = 0 });
            BoughtYFDJCount = orderService.GetCount(new Wuyiju.Model.Order.Query { Uid = LoggedUser.Id, Pay_Status = 1 });
            BoughtYFQECount = orderService.GetCount(new Wuyiju.Model.Order.Query { Uid = LoggedUser.Id, Pay_Status = 2 });
            BoughtTKCount = orderService.GetCount(new Wuyiju.Model.Order.Query { Uid = LoggedUser.Id, Pay_Status = 4 });
        }
    }
}