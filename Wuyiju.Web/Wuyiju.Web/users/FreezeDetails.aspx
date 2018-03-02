<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FreezeDetails.aspx.cs" Inherits="Wuyiju.Web.users.FreezeDetails" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link rel="stylesheet" href="/Public/Control/Css/datepicker.css" />
    <script type="text/javascript" src="/Public/Control/Js/datepicker.js"></script>
    <script type="text/javascript" src="/Public/Control/Js/datepicker-zh_CN.js"></script>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter xggrzl">
        <div class="revise">
            <span>冻结明细</span>
        </div>
        <form name="myform" id="myform" action="/Users/FreezeDetails.aspx" method="post">
            <div class="detail">
                <dl>
                    <dt>类型：</dt>
                    <dd>
                        <input name="type" type="radio" value="4" <%=(((string[])ViewState["type"]) != null && ((string[])ViewState["type"]).Contains("4") ? "checked":"" ) %>>&nbsp;押金&nbsp;&nbsp;
                        <input type="radio" name="type" value="1" <%=(((string[])ViewState["type"]) != null && ((string[])ViewState["type"]).Contains("1") ? "checked":"" ) %>>&nbsp;提现申请
                    </dd>
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
                    <dt>关键字：</dt>
                    <dd>
                        <input type="text" name="keyword" value="" class="big-tex" maxlength="15"></dd>
                </dl>
                <div class="btn-box">
                    <input type="submit" class="chaxun" value="">
                </div>
            </div>
        </form>

        <div class="minute">
            <table width="100%" cellpadding="0" cellspacing="0">
                <tbody>
                    <tr>
                        <th align="center" width="150">创建时间</th>
                        <th align="center" width="200">备注说明</th>
                        <th align="center" width="100">类型</th>
                        <th align="center" width="95">冻结金额(元)</th>
                    </tr>
                    <asp:Repeater runat="server" ID="rptList">
                        <ItemTemplate>
                            <tr>
                                <td align="center"><%# Eval("AddTime") %></td>
                                <td align="center"><%# Eval("Desc") %></td>
                                <td align="center"><%# Eval("TypeText") %></td>
                                <td align="center"><%# Eval("Frozen_Money") %></td>
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

            $('#startdate,#endate').datepicker();

            $('#shouru').click(function () {
                $('#shou').css('display', 'block');
                $('#zhi').css('display', 'none');
            });

            $('#zhichu').click(function () {
                $('#shou').css('display', 'none');
                $('#zhi').css('display', 'block');
            });

        });

    </script>
</asp:Content>
