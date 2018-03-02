<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recharge.aspx.cs" Inherits="Wuyiju.Web.users.Recharge" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link type="text/css" rel="stylesheet" href="http://www.jq22.com/demo/jquery-time-150202223917/css/jcDate.css" media="all" />
    <script type="text/javascript" src="/Public/Home/Shops/Js/calendar.min.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/Js/jQuery-jcDate.js"></script>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter cztx">
        <% if (!ViewState["Message"].IsNull() && !ViewState["Message"].ToString().IsNullOrEmpty())
            { %>
        <div class="err" style="width: 250px;">
            <div class="icon_1"><%=ViewState["Message"] %></div>
        </div>
        <% } %>
        <ul class="tabBarNew">
            <li><a class="cur" href="/Users/Recharge.aspx" target="_self">在线充值</a></li>
            <li><a href="/Users/RechargeRecords.aspx" target="_self">充值记录</a></li>
        </ul>
        <form id="iform1" name="form1" action="/Users/Recharge.aspx" target="_blank" method="post" enctype="multipart/form-data">
            <input type="hidden" name="struts.token.name" value="token">
            <input type="hidden" name="token" value="PF9BNSO1ICR2OY35R4JVQXODHW6I6MVQ">
            <div class="tipsPay">温馨提示：“<span style="color: #369dc5;">网上银行</span>”支持信用卡充值将收取0.25%的手续费；其它免收手续费。</div>
            <div class="PayNewPart">
                <h2 class="partName">选择支付方式</h2>
                <div class="chooseWay clearfix">
                    <a class="e-bank" href="javascript:void(0)">
                        <input type="radio" name="czfs" id="iczfs5" value="4" checked=""><label for="iczfs1">支付宝付款</label></a>
                    <a class="HuiKuan" href="javascript:void(0)">
                        <input type="radio" name="czfs" id="iczfs3" value="3"><label for="iczfs3">网银转帐</label></a>
                    <!--<a class="alipay" href="javascript:void(0)"><input type="radio" name="czfs" id="iczfs2" value="2" /><label for="iczfs2">支付宝</label></a>-->
                </div>
            </div>

            <div class="describeSchemes" style="display: block;">
                <p class="dottedLine"></p>
                <div class="PayNewPart">
                    <h2 class="partName">填写充值金额
                        <input type="radio" name="cztype" id="icztype1" value="1" checked="" onclick="cztypeShow('1')" style="margin-left: 62px;"><label for="icztype1" class="alipayTypeChoose">&nbsp;&nbsp;在线充值</label>
                        <input type="radio" name="cztype" id="icztype2" value="2" onclick="cztypeShow('2')" style="margin-left: 62px;"><label for="icztype2" class="alipayTypeChoose">&nbsp;&nbsp;扫码充值</label></h2>
                </div>
                <input type="hidden" name="shoukh" value="3">
                <div id="olPay" class="PayNewPart" style="padding-left: 95px; display: -none;">
                    <h2 class="partName" style="margin-bottom: 49px;">付款支付宝账号</h2>
                    <div class="alipayNew">
                        <p>账&nbsp;&nbsp;号：<%=Alipay.GetValue("code") %></p>
                        <p>开户名：<%=Alipay.GetValue("name") %></p>
                    </div>
                    <div class="alipayTips"><span>温馨提示：</span>支付宝付款时，付款金额和说明不能修改，否则无法受理！</div>
                    <ul class="factor clearfix">
                        <li>充值金额：</li>
                        <li>
                            <input class="txt-style cid" type="text" name="payMoney" id="ipayMoney" maxlength="7" style="font-size: 16px; text-align: center;" value=""></li>
                        <li><span class="tips-JinE">只允许输入数字</span></li>
                    </ul>
                    <ul class="factor clearfix" style="margin-top: 22px;">
                        <li>交易帐号：</li>
                        <li>
                            <input class="txt-style cid" type="text" name="tradeNum1" id="itradeNum1" style="font-size: 16px; width: 410px;" value=""><span class="tips-JinE">请填写支付宝交易帐号</span></li>
                    </ul>

                </div>
                <div id="scanPay" class="PayNewPart" style="position: relative; margin-top: 60px; display: none;">
                    <h2 class="partName" style="margin-bottom: 49px;">付款支付宝账号</h2>
                    <img src="/Public/Home/Shops/Images/alipay.jpg" alt="支付二维码">
                    <div class="alipayNew">
                        <p>账&nbsp;&nbsp;号：<%=Alipay.GetValue("code") %></p>
                        <p>开户名：<%=Alipay.GetValue("name") %></p>
                    </div>
                    <div class="alipayTips"><span>温馨提示：</span>支付宝付款时，付款金额和说明不能修改，否则无法受理！</div>
                    <div class="zfewm">
                        扫码支付<br>
                        <br>
                    </div>
                    <ul class="factor clearfix" style="margin-top: 100px;">
                        <li>充值金额：</li>
                        <li>
                            <input class="txt-style cid" type="text" name="saoMoney" id="isaoMoney" maxlength="7" style="font-size: 16px; text-align: center;" value=""></li>
                        <li><span class="tips-JinE">只允许输入数字</span></li>
                    </ul>
                    <ul class="factor clearfix" style="margin-top: 22px;">
                        <li>交易帐号：</li>
                        <li>
                            <input class="txt-style cid" type="text" name="tradeNum2" id="itradeNum2" style="font-size: 16px; width: 410px;" value=""><span class="tips-JinE">请填写支付宝交易帐号</span></li>
                    </ul>
                </div>
            </div>

            <%--<div class="describeSchemes" style="display: block;">
                <p class="dottedLine"></p>
                <div class="PayNewPart">
                    <h2 class="partName">填写充值金额</h2>
                    <ul class="factor clearfix">
                        <li>充值金额：</li>
                        <li>
                            <input class="txt-style cid" type="text" name="czmoney" id="iczmoney" maxlength="7" style="font-size: 16px; text-align: center;" value=""></li>
                        <li><span class="tips-JinE">只允许输入数字</span></li>
                    </ul>
                </div>
            </div>--%>

            <%--<div class="describeSchemes" style="display: none;">
                <p class="dottedLine"></p>
                <div class="PayNewPart">
                    <h2 class="partName">填写充值金额</h2>
                    <ul class="factor clearfix">
                        <li>充值金额：</li>
                        <li>
                            <input class="txt-style cid" type="text" name="czamount" id="iczamount" maxlength="7" style="font-size: 16px; text-align: center;" value=""></li>
                        <li><span class="tips-JinE">只允许输入数字</span></li>
                    </ul>
                </div>
            </div>--%>

            <div class="describeSchemes" style="display: none;">
                <div class="tipsPay" style="margin: 24px auto; width: 510px;">您当前选择的是“<span style="color: #369dc5;">线下银行汇款</span>”银行汇款方式，请确保汇款确认单提交真实！</div>
                <%--<div>
                    <img src="/Public/Home/Shops/Images/user/xxhklc.png">
                </div>--%>
                <p class="dottedLine"></p>
                <div class="PayNewPart">
                    <h2 class="partName">网银转帐信息</h2>
                    <div class="xxyhzh">
                        <div class="bankInfoL">
                            <p>开户行：<%=Unionpay.GetValue("bankname") %></p>
                            <p>账&nbsp;&nbsp;号：<%=Unionpay.GetValue("code") %></p>
                            <p>开户名：<%=Unionpay.GetValue("name") %></p>
                        </div>
                    </div>
                </div>
                <%--<p class="dottedLine"></p>
                <div class="PayNewPart">
                    <h2 class="partName" style="margin-bottom: 15px;">去银行转帐</h2>
                    <div class="xxzf_tips">带好您的身份证和款项去银行营业厅转帐！</div>
                </div>--%>
                <p class="dottedLine"></p>
                <div class="PayNewPart">
                    <h2 class="partName">网银转帐确认单</h2>
                    <table class="hkqrd-tbl" cellpadding="0" cellspacing="0" width="600" border="0">
                        <tbody>
                            <tr>
                                <td style="width: 90px;" height="34" align="right">收款账户：<span style="color: #FF0000">*</span></td>
                                <td align="left">
                                    <input type="text" name="shoukCard" id="ishoukCard" value="" maxlength="50" class="cids" style="width: 360px;"></td>
                            </tr>
                            <tr>
                                <td height="34" align="right">转帐银行：<span style="color: #FF0000">*</span></td>
                                <td align="left">
                                    <input type="text" name="huiBank" id="ihuiBank" value="" maxlength="50" class="cids" style="width: 360px;"></td>
                            </tr>
                            <tr>
                                <td align="right" height="34">转帐金额：<span style="color: #FF0000">*</span></td>
                                <td align="left">
                                    <input type="text" name="huiMoney" id="ihuiMoney" value="" maxlength="10" class="cids" style="width: 133px;"></td>
                            </tr>
                            <tr>
                                <td align="right" height="34">汇款日期：<span style="color: #FF0000">*</span></td>
                                <td align="left">
                                    <input type="text" name="huiTime" id="ihuiTime" value="" class="cids_time" style="width: 113px;" autocomplete="off">
                                    <div id="dd"></div>

                                </td>
                            </tr>
                            <tr>
                                <td align="right" height="34">转帐姓名：<span style="color: #FF0000">*</span></td>
                                <td align="left">
                                    <input type="text" name="huiUser" id="ihuiUser" value="" maxlength="20" class="cids" style="width: 133px;"></td>
                            </tr>
                            <tr>
                                <td align="right" height="34">上传汇款凭证：&nbsp;</td>
                                <td align="left"><input type="file" name="huiFile" value="" id="huiFile" onchange="onUploadImgChange(this)"></td>
                            </tr>
                        </tbody>
                    </table>
                    <div id="divDate"></div>
                </div>
            </div>


            <div class="subBtn-box" style="width: 800px">
                <input class="blueSub-btnNew" type="button" id="ibut1" onclick="checkPayForm();" value="现在提交">
            </div>
        </form>

    </div>
    <script type="text/javascript" src="/Public/Home/Shops/Js/llpaychongzhi.js"></script>
    <script type="text/javascript">
        jQuery(document).ready(function () {
            //选择支付方式:
            $('.chooseWay a').click(function () {
                $(this).children('input').attr('checked', true).siblings().attr('checked', false);
                $('.describeSchemes').eq($(this).index()).css('display', 'block').siblings('.describeSchemes').css('display', 'none');
            });
            $("#ihuiTime").jcDate({
                IcoClass: "jcDateIco",
                Event: "click",
                Speed: 100,
                Left: 0,
                Top: 28,
                format: "-",
                Timeout: 100
            });

            //$('#ihuiTime').simpleDatepicker();
            $("#dd").calendar({
                trigger: '#ihuiTime',
        zIndex: 999,
		format: 'yyyy-mm-dd',
        onSelected: function (view, date, data) {
            console.log('event: onSelected')
        },
        onClose: function (view, date, data) {
            console.log('event: onClose')
            console.log('view:' + view)
            console.log('date:' + date)
            console.log('data:' + (data || 'None'));
        }
    });



        });
    </script>
</asp:Content>
