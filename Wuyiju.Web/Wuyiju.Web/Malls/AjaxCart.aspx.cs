using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;

namespace Wuyiju.Web.Malls
{
    public partial class AjaxCart : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ("POST".Equals(Request.RequestType.ToUpper()))
            {
                var seslists = Request.Cookies["__WYJ_SHOP__"];

                if (!seslists.IsNull() && !seslists.Values["seslists"].IsNullOrWhiteSpace())
                {
                    var ids = seslists.Values["seslists"].Split(',');

                    if (ids != null)
                    {
                        var svr = unity.GetInstance<IProductService>();
                        var lst = new List<Model.Product>();
                        foreach (var id in ids)
                        {
                           var item = svr.GetProduct(id.TryParseToInt32(0));
                            if (item != null)
                                lst.Add(item);
                        }

                        var card_list = lst.Select(d => new {
                            id = d.Id,
                            name = d.Name,
                            price = d.Price ,
                            area = d.Area,
                            url = string.Format("/ShopView.aspx?id={0}",d.Id)
                        });

                        var json = new { count = card_list.Count(), cart = card_list };

                        Response.Write(json.SerializeToJson());
                        Response.End();

                    }

                }
            }
        }
    }
}