using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wuyiju.Web.Malls
{
    public partial class AddSesList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var result = 0;

            if ("POST".Equals(Request.RequestType))
            {


                var product_id = Request.Form["product_id"].TryParseToInt32(0);

                var max = 10;
                if (product_id > 0)
                {
                    var seslists = Request.Cookies["__WYJ_SHOP__"];

                    if (seslists == null)
                    {
                        seslists = new HttpCookie("__WYJ_SHOP__");
                        Request.Cookies.Add(seslists);
                    }

                    var str = seslists.Values["seslists"];

                    IList<string> tem;
                    if (!str.IsNullOrWhiteSpace())
                    {
                        tem = str.Split(',').ToList();
                    }

                    tem = new List<string>();

                    if (tem != null && !tem.Contains(product_id.ToString()))
                    {
                        tem.Add(product_id.ToString());
                    }

                    if (tem.Count > max)
                    {
                        for (int i = 0; i < (tem.Count - max); i++)
                            tem.RemoveAt(i);
                    }


                    seslists.Values["seslists"] = string.Join(",", tem.ToArray());

                    seslists.HttpOnly = true;

                    seslists.Expires = DateTime.Now.AddDays(1);
         

                    Response.AppendCookie(seslists);

                    result = 1;
                    var json = new { result = 1, message = "SUCCESS" };
                    Response.Write(json.SerializeToJson());
                    Response.End();
                }

                var error = new { result = 0, message = "SUCCESS" };
                Response.Write(error.SerializeToJson());
                Response.End();


            }


        }
    }
}