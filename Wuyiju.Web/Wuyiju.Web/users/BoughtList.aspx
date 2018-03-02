<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BoughtList.aspx.cs" Inherits="Wuyiju.Web.users.BoughtList" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">

    <div class="con-manageCenter glzx">

          <% if(!Request.QueryString["Message"].IsNull() && !Request.QueryString["Message"].ToString().IsNullOrEmpty()) { %>
        <div class="err" style="width:250px;">
				<div class="icon_1"><%=Request.QueryString["Message"] %></div>                
			</div>
        <% } %>

        <form id="iformss" method="post" action="/Users/BoughtList.aspx">
            <div class="WangDianJiLu">
                <ul class="tab-glzx">
                    <li><a href="/Users/SellList.aspx" target="_self">我出售的网店</a></li>
                    <li><a class="cur" href="/Users/BoughtList.aspx" target="_self">我购买的网店</a></li>
                    <li><a href="/Users/Favorites.aspx" target="_self">我收藏的网店</a></li>
                </ul>
                <div class="state">
                    <span class="fl">交易状态：</span>
                    <div class="input_con select-style1 fr">
                        <select name="pay_status" id="ipay_status" style="width: 100px;" onchange="fytj()">
                            <option value="" <%=(ViewState["type"].TryParseToInt32(-1) == -1? "selected":"" )%>>不限</option>
                            <!--不限为空-->
                            <option value="0" <%=(ViewState["type"].TryParseToInt32(-1) == 0? "selected":"" )%>>等待付款</option>
                            <option value="1" <%=(ViewState["type"].TryParseToInt32(-1) == 1? "selected":"" )%>>已付定金</option>
                            <option value="2" <%=(ViewState["type"].TryParseToInt32(-1) == 2? "selected":"" )%>>已付全款</option>
                            <option value="3" <%=(ViewState["type"].TryParseToInt32(-1) == 3? "selected":"" )%>>交易关闭</option>
                            <option value="4" <%=(ViewState["type"].TryParseToInt32(-1) == 4? "selected":"" )%>>已退款</option>
                        </select>
                    </div>
                    <!--
						<script type="text/javascript">
						xuan("c",document.getElementById("ipay_statu").value);
						</script>
                     -->
                </div>
            </div>

            <table class="tbl tbl-5" width="100%" cellpadding="0" cellspacing="0" border="0">
                <colgroup>
                    <col width="60">
                    <col width="260">
                    <col width="120">
                    <col width="75">
                    <col width="95">
                    <col width="85">
                    <col width="105">
                </colgroup>
                <tbody>
                    <tr>
                        <th width="60">编号<!--<input class="QuanXuan" type="checkbox" name="checkbox1" id="checkbox1" onclick="hbCollecselect()" />全选--></th>

                        <th align="left">网店缩率图/标题</th>
                        <th>出售价格</th>
                        <th>消保金额</th>
                        <th>销售状态</th>
                        <th>交易状态</th>
                        <th>操作</th>
                    </tr>
                    <input type="hidden" name="sn" id="isn" value="1604140904960">
                    <input type="hidden" name="status" id="status" value="1">

                    <tr>
                        <td colspan="7">
                            <table class="tbl-5-in" width="100%" cellpadding="0" cellspacing="0" border="0">
                                <colgroup>
                                    <col width="60">
                                    <col width="110">
                                    <col width="150">
                                    <col width="120">
                                    <col width="75">
                                    <col width="95">
                                    <col width="85">
                                    <col width="105">
                                </colgroup>
                                <tbody>
                                    <asp:Repeater runat="server" ID="rptList">
                                        <ItemTemplate>
                                            <tr>
                                                <th align="left" colspan="8">
                                                    <span class="fl">&nbsp;&nbsp;订单编号：<%# Eval("Sn") %><a onclick="window.location.href='/Users/OrderView.aspx?id=<%# Eval("Id") %>';">【订单信息】</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;生成时间：<%# Eval("AddDate") %></span>

                                                    <span id="rest" class="fr ">截止日期：<%# Eval("RestTime","{0:yyyy-MM-dd HH:mm}") %></span>
                                                </th>
                                            </tr>

                                            <tr class="buy">
                                                <td align="center">
                                                    <input type="checkbox" name="conId" value="" disabled="">
                                                </td>
                                                <td align="center">
                                                    <a href="/ShopView.aspx?id=<%# Eval("Product_Id") %>">
                                                        <img src="/Public/Home/Shops/Images/slogo/0830/slogo_<%# Eval("Type") %>.jpg" border="0">
                                                    </a>
                                                </td>
                                                <td align="left">
                                                    <p>店铺名：<a class="BiaoTi" href="/ShopView.aspx?id=<%# Eval("Product_Id") %>" title="<%# Eval("Pname") %>"><%# Eval("Pname") %></a></p>
                                                </td>
                                                <td align="center">出售价格：￥<strong class="price-wd"><%# Eval("Price") %></strong></td>
                                                <td align="center">保证金：￥<strong class="price-wd"><%# Eval("Ensure") %></strong><br>
                                                    <br>
                                                    技术年费(￥<strong class="price-wd"><%# Eval("Techfee") %></strong>)</td>
                                                <td align="center"><%# Eval("SalesText") %></td>
                                                <td align="center"><%# Eval("PayStatusText") %></td>
                                                <td align="center">
                                                    <%# Eval("Pay_Statu").TryParseToInt32(0) > 1 ? "":"<a class=\"ahover\" id=\"zhifu\" onclick=\"window.location.href='/Users/OrderView.aspx?id=" + Eval("Id") + "';\">付款</a>" %>
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
