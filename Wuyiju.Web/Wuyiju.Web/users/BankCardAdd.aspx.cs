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
    public partial class BankCardAdd : UserPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ("POST".Equals(Request.RequestType.ToUpper()))
            {
                var svr = unity.GetInstance<IDepositBankCardService>();

                var card = new DepositBankCard();

                card.Region_Lv2 = Request.Form["khp2"].TryParseToInt32(-1);
                card.Region_Lv3 = Request.Form["khc2"].TryParseToInt32(-1);
                card.Bank_Name = Request.Form["khh2"];
                card.Bank_Subname = Request.Form["zhshow"];
                card.Card_Number = Request.Form["khk2"];
                card.User_Id = LoggedUser.Id;
                card.Real_Name = LoggedUser.Realname;

                try
                {
                    svr.Add(card);
                    Response.Redirect("/Users/Takecash.aspx");

                    if (card.Real_Name.IsNullOrWhiteSpace())
                        throw new ApplicationException("请完善实名信息");
                }
                catch (ApplicationException ex)
                {
                    Response.Redirect(string.Format("/Users/Takecash.aspx?error={0}",ex.Message.UrlEncode()));
                }
            }
        }
    }
}