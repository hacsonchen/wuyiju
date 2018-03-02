using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web.Malls
{
    public partial class AddFavorite : UserPage
    {
        protected override void OnPreLoad(EventArgs e)
        {
        }


        protected override void OnLoad(EventArgs e)
        {
            if (!LoggedState.IsLogged)
            {
                var error = new { result = -2,message = "没有登陆" };
                Response.Write(error.SerializeToJson());
                Response.End();
            }
            var productId = Request.Form["product_id"].TryParseToInt32(-1);
            var type = Request.Form["type"].TryParseToInt32(-1);
            var service = unity.GetInstance<IFavoritesService>();
            var results = service.GetList(new Model.Favorites.Query {  Product_Id = productId, User_Id = LoggedUser.Id, Type = type });

            if (results != null && results.Count > 0)
            {
                var already = new { result = -1, message = "已经加入收藏" };
                Response.Write(already.SerializeToJson());
                Response.End();
            }
            try
            {
                service.Add(new Model.Favorites { Add_Time = DateTime.Now.ToUnixTimestamp(), Type = type, Product_Id = productId, User_Id = LoggedUser.Id });
            }
            catch (Exception ex)
            {
                var error = new { result = -2, message = ex.Message };
                Response.Write(error.SerializeToJson());
                Response.End();
            }

            var success = new { result = 1 , message = "已经加入收藏" };
            Response.Write(success.SerializeToJson());
            Response.End();
        }
    }
}