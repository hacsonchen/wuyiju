<%@ Page Title="充值记录" Language="C#" AutoEventWireup="true" CodeBehind="RechargeRecords.aspx.cs" Inherits="Wuyiju.Web.users.RechargeRecords" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link rel="stylesheet" href="/Public/Control/Css/datepicker.css" />
    <script type="text/javascript" src="/Public/Control/Js/datepicker.js"></script>
    <script type="text/javascript" src="/Public/Control/Js/datepicker-zh_CN.js"></script>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter cztx">
        <ul class="tab-glzx">
            <li><a href="/Users/Recharge.aspx" target="_self">我要充值</a></li>
            <li><a class="cur" href="/Users/RechargeRecords.aspx" target="_self">充值记录</a></li>
        </ul>

        <form id="iformss" name="formss" action="/Users/RechargeRecords.aspx" method="post">
            <input type="hidden" name="pageid" id="ipageid" value="">
            <div class="ChaXunTiaoJian">
                <dl>
                    <dt>起止日期：</dt>
                    <dd><input type="text" name="startdate" id="istartdate" maxlength="10" value="<%=ViewState["startdate"] %>" style="width: 68px; height: 22px; line-height: 22px\9;" class="txt-style1"></dd>
                    <dd style="padding-top: 6px;">&nbsp;-&nbsp;</dd>
                    <dd><input type="text" name="endate" id="iendate" maxlength="10" value="<%=ViewState["enddate"] %>" style="width: 68px; height: 22px; line-height: 22px\9;" class="txt-style1"></dd>
                </dl>
                <dl class="ChuLi">
                    <dt>处理结果：</dt>
                    <dd><input type="radio" name="sztype" id="isztype" value="" <%=(ViewState["type"].TryParseToInt32(-1) == -1? "checked":"" ) %>>所有</dd>
                    <dd><input type="radio" name="sztype" id="isztype1" value="1" <%=(ViewState["type"].TryParseToInt32(-1) == 1? "checked":"" ) %>>成功</dd>
                    <dd><input type="radio" name="sztype" id="isztype2" value="2" <%=(ViewState["type"].TryParseToInt32(-1) == 2? "checked":"" ) %>>失败</dd>
                    <dd><input type="radio" name="sztype" id="isztype0" value="0" <%=(ViewState["type"].TryParseToInt32(-1) == 0? "checked":"" ) %>>处理中</dd>
                </dl>
                <input class="ChaXun-btn" type="submit" value="查询">
            </div>
        </form>


        <script language="javascript">radiomo('');</script>

        <div class="ChongZhiTiXian-tblbox">
            <table width="100%" cellpadding="0" cellspacing="0">
                <tbody>
                    <tr>
                        <th width="30%" style="vertical-align: top;">流水号</th>
                        <th width="30%">提交时间</th>
                        <th width="20%">充值金额</th>
                        <th width="20%">状态</th>
                    </tr>

                    <asp:Repeater runat="server" ID="rptList">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("Sn") %></td>
                                <td><%# Eval("AddTime") %></td>
                                <td><%# Eval("HuiMoney") %></td>
                                <td><%# Eval("StatusText") %></td>
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

        });

    </script>
</asp:Content>
