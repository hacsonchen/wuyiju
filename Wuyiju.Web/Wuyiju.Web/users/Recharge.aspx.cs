using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.Core;
using Wuyiju.IService;
using Wuyiju.Model;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web.users
{
    public partial class Recharge : UserPage
    {
        public Config Alipay;
        public Config Unionpay;
        protected void Page_Load(object sender, EventArgs e)
        {

            var configService = unity.GetInstance<IConfigService>();

            Alipay = configService.GetConfig("alipay");

            Unionpay = configService.GetConfig("unionpay");

            if ("POST".Equals(Request.RequestType.ToUpper()))
            {
                var recharge = new Model.DepositRecharge();
                recharge.User_Id = LoggedUser.Id;
                recharge.User_Name = LoggedUser.Name;

                var payType = (Model.RechargeType)Request.Form["czfs"].TryParseToInt32(-1);

                if (payType == Model.RechargeType.BankHui)
                {

                    recharge.Shoukcard = Request.Form["shoukCard"];
                    recharge.Huibank = Request.Form["huiBank"];
                    recharge.Huimoney = Request.Form["huiMoney"].TryParseToDecimal(0);
                    var huiTime = Request.Form["huiTime"].TryParseToDateTime();

                    if (huiTime != null)
                        recharge.Huitime = huiTime.ToUnixTimestamp();

                    recharge.Huiuser = Request.Form["huiUser"];
                    recharge.Huiremark = Request.Form["huiRemark"];

                    var file = Request.Files["huiFile"];

                    if (file != null)
                    {
                        var savePath = MapPath(string.Format("/Deposits/{0:yyyyMMdd}/", DateTime.Now));
                        recharge.Huifile = file.Upload(savePath) ?? "";
                    }

                }
                else if (payType == Model.RechargeType.AlipayHui)
                {
                    recharge.Huibank = "支付宝";
                    var cztype = Request.Form["cztype"].TryParseToInt32(0);
                    if (cztype == 1)
                    {
                        recharge.Huimoney = Request.Form["payMoney"].TryParseToDecimal(0);
                        recharge.Trade_No = Request.Form["tradeNum1"];
                    }
                    if (cztype == 2)
                    {
                        recharge.Huimoney = Request.Form["saoMoney"].TryParseToDecimal(0);
                        recharge.Trade_No = Request.Form["tradeNum2"];
                    }
                    recharge.Shoukcard = "";
                    recharge.Huiuser = "";
                    recharge.Huiremark = "";
                    recharge.Huifile = "";
                }
                else
                {
                    ViewState["Message"] = "不支持此支付方式";
                    Response.End();
                }

                recharge.Pay_Type = payType;


                var rechargeSvr = unity.GetInstance<IDepositRechargeService>();

                try
                {
                    rechargeSvr.Recharge(recharge);

                    //因为提现会使用户金额发生改变所以要刷新当前登陆用户信息
                    //LoggedState.Refresh();

                    ViewState["Message"] = "我们正在审核，请耐心等待";
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