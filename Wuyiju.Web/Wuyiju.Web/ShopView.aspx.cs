using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Model;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web
{
    public partial class ShopView : UserPage
    {
        public ProductFrontend Model;
        public Admin Admin = new Admin();
        public Admin TeamMaster = new Admin();
        public Admin Manager = new Admin();
        public User Seller;
        public IList<string> ProductImgs;

       
        protected override void OnPreLoad(EventArgs e)
        {
        }


        protected override void OnLoad(EventArgs e)
        {

            var shopId = Request.QueryString["id"];
            if (shopId.IsNullOrEmpty())
                Response.Redirect("/");

            var productServcie = unity.GetInstance<IProductService>();
            Model = productServcie.GetProductWithAttr(shopId.TryParseToInt32());

            Page.Title = Model.Name;

            if (Model.IsNull() || Model.Status != 1)
                Response.Redirect("/");

            var adminService = unity.GetInstance<IAdminService>();
            var userService = unity.GetInstance<IUserService>();

            Admin = adminService.GetAdmin(Model.Admin_Id);
            if (Admin != null)
            {
                TeamMaster = adminService.GetAdmin(Admin.Parent_Id);
                if (TeamMaster != null)
                {
                    Manager = adminService.GetAdmin(TeamMaster.Parent_Id);
                }
            }

            Seller = userService.GetUser(Model.Seller_Id);

            if (!Model.Picture.IsNullOrWhiteSpace())
            {
               var images =  Model.Picture.Split(',');
                IList<string> imgs = new List<string>();

                if (images != null)
                {
                    foreach (var img in images)
                    {
                        if (!img.IsNullOrWhiteSpace())
                            imgs.Add(img);
                    }
                }

                ProductImgs = imgs;
                
                ProductImages.DataSource = imgs;
                ProductImages.DataBind();
            }

            rptAttrs.DataSource = Model.Attrs;
            rptAttrs.DataBind();

            rptKeywords.DataSource = Model.Keywords.IsNullOrWhiteSpace() ? null: Model.Keywords.Split('/') ;
            rptKeywords.DataBind();

            rptSimilar1.DataSource =  productServcie.GetList(new Product.Query { Cat_Id = Model.Category_Id.ToString(), Status = 1 }, 3);
            rptSimilar1.DataBind();

            rptSimilar2.DataSource = productServcie.GetList(new Product.Query { Cat_Id = Model.Category_Id.ToString(), Status = 1 }, 4);
            rptSimilar2.DataBind();
        }
    }
}