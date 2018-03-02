using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.Core;
using Wuyiju.IService;
using Wuyiju.Model;

namespace Wuyiju.Web.users
{
    public partial class ShopsTransferSubmit : Utils.UserPage
    {
        public IList<Model.Attribute> attributes;
        public int ShopId = 0;

        public string Message;

        protected void Page_Load(object sender, EventArgs e)
        {
            ShopId = Request.QueryString["pid"].TryParseToInt32(0);

            if (Page.IsPostBack)
                return;

            var unity = new UnityContext();
            var svr = unity.GetInstance<IAttributeService>();
            attributes = svr.GetList(new Model.Attribute.Query { Status = 1 });


            if ("GET".Equals(Request.RequestType))
            {
                
            }
            else if ("POST".Equals(Request.RequestType))
            {

                var productService = unity.GetInstance<IProductService>();

                var shop = new ProductFrontend();

                shop.Type = Request.Form["type"].TryParseToInt32();
                //shop.Status = Request.Form["status"].TryParseToInt32();
                shop.Name = Request.Form["spTitle"].TryParseToString();
                shop.Brief = Request.Form["spBrief"].TryParseToString();
                shop.Url = Request.Form["spUrl"].TryParseToString();
                shop.Subname = Request.Form["spAdmin"].TryParseToString();
                shop.Start_Time = Request.Form["shopHours"].TryParseToInt32(0);
                shop.Price = Request.Form["shopsPrice"].TryParseToDecimal();
                shop.Category_Id = Request.Form["category_id"].TryParseToInt32(0);
                shop.Area = Request.Form["area"].TryParseToString();
                
                var attrs = Request.Form.GetValues("attr[]");



                var productAttrs = new List<ProductAttr>();



                //处理Input=1
                foreach (var attr in attrs)
                {
                    var strAry = attr.Split('_');

                    if(strAry.Count() != 3)
                        continue;

                    var productAttr = new ProductAttr();
                    productAttr.Attr_Pid = ShopId;
                    productAttr.Attr_Value = strAry[2];
                    productAttr.Attr_Id = strAry[1].TryParseToInt32();
                    productAttr.Input = strAry[0].TryParseToInt32();

                    productAttrs.Add(productAttr);

                }

                //处理Input=2,3
                foreach (var attr in attributes.Where(d => d.Pid == ShopId).ToList())
                {
                    if (attr.Input == 2 || attr.Input == 3)
                    {

                        var attrValues = Request.Form.GetValues(string.Format("input[{0}][{1}][]", attr.Input, attr.Id));

                        if (attrValues != null)
                        {
                            foreach (var attrVal in attrValues)
                            {
                                var productAttr = new ProductAttr();
                                productAttr.Attr_Pid = ShopId;
                                productAttr.Attr_Value = attrVal;
                                productAttr.Attr_Id = attr.Id;
                                productAttr.Input = attr.Input;

                                productAttrs.Add(productAttr);
                            }
                        }
                    }
                }

                //shop = Request.Form["input"];
                // shop. = Request.Form["attr_id"];
                shop.Address_Id = Request.Form["address_id"].TryParseToInt32(0);

                var user = new UserConsignee();
                user.User_Id = LoggedUser.Id;
                user.Consignee = Request.Form["utruename"] ?? "";
                user.Mobile = Request.Form["umobile"] ?? "";
                user.Phone = Request.Form["utel"] ?? "";
                user.Qq = Request.Form["uqq"] ?? "";
                user.Address = "";
                user.Zip = "";
                user.Email = "";
                user.Fax = "";
                user.Is_Def = 1;
                user.Region_Values = "";

                shop.Content = "";
                shop.Filename = "";
                shop.Video = "";
                shop.Buyer_Protection = "";
                shop.Mobile = LoggedUser.Mobile;
                 

                shop.UserConsignee = user;
                shop.Attrs = productAttrs;

                shop.Admin_Id = 1;
                shop.Guanlian_Id = 1;
                shop.Seller_Id = LoggedUser.Id;

                productService.Add(shop);
                ViewState["Message"] = "发布网店成功";
            }
        }
    }
}