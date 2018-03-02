<%@ Page Title="我出售的网店" Language="C#" AutoEventWireup="true" CodeBehind="SellList.aspx.cs" Inherits="Wuyiju.Web.users.SellList" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter glzx">
        <form id="iformss" method="post" action="/Users/SellList.aspx">
            <div class="WangDianJiLu">
                <ul class="tab-glzx">
                    <li><a class="cur" href="/Users/SellList.aspx" target="_self">我出售的网店</a></li>
                    <li><a href="/Users/BoughtList.aspx" target="_self">我购买的网店</a></li>
                    <li><a href="/Users/Favorites.aspx" target="_self">我收藏的网店</a></li>
                </ul>
                <div class="state">
                    <span class="fl">交易状态：</span>
                    <div class="input_con select-style1 fr">
                        <select name="pay_status" id="ipay_status" style="width: 100px;" onchange="fytj()">
                            <option value="" <%=(ViewState["type"].TryParseToInt32(-1) == -1? "selected":"" )%>>不限</option>
                            <!--不限为空-->
                            <option value="0" <%=(ViewState["type"].TryParseToInt32(-1) == 0? "selected":"" )%>>等待买家付款</option>
                            <option value="1" <%=(ViewState["type"].TryParseToInt32(-1) == 1? "selected":"" )%>>买家已付款</option>
                            <option value="2" <%=(ViewState["type"].TryParseToInt32(-1) == 2? "selected":"" )%>>买家已收货</option>
                            <option value="3" <%=(ViewState["type"].TryParseToInt32(-1) == 3? "selected":"" )%>>交易完成</option>
                            <option value="4" <%=(ViewState["type"].TryParseToInt32(-1) == 4? "selected":"" )%>>买家已退款</option>
                            <option value="5" <%=(ViewState["type"].TryParseToInt32(-1) == 5? "selected":"" )%>>交易关闭</option>
                        </select>
                    </div>
                </div>
            </div>
            <table class="tbl tbl-5" width="100%" cellpadding="0" cellspacing="0" border="0">
                <colgroup>
                    <col width="60">
                    <col width="200">
                    <col width="120">
                    <col width="75">
                    <col width="95">
                    <col width="85">
                    <col width="65">
                    <col width="100">
                </colgroup>
                <tbody>
                    <tr>
                        <th width="60">编号<!--<input class="QuanXuan" type="checkbox" name="checkbox1" id="checkbox1" onclick="hbCollecselect()" />全选--></th>
                        <th align="left">网店缩率图/标题</th>
                        <th>出售价格</th>
                        <th>消保金额</th>
                        <th>销售状态</th>
                        <th>审核状态</th>
                        <th>交易状态</th>
                        <th>操作</th>
                    </tr>
                    <tr>
                        <td colspan="8">
                            <table class="tbl-5-in" width="100%" cellpadding="0" cellspacing="0" border="0">
                                <colgroup>
                                    <col width="60">
                                    <col width="100">
                                    <col width="100">
                                    <col width="120">
                                    <col width="75">
                                    <col width="95">
                                    <col width="85">
                                    <col width="65">
                                    <col width="100">
                                </colgroup>
                                <tbody>
                                    <asp:Repeater runat="server" ID="rptList">
                                        <ItemTemplate>
                                            <tr>
                                                <th align="left" colspan="9">
                                                    <span class="fl">&nbsp;&nbsp;订单编号：<%# Eval("Sn") %></span>
                                                    <span class="fr">生成时间：<%# Eval("AddTime","{0:yyyy/MM/dd HH:mm}") %>&nbsp;&nbsp;</span>
                                                </th>
                                            </tr>
                                            <tr class="buy">
                                                <td align="center">
                                                    <input type="checkbox" name="conId" value="" disabled="">
                                                </td>
                                                <td align="center">
                                                    <a href="/ShopView.aspx?id=<%# Eval("Id") %>">
                                                        <img src="/Public/Home/Shops/Images/slogo/0830/slogo_<%# Eval("Type") %>.jpg" border="0">
                                                    </a>
                                                </td>
                                                <td align="left"><a href="<%# string.Format("/ShopView.aspx?id={0}",Eval("Id")) %>"><%# Eval("Name") %></a></td>
                                                <td align="center"><%# Eval("Price") %>
                                                    <br />
                                                    <div style="position:absolute; color:red" >到手价格：<%# Eval("SellerIncome","{0:F2}") %>元</div>
                                                </td>
                                                <td align="center"><%# string.Format("{0:###.##}", Eval("Protection_Deposit")) %></td>
                                                <td align="center"><%# Eval("SalesText") %></td>
                                                <td align="center"><%# Eval("StatusText") %></td>
                                                <td align="center"><%# Eval("PayStatusText") %></td>
                                                <td align="center"><a onclick="return confirm('您确认要删除该信息吗？删除不可恢复！')" href="/Users/ProductSellingRemove.aspx">删除</a>
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>

                                </tbody>
                            </table>
                        </td>
                    </tr>
                </tbody>
            </table>
            <asp:AspNetPager ID="paging" runat="server" CssClass="fenye clearfix" UrlPageIndexName="p" AlwaysShow="True" UrlPaging="True" NumericButtonCount="10" PageSize="10" AlwaysShowFirstLastPageNumber="True" CurrentPageButtonClass="current" FirstLastButtonsClass="firstlast" FirstPageText="首页" HorizontalAlign="Right" LastPageText="末页" MoreButtonsClass="more" NextPageText="下一页" PageIndexBoxClass="indexbox" PagingButtonsClass="" PagingButtonSpacing="0px" PrevNextButtonsClass="prenext" PrevPageText="上一页" ShowFirstLast="False" SubmitButtonClass="submitbtn" SubmitButtonText="前往"></asp:AspNetPager>
        </form>
    </div>
</asp:Content>
