<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShopsTransferType.aspx.cs" Inherits="Wuyiju.Web.users.ShopsTransferType" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter glzx">
        <div class="titleSelection">
            <img src="/Public/Home/Shops/Images/seller_1/selection_03.png" />
        </div>
        <ul class="listSelection">
            <asp:Loop LoopType="Attribute" CatId="0" runat="server">
                <ItemTemplate>
                    <li><a href="<%# Eval("Id","/Users/shopstransfersubmit.aspx?pid={0}") %>"" target="_self">
                        <img src="<%# Eval("Id","/Public/Home/Shops/Images/seller_1/selection_{0}.png") %>" alt="<%# Eval("Name") %>"><p><%# Eval("Name") %></p>
                    </a></li>
                </ItemTemplate>
            </asp:Loop>
        </ul>
    </div>
</asp:Content>
