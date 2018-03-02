using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Wuyiju.Model
{
    public class ProductFrontend : Product
    {

        public ProductFrontend() { }

        public ProductFrontend(Product product)
        {
            base.Id = product.Id;
            base.Admin_Id = product.Admin_Id;
            base.Name = product.Name;
            base.Subname = product.Subname;
            base.Sn = product.Sn;
            base.Category_Id = product.Category_Id;
            base.Category_Name = product.Category_Name;
            base.Market_Price = product.Market_Price;
            base.Price = product.Price;
            base.Member_Price = product.Member_Price;
            base.Promote_Price = product.Promote_Price;
            base.Intro = product.Intro;
            base.Integration = product.Integration;
            base.Integration_Buy = product.Integration_Buy;
            base.Promote = product.Promote;
            base.Promote_Start = product.Promote_Start;
            base.Promote_End = product.Promote_End;
            base.Recommend = product.Recommend;
            base.Click = product.Click;
            base.Stock = product.Stock;
            base.Pay_Status = product.Pay_Status;
            base.Warn_Nums = product.Warn_Nums;
            base.Sales = product.Sales;
            base.Status = product.Status;
            base.Hot = product.Hot;
            base.New = product.New;
            base.Best = product.Best;
            base.Sort = product.Sort;
            base.Keywords = product.Keywords;
            base.Seo_Title = product.Seo_Title;
            base.Seo_Keys = product.Seo_Keys;
            base.Seo_Desc = product.Seo_Desc;
            base.Brief = product.Brief;
            base.Content = product.Content;
            base.Url = product.Url;
            base.Address_Id = product.Address_Id;
            base.Buyer_Id = product.Buyer_Id;
            base.Add_Time = product.Add_Time;
            base.Start_Time = product.Start_Time;
            base.Picture = product.Picture;
            base.Log = product.Log;
            base.Del_Time = product.Del_Time;
            base.Filename = product.Filename;
            base.Seller_Id = product.Seller_Id;
            base.User_Return = product.User_Return;
            base.Type = product.Type;
            base.Video = product.Video;
            base.Praise_Rate = product.Praise_Rate;
            base.Collection_Popularity = product.Collection_Popularity;
            base.Seller_Credit = product.Seller_Credit;
            base.Annual_Turnover = product.Annual_Turnover;
            base.Protection_Deposit = product.Protection_Deposit;
            base.Tech_Fee = product.Tech_Fee;
            base.Whether_Goods = product.Whether_Goods;
            base.Buyer_Protection = product.Buyer_Protection;
            base.Virtual_Proportion = product.Virtual_Proportion;
            base.Old_Customer_Number = product.Old_Customer_Number;
            base.Area = product.Area;
            base.Mall_Type = product.Mall_Type;
            base.Trademark_Type = product.Trademark_Type;
            base.Trademark_No = product.Trademark_No;
            base.Tax_Qualification = product.Tax_Qualification;
            base.Guanlian_Id = product.Guanlian_Id;
            base.Score = product.Score;
            base.Company_Level = product.Company_Level;
            base.Smallarea = product.Smallarea;
            base.Weiscore = product.Weiscore;
            base.QQ = product.QQ;
        }

        

        public IList<ProductAttr> Attrs { get; set; }

        public Dictionary<int, string> AttrMap { get; set; }

        public decimal Discount
        {
            get
            {
                return this.Market_Price == 0 ? 0 : this.Price / this.Market_Price * 10m;
            }
        }


        public UserConsignee UserConsignee { get; set; }


        public static string GetAttrValue(int attrid, object productAttrs)
        {
            IList<ProductAttr> attrs = (IList<ProductAttr>)productAttrs;
            if (attrs != null && attrs.Count > 0)
            {
                var lst = attrs.Where(d => d.Attr_Id == attrid).ToList();
                if (lst.Count == 1)
                {
                    return lst[0].Attr_Value;
                }
                else if (lst.Count > 1)
                {
                    var results = new StringBuilder();
                    foreach (var obj in lst)
                    {
                        results.Append(obj.Attr_Value + " ");
                    }

                    return results.ToString();
                }
            }

            return string.Empty;
        }
    }
}
