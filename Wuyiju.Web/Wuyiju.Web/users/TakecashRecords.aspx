<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TakecashRecords.aspx.cs" Inherits="Wuyiju.Web.users.TakecashRecords" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter cztx">
        <ul class="tab-glzx">
            <li><a href="/Users/Takecash.aspx" target="_self">我要提现</a></li>
            <li><a class="cur" href="/Users/TakecashRecords.aspx" target="_self">提现记录</a></li>
        </ul>
        <form id="iformss" name="formss" action="" method="post">
            <input type="hidden" name="pageid" id="ipageid" value="">
            <div class="ChaXunTiaoJian">
                <dl>
                    <dt>起止日期：</dt>
                    <dd>
                        <input type="text" name="startdate" id="istartdate" value="<%=ViewState["startdate"] %>" style="width: 68px; height: 22px; line-height: 22px\9;" class="txt-style1"></dd>
                    <dd style="padding-top: 6px;">&nbsp;-&nbsp;</dd>
                    <dd>
                        <input type="text" name="endate" id="iendate" value="<%=ViewState["startdate"] %>" style="width: 68px; height: 22px; line-height: 22px\9;" class="txt-style1"></dd>
                </dl>
                <dl class="ChuLi">
                    <dt>处理结果：</dt>
                    <dd>
                        <input type="radio" name="sztype" id="isztype0" value="" <%=(ViewState["type"].TryParseToInt32(-1) == -1? "checked":"" ) %>>所有</dd>
                    <dd>
                        <input type="radio" name="sztype" id="isztype4" value="2" <%=(ViewState["type"].TryParseToInt32(-1) == 2? "checked":"" ) %> />成功</dd>
                    <dd>
                        <input type="radio" name="sztype" id="isztype3" value="3" <%=(ViewState["type"].TryParseToInt32(-1) == 3? "checked":"" ) %> />失败</dd>
                    <dd>
                        <input type="radio" name="sztype" id="isztype2" value="1" <%=(ViewState["type"].TryParseToInt32(-1) == 1? "checked":"" ) %> />处理中</dd>
                    <dd>
                        <input type="radio" name="sztype" id="isztype1" value="0" <%=(ViewState["type"].TryParseToInt32(-1) == 0? "checked":"" ) %> />请求中</dd>
                </dl>
                <input class="ChaXun-btn" type="submit" value="查询">
            </div>
            <script language="javascript">txradiomo('');</script>
        </form>
        <div class="ChongZhiTiXian-tblbox">
            <table width="100%" cellpadding="0" cellspacing="0">
                <tbody>
                    <tr>
                        <th width="145" style="vertical-align: top;">提现流水号</th>
                        <th width="100">开户银行</th>
                        <th width="110">银行账号后四位</th>
                        <th width="130">提现申请时间</th>
                        <th width="110">提现金额（元）</th>
                        <th width="100">实际到账（元）</th>
                        <th width="65">提现状态</th>
                        <th>备注</th>
                    </tr>

                    <asp:Repeater runat="server" ID="rptList">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("Sn") %></td>
                                <td><%# Eval("Bank_Name") %></td>
                                <td><%# Eval("CardNum") %></td>
                                <td><%# Eval("AddTime") %></td>
                                <td><%# Eval("Money") %></td>
                                <td><%# Eval("Pay_Money") %></td>
                                <td><%# Eval("StatusText") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                    <%--<tr style="line-height: 50px;">
                        <td colspan="8" align="center"><span class="sugCon">&nbsp;提示：暂无相应的提现记录！</span></td>
                    </tr>--%>
                </tbody>
            </table>
        </div>
        <asp:AspNetPager ID="paging" runat="server" CssClass="fenye clearfix" UrlPageIndexName="p" AlwaysShow="True" UrlPaging="True" NumericButtonCount="10" PageSize="10" AlwaysShowFirstLastPageNumber="True" CurrentPageButtonClass="current" FirstLastButtonsClass="firstlast" FirstPageText="首页" HorizontalAlign="Right" LastPageText="末页" MoreButtonsClass="more" NextPageText="下一页" PageIndexBoxClass="indexbox" PagingButtonsClass="" PagingButtonSpacing="0px" PrevNextButtonsClass="prenext" PrevPageText="上一页" ShowFirstLast="False" SubmitButtonClass="submitbtn" SubmitButtonText="前往"></asp:AspNetPager>
    </div>
</asp:Content>
