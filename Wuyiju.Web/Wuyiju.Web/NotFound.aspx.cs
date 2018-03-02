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
    public partial class NotFound : UserPage
    {
        public Buy Model;

        protected void Page_Load(object sender, EventArgs e)
        {


            if ("POST".Equals(Request.RequestType.ToUpper()))
            {
                var buySvr = unity.GetInstance<IBuyService>();
                Model = new Buy();

                Model.Title = "暂未找到心仪网店";
                Model.Brief = Request.Form["content"];
                Model.Start_Price = Request.Form["start_price"].TryParseToDecimal(0);
                Model.End_Price = Request.Form["end_price"].TryParseToDecimal(0);
                //Model.Is_Price = Request.Form["is_price"]; 
                Model.Stocks = 1;
                //Model.Is_Stocks = Request.Form["is_stocks"]; 
                //                   Model.ValidDay = Request.Form["validday"]; 
                Model.Type = Request.Form["type"].TryParseToInt32(1);
                Model.Cate_Id = Request.Form["cate_id"].TryParseToInt32(1);
                Model.Level = Request.Form["level"].TryParseToInt32(1);
                Model.Level_Child = Request.Form["level_child"].TryParseToInt32(1);
                Model.Good_Rating = Request.Form["good_rating"].TryParseToDecimal(1);
                Model.Rating = Request.Form["rating"].TryParseToDecimal(1);
                Model.Created = Request.Form["created"].TryParseToInt32(1);
                Model.Credentials = Request.Form["credentials"] ?? string.Empty;
                Model.User_Name = "匿名";
                Model.Mobile = "无";
                Model.Detail = Model.Title;
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