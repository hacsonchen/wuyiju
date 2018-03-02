<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Takecash.aspx.cs" Inherits="Wuyiju.Web.users.Takecash" MasterPageFile="~/users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter cztx">
        <% if (!ViewState["Message"].IsNull() && !ViewState["Message"].ToString().IsNullOrEmpty())
            { %>
        <div class="err" style="width: 250px;">
            <div class="icon_1"><%=ViewState["Message"] %></div>
        </div>
        <% } %>
        <ul class="tab-glzx">
            <li><a class="cur" href="/Users/Takecash.aspx" target="_self">我要提现</a></li>
            <li><a href="/Users/TakecashRecords.aspx" target="_self">提现记录</a></li>
        </ul>
        <div class="WoYaoTiXian">
            <form id="form_1" name="formss" action="" method="post">
                <input type="hidden" name="kymoney" id="ikymoney" value="0.00" />
                <input type="hidden" name="getbank" id="igetbank" value="" />
                <input type="hidden" name="ppwdFlag" id="ippwdFlag" value="" />
                <input type="hidden" name="struts.token.name" value="token" />
                <input type="hidden" name="token" value="1SXL6WOO1CA954M4ZC2W024NYZYL7N70" />
                <div class="YinHangZhangHu">
                    <h2 style="font-size: 14px; font-family: &quot; 微软雅黑&quot;">提现银行账户:</h2>
                    <table width="100%" cellpadding="0" cellspacing="0">
                        <colgroup>
                            <col width="55" />
                            <col width="158" />
                            <col width="150" />
                            <col width="180" />
                            <col width="215" />
                        </colgroup>
                        <tbody>
                            <tr>
                                <th>&nbsp;</th>
                                <th align="left">银行账户</th>
                                <th>银行卡尾号</th>
                                <th>开户名</th>
                                <th>操作</th>
                            </tr>
                            <asp:Repeater runat="server" ID="rptCards">
                                <ItemTemplate>
                                    <tr>
                                        <td>
                                            <input type="radio" name="bank_card_id" value="<%# Eval("Id") %>" /></td>
                                        <td align="left"><%# Eval("Bank_Name") %></td>
                                        <td align="center"><%# Eval("Card_Number") %></td>
                                        <td align="center"><%# Eval("Real_Name") %></td>
                                        <td align="center"><a href="/Users/BankCardRemove.aspx?id=<%# Eval("Id") %>" title="">删除</a></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                    <gt name="count_deposit" value="0">
                        <a class="TianJia" href="javascript:void(0)">添加银行卡 （还可以添加 <span class="Dred"><%=AddCount %></span> 个）</a>
                        </gt>
                </div>

                <div class="TiXianJinE">
                    <dl class="clearfix">
                        <dt style="padding: 0; font-weight: bold; color: #444;">提现金额：</dt>
                        <dd>
                            <input type="text" name="txmoney" id="itxmoney" maxlength="8" style="width: 90px; height: 26px; line-height: 26px\9;" class="txt-style1" /></dd>
                        <dd>&nbsp;&nbsp;元&nbsp;&nbsp;&nbsp;&nbsp;<font color="#188CA8">可提现金额 <span id="money" class="Dred"><%=LoggedUser.Money %></span> 元</font></dd>
                    </dl>
                    <dl class="clearfix" style="margin-top: 20px;">
                        <dt style="padding: 0; font-weight: bold; color: #444;">支付密码：</dt>
                        <dd>
                            <input type="password" name="paypwd" id="ipaypwd" maxlength="20" style="width: 150px; height: 26px; line-height: 26px\9;" class="txt-style1" /></dd>
                        <dd><a href="/Users/PaymentPassword.aspx" target="_self" class="ml42">设置支付密码</a></dd>
                    </dl>
                    <dl class="clearfix" style="margin-top: 10px;">
                        <dt>&nbsp;</dt>
                        <dd>【<font color="#0B89AE">温馨提示：</font><font color="#C08634">为了您的满意，提现手续费将由选猫网承担，感谢您对选猫网的支持！</font>】</dd>
                    </dl>
                    <dl class="clearfix" style="margin-top: 30px;">
                        <dt>&nbsp;</dt>
                        <dd>
                            <input id="submit_btn" type="button" value="确认提交" class="submit-btn fl" /></dd>
                    </dl>
                </div>
            </form>

        </div>
    </div>

    <div id="AddBankCard" class="alertLayer" style="display: none; position: fixed; z-index: 1000; width: 600px; left: 50%; top: 50%; margin: -250px 0 0 -300px; border: 2px solid #cccccc;">
        <div class="title clearfix">
            <h2 class="fl">添加银行卡</h2>
            <a class="exit fr" href="javascript:void(0)">退出</a>
        </div>
        <div class="AlertConBox">

            <form id="iformss" name="formss" onsubmit="return CheckTjForm_1()" action="/Users/BankCardAdd.aspx" method="post">
                <input type="hidden" name="struts.token.name" value="token">
                <input type="hidden" name="token" value="GN3HGZEY0KSMFXG2646NH5U9Y2IMCFO7">
                <input type="hidden" name="bkb.khz2" id="izhaddr" value="">
                <table class="tbl-AddBank" width="100%" cellpadding="0" cellspacing="0">
                    <tbody>
                        <tr>
                            <th align="right" valign="top">银行账户类型：</th>
                            <td align="left">借记卡</td>
                        </tr>
                        <tr>
                            <th align="right" valign="top">开户人真实姓名：</th>
                            <td align="left"><%=LoggedUser.Realname %></td>
                        </tr>
                        <tr>
                            <th align="right" valign="top">开户银行所在地：</th>
                            <td align="left">
                                <div class="fl" style="margin-top: 8px; *margin-top: 0px;">
                                    <select name="khp2" id="provinceList" style="width: 130px;">
                                        <option value="">-请选择-</option>
                                        <asp:Loop runat="server" LoopType="Region">
                                            <ItemTemplate>
                                                <option value="<%# Eval("Region_Id") %>"><%# Eval("Region_Name") %></option>
                                            </ItemTemplate>
                                        </asp:Loop>
                                    </select>
                                </div>

                                <span class="fl">&nbsp;省份&nbsp;&nbsp;</span>
                                <!--<script type="text/javascript">GetProvince(document.getElementById("provinceList"));</script>-->
                                <div class="fl" style="margin-top: 8px; *margin-top: 0px;">
                                    <select name="khc2" id="cityList" style="width: 130px;" onchange="ClearBankByCity()">
                                        <option value="">-请选择-</option>
                                    </select>
                                </div>
                                <span class="fl">&nbsp;城市&nbsp;&nbsp;</span>
                                <div class="clear"></div>
                                <p style="margin-left: -4px;"><font color="#0B89AE">【提示：<font color="#C08634">如果找不到所在的城市，可以选择所在的地区或者上级城市。</font>】</font></p>
                            </td>
                        </tr>
                        <tr>
                            <th align="right" valign="top">开户银行：</th>
                            <td align="left">
                                <div class="select-style1" style="display: inline-block;">
                                    <select name="khh2" id="ikhbank" style="width: 130px;" onchange="ShowBranch('')">
                                        <option value="">-请选择-</option>
                                        <option value="中国工商银行">中国工商银行</option>
                                        <option value="中国农业银行">中国农业银行</option>
                                        <option value="中国建设银行">中国建设银行</option>
                                        <option value="交通银行">交通银行</option>
                                        <option value="招商银行">招商银行</option>
                                        <option value="中国银行">中国银行</option>
                                        <option value="兴业银行">兴业银行</option>
                                        <option value="中国民生银行">中国民生银行</option>
                                        <option value="广东发展银行">广东发展银行</option>
                                        <option value="深圳发展银行">深圳发展银行</option>
                                        <!--<option value="中国邮政储蓄银行">中国邮政储蓄银行</option>-->
                                        <option value="上海浦东发展银行">上海浦东发展银行</option>
                                    </select>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th align="right" valign="top">所在支行：</th>
                            <td align="left" style="position: relative;">
                                <input type="text" name="zhshow" id="izhshow" value="" class="inputSelectBox">
                                <ul class="selectInput" id="iselectInput" style="display: none;">
                                </ul>
                            </td>
                        </tr>
                        <tr id="ibranchtr" style="display: none">
                            <th align="right" valign="top">其它支行：</th>
                            <td align="left">
                                <input type="text" name="obranch" id="iobranch" value="" maxlength="30" style="width: 250px; height: 28px; line-height: 28px\9; margin-top: 7px;" class="txt-style1">
                            </td>
                        </tr>
                        <tr>
                            <th align="right" valign="top">银行账号：</th>
                            <td align="left">
                                <input type="text" name="khk2" id="icarcd" value="" maxlength="20" style="width: 250px; height: 28px; line-height: 28px\9; margin-top: 7px;" class="txt-style1">
                                <p style="margin-left: -4px;"><font color="#0B89AE">【提示：<font color="#C08634">此银行卡的开户名必须为"<%=LoggedUser.Realname %>"，否则提现会失败。</font>】</font></p>
                            </td>
                        </tr>
                        <tr>
                            <th align="right" valign="top">请再输入一遍：</th>
                            <td align="left">
                                <input type="text" name="khm2" id="imcarcd" value="" maxlength="20" style="width: 250px; height: 28px; line-height: 28px\9; margin-top: 7px; margin-bottom: 7px;" class="txt-style1" onpaste="return false">
                            </td>
                        </tr>
                        <tr class="BaoCunBtnBox">
                            <th>&nbsp;</th>
                            <td>
                                <input class="BaoCun-btn fl" type="submit" value="保存账户"></td>
                        </tr>
                    </tbody>
                </table>
            </form>



        </div>
    </div>
    <script>
        $(document).ready(function () {
            $('#provinceList').change(function () {
                $.post("/Users/GetRegion.aspx",
                        { 'region': $('#provinceList').val() }
                        , function (data) {
                            $('#cityList').html(data);
                        });
            })

            $('.TianJia').click(function () {
                $('#AddBankCard').css('display', 'block');
            })

            $('.exit').click(function () {
                $('#AddBankCard').css('display', 'none');
            })

            $('#submit_btn').click(function () {
                var money = parseFloat($('#money').text());
                if (money < 0.01) {
                    alert('没有足够的余额');
                    return;
                }
                var bank_card_id = $('input:radio[name="bank_card_id"]:checked').val();
                if (typeof (bank_card_id) == "undefined") {
                    alert('选择一张银行卡');
                    return;
                }

                var tx_money = $('#itxmoney').val();
                if (tx_money < 0.01) {
                    alert('没有输入要提现的金额');
                    return;
                }
                if (tx_money > money) {
                    alert('没有足够的余额');
                    return;
                }
                var pay_pwd = $('#ipaypwd').val();
                if (pay_pwd == '') {
                    alert('没有输入支付密码');
                    return;
                }

                $('#form_1').submit();

            })

        })
    </script>
</asp:Content>
