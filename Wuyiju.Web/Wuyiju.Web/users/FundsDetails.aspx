<%@ Page Title="收支明细" Language="C#" AutoEventWireup="true" CodeBehind="FundsDetails.aspx.cs" Inherits="Wuyiju.Web.users.FundsDetails" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link rel="stylesheet" href="/Public/Control/Css/datepicker.css" />
    <script type="text/javascript" src="/Public/Control/Js/datepicker.js"></script>
    <script type="text/javascript" src="/Public/Control/Js/datepicker-zh_CN.js"></script>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter xggrzl">
        <div class="revise">
            <span>收支明细</span>
        </div>
        <div class="detail">
            <form name="myform" id="myform" action="/Users/FundsDetails.aspx" method="post">
                <dl>
                    <dt class="tname">资金流向：</dt>
                    <dd>
                        <input id="shouru" name="way" type="radio" value="1" <%=(ViewState["way"].TryParseToInt32(0) == 1? "checked":"" ) %>>&nbsp;收入&nbsp;&nbsp;
                        <input id="zhichu" type="radio" name="way" value="2" <%=(ViewState["way"].TryParseToInt32(0) == 2? "checked":"" ) %>>&nbsp;支出
                    </dd>
                </dl>
                <dl>
                    <dt class="tname">类&nbsp;&nbsp;&nbsp;型：</dt>
                    <dd>
                         <input type="checkbox" name="types[]" value="3" <%=(((string[])ViewState["type"]) != null && ((string[])ViewState["type"]).Contains("3") ? "checked":"" ) %>>&nbsp;充值&nbsp;&nbsp;
                         <input type="checkbox" name="types[]" value="2" <%=(((string[])ViewState["type"]) != null && ((string[])ViewState["type"]).Contains("2") ? "checked":"" ) %>>&nbsp;支付&nbsp;&nbsp;
                         <input type="checkbox" name="types[]" value="1" <%=(((string[])ViewState["type"]) != null && ((string[])ViewState["type"]).Contains("1") ? "checked":"" ) %>>&nbsp;提现&nbsp;&nbsp;
                         <input type="checkbox" name="types[]" value="0" <%=(((string[])ViewState["type"]) != null && ((string[])ViewState["type"]).Contains("0") ? "checked":"" ) %>>&nbsp;其它</dd>
                </dl>
                <dl>
                    <dt>金额区间：</dt>
                    <dd>
                        <input type="text" name="smoney" value="<%=ViewState["smoney"] %>" class="tex" maxlength="10">
                        -
                        <input type="text" name="emoney" value="<%=ViewState["emoney"] %>" class="tex" maxlength="10">
                        元</dd>
                </dl>
                <dl>
                    <dt>起止日期：</dt>
                    <dd>
                        <input type="text" name="startdate" id="startdate" value="<%=ViewState["startdate"] %>" class="tex hasDatepicker" readonly="" maxlength="10">
                        -
                        <input type="text" name="enddate" id="enddate" value="<%=ViewState["enddate"] %>" readonly="" class="tex hasDatepicker" maxlength="10"></dd>
                </dl>
                <dl>
                    <dt>关&nbsp;键&nbsp;字：</dt>
                    <dd>
                        <input type="text" name="keyword" value="" class="big-tex" maxlength="15"></dd>
                </dl>
                <div class="btn-box">
                    <input type="submit" class="chaxun" value="">
                </div>
            </form>

        </div>
        <div class="minute" id="shou" style="display: block;">
            <table width="100%" cellpadding="0" cellspacing="0">
                <tbody>
                    <tr>
                        <th align="center" width="140">流水号</th>
                        <th align="center" width="140">创建时间</th>
                        <th align="center" width="200">备注说明</th>
                        <th align="center" width="50">类型</th>
                        <th align="center" width="80">收入(元)</th>
                        <th align="center" width="80">支出(元)</th>
                        <th align="center" width="90">余额(元)</th>
                    </tr>
                    <asp:Repeater runat="server" ID="rptList">
                        <ItemTemplate>
                            <tr>
                                <td align="center"><%# Eval("Id") %></td>
                                <td align="center"><%# Eval("AddTime") %></td>
                                <td align="center"><%# Eval("Desc") %></td>
                                <td align="center"><%# Eval("TypeText") %></td>
                                <td align="center">+<%# Eval("Money") %></td>
                                <td align="center">0.00</td>
                                <td align="center"><%# Eval("Balance") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
        <!--支出-->

        <div class="minute" id="zhi" style="display: none;">
            <table width="100%" cellpadding="0" cellspacing="0">
                <tbody>
                    <tr>
                        <th align="center" width="140">流水号</th>
                        <th align="center" width="140">创建时间</th>
                        <th align="center" width="200">备注说明</th>
                        <th align="center" width="50">类型</th>
                        <th align="center" width="80">收入(元)</th>
                        <th align="center" width="80">支出(元)</th>
                        <th align="center" width="90">余额(元)</th>
                    </tr>
                    <asp:Repeater runat="server" ID="rptList2">
                        <ItemTemplate>
                            <tr>
                                <td align="center"><%# Eval("Id") %></td>
                                <td align="center"><%# Eval("AddTime") %></td>
                                <td align="center"><%# Eval("Desc") %></td>
                                <td align="center"><%# Eval("TypeText") %></td>
                                <td align="center">0.00</td>
                                <td align="center">-<%# Eval("Money") %></td>
                                <td align="center"><%# Eval("Balance") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>

                </tbody>
            </table>
        </div>

        <asp:AspNetPager ID="paging" runat="server" CssClass="fenye clearfix" UrlPageIndexName="p" AlwaysShow="True" UrlPaging="True" NumericButtonCount="10" PageSize="10" AlwaysShowFirstLastPageNumber="True" CurrentPageButtonClass="current" FirstLastButtonsClass="firstlast" FirstPageText="首页" HorizontalAlign="Right" LastPageText="末页" MoreButtonsClass="more" NextPageText="下一页" PageIndexBoxClass="indexbox" PagingButtonsClass="" PagingButtonSpacing="0px" PrevNextButtonsClass="prenext" PrevPageText="上一页" ShowFirstLast="False" SubmitButtonClass="submitbtn" SubmitButtonText="前往"></asp:AspNetPager>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {

            $('#startdate,#enddate').datepicker();

            $('#shouru').click(function () {
                $('#shou').css('display', 'block');
                $('#zhi').css('display', 'none');
            });

            $('#zhichu').click(function () {
                $('#shou').css('display', 'none');
                $('#zhi').css('display', 'block');

            });

        })

    </script>
</asp:Content>
