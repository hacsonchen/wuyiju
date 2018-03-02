using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.Core;
using Wuyiju.IService;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web.users
{
    public partial class Takecash : UserPage
    {
        public int AddCount;

        protected void Page_Load(object sender, EventArgs e)
        {
            var cardService = unity.GetInstance<IDepositBankCardService>();
            var cashService = unity.GetInstance<IDepositTakecashService>();
            var rankService = unity.GetInstance<IUserRankService>();
            var myCards = cardService.GetList(new Model.DepositBankCard.Query { User_Id = LoggedUser.Id });

            AddCount = 5 - myCards.Count;

            rptCards.DataSource = myCards;
            rptCards.DataBind();

            if ("POST".Equals(Request.RequestType.ToUpper()))
            {
                var cash = new Model.DepositTakecash();
                cash.Bank_Card_Id = Request.Form["bank_card_id"].TryParseToInt32(-1);
                cash.Money = Request.Form["txmoney"].TryParseToDecimal(0);
                cash.User_Id = LoggedUser.Id;
                cash.User_Name = LoggedUser.Name;
                cash.Remark = "";
                var pay_pass = Request.Form["paypwd"];

                try
                {
                    cashService.Takecash(cash, pay_pass);
                    //因为提现会使用户金额发生改变所以要刷新当前登陆用户信息

                    LoggedState.Refresh();

                    rankService.UpdateUserRank(LoggedUser.Name,LoggedUser.Money);

                    ViewState["Message"] = "已提交提现申请，请耐心等待";
                }
                catch (ApplicationException ex)
                {
                    ViewState["Message"] = ex.Message;
                }
                catch (Exception ex)
                {
                    ViewState["Message"] = "系统异常";
                    Logger.GetLogger().Error("提现页面\n", ex);
                }

            }
        }
    }
}