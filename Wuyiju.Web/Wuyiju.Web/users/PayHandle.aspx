<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PayHandle.aspx.cs" Inherits="Wuyiju.Web.users.PayHandle" MasterPageFile="~/users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter xggrzl">
        <div class="revise">
            <span>操作提示</span>
        </div>
        <div class="Tip_layer_MC">
            <% if (!ViewState["Message"].IsNull())
                { %>
            <div class="TipInfo">
                <img src="/Public/Home/Shops/Img/ok_icon.png">
                <strong style="color: #5A701E;">温馨提示：</strong><%=ViewState["Message"] %>！
            </div>
            <%} %>

            <% if (!ViewState["Error"].IsNull())
                { %>
            <div class="TipInfo">
                <img src="/Public/Home/Shops/Img/ok_icon.png">
                <strong style="color: #5A701E;">温馨提示：</strong><%=ViewState["Error"] %>！
            </div>
            <%} %>
            <p class="tc"><a href="/Users/BoughtList.aspx" target="_self">&lt;&lt;查看我购买的网店</a></p>
        </div>

    </div>
</asp:Content>
