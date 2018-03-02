using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Model;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web.users
{
    public partial class QiugouSubmit : UserPage
    {
        public Buy Model;

        protected void Page_Load(object sender, EventArgs e)
        {

            var id = Request.QueryString["id"].TryParseToInt32(0);

            var buySvr = unity.GetInstance<IBuyService>();

            if (id > 0)
            {
                Model = buySvr.GetBuy(id);
            }

            if ("POST".Equals(Request.RequestType.ToUpper()))
            {
                if (id > 0)
                {
                    Model.Id = id;
                    Model.Title = Request.Form["title"];
                    Model.Brief = Request.Form["brief"];
                    Model.Start_Price = Request.Form["start_price"].TryParseToDecimal(0);
                    Model.End_Price = Request.Form["end_price"].TryParseToDecimal(0);
                    //Model.Is_Price = Request.Form["is_price"]; 
                    Model.Stocks = Request.Form["stocks"].TryParseToInt32(0);
                    //Model.Is_Stocks = Request.Form["is_stocks"]; 
                    //                   Model.ValidDay = Request.Form["validday"]; 
                    Model.Type = Request.Form["type"].TryParseToInt32(0);
                    Model.Cate_Id = Request.Form["cate_id"].TryParseToInt32(0);
                    Model.Level = Request.Form["level"].TryParseToInt32(0);
                    Model.Level_Child = Request.Form["level_child"].TryParseToInt32(0);
                    Model.Good_Rating = Request.Form["good_rating"].TryParseToDecimal(0);
                    Model.Rating = Request.Form["rating"].TryParseToDecimal(0);
                    Model.Created = Request.Form["created"].TryParseToInt32(0);
                    Model.Credentials = Request.Form["credentials"];
                    Model.User_Name = Request.Form["user_name"];
                    Model.Mobile = Request.Form["mobile"];
                    Model.Detail = "";
                    Model.Remark = "";
                    Model.Qq = Request.Form["qq"];
                    try
                    {
                        buySvr.Modify(Model);
                        ViewState["Message"] = "恭喜您，求购发布成功。";
                    }
                    catch (ApplicationException ex)
                    {
                        ViewState["Message"] = ex.Message;
                    }
                    catch
                    {
                        ViewState["Message"] = "系统异常";
                    }

                }
                else
                {
                    Model = new Buy();

                    Model.Title = Request.Form["title"];
                    Model.Brief = Request.Form["brief"];
                    Model.Start_Price = Request.Form["start_price"].TryParseToDecimal(0);
                    Model.End_Price = Request.Form["end_price"].TryParseToDecimal(0);
                    //Model.Is_Price = Request.Form["is_price"]; 
                    Model.Stocks = Request.Form["stocks"].TryParseToInt32(0);
                    //Model.Is_Stocks = Request.Form["is_stocks"]; 
                    //                   Model.ValidDay = Request.Form["validday"]; 
                    Model.Type = Request.Form["type"].TryParseToInt32(0);
                    Model.Cate_Id = Request.Form["cate_id"].TryParseToInt32(0);
                    Model.Level = Request.Form["level"].TryParseToInt32(0);
                    Model.Level_Child = Request.Form["level_child"].TryParseToInt32(0);
                    Model.Good_Rating = Request.Form["good_rating"].TryParseToDecimal(0);
                    Model.Rating = Request.Form["rating"].TryParseToDecimal(0);
                    Model.Created = Request.Form["created"].TryParseToInt32(0);
                    Model.Credentials = Request.Form["credentials"] ?? string.Empty;
                    Model.User_Name = Request.Form["user_name"];
                    Model.Mobile = Request.Form["mobile"];
                    Model.Detail = "";
                    Model.Remark = "";
                    Model.Qq = "";

                    try
                    {
                        buySvr.Add(Model);
                        ViewState["Message"] = "恭喜您，求购发布成功。";
                    }
                    catch (ApplicationException ex)
                    {
                        ViewState["Message"] = ex.Message;
                    }
                    catch
                    {
                        ViewState["Message"] = "系统异常";
                    }
                }


            }
        }
    }
}