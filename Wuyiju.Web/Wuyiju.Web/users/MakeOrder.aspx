<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MakeOrder.aspx.cs" Inherits="Wuyiju.Web.users.MakeOrder" MasterPageFile="~/Users/UserCenter.Master" %>
<%@ Import Namespace="Wuyiju.Core" %>
<%@ Import Namespace="Wuyiju.Domain.Model" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
     <script type="text/javascript">
        $(document).ready(function () {
            $('#ipfang0').click(function () {
                $('#payall').css('display', 'block');
                $('#paypart').css('display', 'none');
                $('#ipartpay').val(1);
            });

            $('#ipfang3').click(function () {
                $('#payall').css('display', 'none');
                $('#paypart').css('display', 'block');
                $('#ipartpay').val(0);
            });

            $('#fukuan').click(function () {
                var status = $('#status').val();
                if (status == 0) {
                    alert("此订单已取消，无法支付，请重新下单！");
                    window.location.href = "/Users/BoughtList.aspx";
                }
                if (status == 2 || status == 3) {
                    alert("此订单已完成，无需再次支付！");
                    window.location.href = "/Users/BoughtList.aspx";
                }

            });
        });

    </script>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter glzx" style="padding-bottom: 30px;">
        <div class="tab-glzx">
            <li><a class="cur" href="javascript:void(0)">订单付款</a></li>
        </div>
        <div class="shop-news">
            <div class="dianpu">
                <h2>订单编号：<%=Order.Sn %></h2>
            </div>
            <dl class="clearfix">
                <dt class="wyfb">生成时间： </dt>
                <dd class="xhz"><%=Order.Add_Time.ToDateTime2().ToString("yyyy-MM-dd HH:mm") %></dd>
            </dl>
            <p></p>
            <dl class="clearfix">
                <dt class="wyfb">网店名称： </dt>
                <dd class="xhz"><%=Model.Name %> <a href="<%=string.Format("/ShopView.aspx?id={0}",Model.Id) %>">[查看详细]</a>
                </dd>
            </dl>
            <p></p>
            <dl class="clearfix">
                <dt class="wyfb">成交价格： </dt>
                <dd class="xhz"><%=Order.Price %>元</dd>
            </dl>
            <p></p>
            <dl class="clearfix">
                <dt class="wyfb">手续费： </dt>
                <dd class="xhz"><%=string.Format("{0:F2}", Order.Fee) %> 元<font color="#FF6600">(手续费为成交价格的<%=ApplicationConfig.SysFeeLabel %>，手续费折扣：无)</font></dd>
            </dl>
            <p></p>
            <dl class="clearfix">
                <dt class="wyfb">消保保证金： </dt>
                <dd class="xhz"><%=string.Format("{0:F2}", Order.Ensure) %> 元(需退还)</dd>
            </dl>
            <p></p>
            <dl class="clearfix">
                <dt class="wyfb">(退还)技术年费： </dt>
                <dd class="xhz"><%=string.Format("{0:F2}", Order.Techfee) %> 元(需退还)</dd>
            </dl>
            <p></p>
            <dl class="clearfix">
                <dt class="wyfb">订单总额： </dt>
                <dd class="xhz"><strong class="red"><%=string.Format("{0:F2}", Order.Total_Fee) %></strong> 元</dd>
            </dl>
            <p></p>

            <form id="ipayform" action="/Users/PayHandle.aspx" onsubmit="return payPwdCheck();" method="post">              
                <input type="hidden" name="epay" id="iepay" value="">
                <input type="hidden" name="fenqi" id="ifenqi" value="">
                <input type="hidden" name="partpay" id="ipartpay" >

                <input type="hidden" name="sn" id="sn" value="<%=Order.Sn %>">
                <div class="dianpu" style="background: #FFECD9;">
                    <h2>付款信息:</h2>
                </div>
                <dl class="clearfix">
                    <dt class="wyfb">账户可用余额： </dt>
                    <dd class="xhz"><strong style="color: #008000"><%=LoggedUser.Money %></strong> 元 <a href="/Users/Recharge.aspx" style="width: 158px; height: 26px; display: inline-block; background: url(/Public/Home/Shops/Images/user/yebzljcz.png); vertical-align: middle;"></a></dd>
                </dl>
                <p></p>
                <dl class="clearfix" style="line-height: 30px;">
                    <dt class="wyfb">付款方式： </dt>
                    <dd class="xhz" style="height: auto;">
                        <span class="fukuanfangshi">
                            <input type="radio" name="payfang" id="ipfang0" value="0">全额支付</span>
                        <span class="fukuanfangshi">
                            <input type="radio" name="payfang" id="ipfang3" value="7">交定金（支付5000元,预留7天）</span><br>
                        <script type="text/javascript">
                            document.getElementById("ipfang0").checked = true;
                        </script>
                    </dd>
                </dl>
                <p></p>
                <!--全额支付-->
                <div id="payall" style="display: block;">
                    <dl class="clearfix" id="izpayshow" style="display: none">
                        <dt class="wyfb">请输入支付金额： </dt>
                        <dd class="xhz">
                            <input type="text" name="zpaymon" id="izpaymon" value="500" onkeyup="Input500()" onblur="Input500()" style="width: 80px;">
                            元（至少支付500元！）</dd>
                    </dl>
                    <p></p>
                    <dl class="clearfix">
                        <dt class="wyfb">支付总额： </dt>
                        <dd class="xhz">
                            <input type="button" name="payed_money" id="payed_money" value="<%=string.Format("{0:F2}", Order.Total_Fee) %>" style="color: red; background-color: #fff; font-weight: bold;">
                            元</dd>
                    </dl>
                    <p></p>
                    <dl class="clearfix" id="idjtshow" style="display: none">
                        <dt class="wyfb">温馨提示： </dt>
                        <dd class="xhz" style="color: #FF0000">此为购买该网店的预留期，请确认您预留期内可付款，预留期结束前未支付全款且非卖方原因，此金额将不予退还！</dd>
                    </dl>
                    <p></p>

                </div>
                <!--支付定金-->
                <div id="paypart" style="display: none;">
                    <dl class="clearfix">
                        <dt class="wyfb">支付总额： </dt>
                        <dd class="xhz"><strong class="red" id="iallmon"><%=string.Format("{0:N2}", Order.Deposit) %></strong> 元</dd>
                    </dl>
                    <p></p>
                    <dl class="clearfix" id="idjtshow" style="display: block">
                        <dt class="wyfb">温馨提示： </dt>
                        <dd class="xhz" style="color: #FF0000">此为购买该网店的预留期，请确认您预留期内可付款，预留期结束前未支付全款且非卖方原因，此金额将不予退还！</dd>
                    </dl>
                    <p></p>
                </div>
                <dl class="clearfix">
                    <dt class="wyfb">请输入支付密码： </dt>
                    <dd class="xhz">
                        <input type="password" name="pwd" id="consigneePayPwd" class="txt-style1" style="height: 27px; margin-top: 9px; width: 200px; line-height: 27px\9;">&nbsp;&nbsp;
			          	<a href="#" style="color: #008000; text-decoration: underline;">忘记支付密码？</a>&nbsp;&nbsp;&nbsp;&nbsp;
                        <a href="#" style="color: #279FF0; text-decoration: underline;">选猫网责任与义务相关声明</a></dd>
                </dl>
                <dl class="clearfix">
                    <dt style="width: 130px;"></dt>
                    <dd class="queren">
                        <input onclick="location.href = '/Users/'" style="background: url(/Public/Home/Shops/Images/user/orgBack-btn.png); width: 88px; height: 30px;" class="mt15" type="button">
                        <input style="background: url(/Public/Home/Shops/Images/user/greenOK3-btn.png); width: 88px; height: 30px; cursor: pointer; border: none;" class="mt15 ml15" type="submit" value="">
                    </dd>
                </dl>

            </form>

        </div>
    </div>
</asp:Content>
