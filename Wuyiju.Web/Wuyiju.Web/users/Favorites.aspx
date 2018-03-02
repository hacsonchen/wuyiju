<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Favorites.aspx.cs" Inherits="Wuyiju.Web.users.Favorites" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter glzx">


        <div class="WangDianJiLu">
            <ul class="tab-glzx">
                <li><a href="/Users/SellList.aspx" target="_self">我出售的网店</a></li>
                <li><a href="/Users/BoughtList.aspx" target="_self">我购买的网店</a></li>
                <li><a class="cur" href="/user/Favorites.aspx" target="_self">我收藏的网店</a></li>
            </ul>

        </div>

        <table class="tbl tbl-5" width="100%" cellpadding="0" cellspacing="0">

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

                    <th align="left">网店缩率图</th>
                    <th>标题</th>
                    <th>出售价格（元）</th>
                    <th>卖家信用</th>
                    <th>开店时间</th>
                    <th>网店状态</th>
                    <th>操作</th>
                </tr>
                <asp:Repeater runat="server" ID="rptList">
                    <ItemTemplate>
                        <tr>
                                            <th align="left" colspan="9">
                                                <span class="fl">&nbsp;&nbsp;网店编号：<%# Eval("Sn") %>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                                                
                                                <span class="fr">发布时间：<%# Eval("StartTime") %>&nbsp;&nbsp;</span>
                                            </th>
                                        </tr>
                        <tr class="buy">
                            <td align="center">
                                <input type="checkbox" name="conId" value="" disabled="">
                            </td>
                            <td align="center">
                                <a href="/ShowView.aspx?id=<%# Eval("Product_Id") %>">
                                    <img src="/Public/Home/Shops/Images/slogo/0830/slogo_<%# Eval("Type") %>.jpg" border="0">
                                </a>
                            </td>
                            <td align="left">
                                <p><a class="BiaoTi" href="/ShowView.aspx?id=<%# Eval("Product_Id") %>" title="<%# Eval("Pname") %>"><%# Eval("Pname") %></a></p>
                            </td>
                            <td align="center">￥<strong class="price-wd"><%# Eval("Price") %></strong></td>
                            <td align="center"><%# Eval("Seller_Credit") %></td>
                            <td align="center"><%# Eval("AddTime") %></td>
                            <td align="center"><%# Eval("SalesText") %></td>
                            <td align="center">
                                <a class="ahover" id="zhifu" onclick="window.location.href='/user/markorder2/id/83.html';">付款</a>&nbsp;
			                                <a onclick="return confirm('您确认要删除该信息吗？删除不可恢复！')" href="/user/buyedlist/act/del/id/83.html" target="_self">删除</a>

                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>


            </tbody>
        </table>
        <asp:AspNetPager ID="paging" runat="server" CssClass="fenye clearfix" UrlPageIndexName="p" AlwaysShow="True" UrlPaging="True" NumericButtonCount="10" PageSize="10" AlwaysShowFirstLastPageNumber="True" CurrentPageButtonClass="current" FirstLastButtonsClass="firstlast" FirstPageText="首页" HorizontalAlign="Right" LastPageText="末页" MoreButtonsClass="more" NextPageText="下一页" PageIndexBoxClass="indexbox" PagingButtonsClass="" PagingButtonSpacing="0px" PrevNextButtonsClass="prenext" PrevPageText="上一页" ShowFirstLast="False" SubmitButtonClass="submitbtn" SubmitButtonText="前往"></asp:AspNetPager>

    </div>
</asp:Content>
