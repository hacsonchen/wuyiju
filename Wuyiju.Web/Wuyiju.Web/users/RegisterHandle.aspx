<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterHandle.aspx.cs" Inherits="Wuyiju.Web.users.RegisterHandle" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/user.css" media="all"/>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="Win">
        <div class="title">
            <h1>注册成功</h1>
        </div>
        <div class="Win-XinXi">
            <div class="ZC-Left">
                <img src="/Public/Home/Shops/Images/reg/ZC-chenggong.jpg"/>
            </div>

            <div class="ZC-Right">
                <ul>
                    <li><strong>恭喜，<span><%=Model.Name %></span> 已注册成功！</strong></li>
                    <li><a href="/">
                        <img src="/Public/Home/Shops/Images/reg/ZC-jinshouye.jpg"></a><a href="/Users/"><img src="/Public/Home/Shops/Images/reg/ZC-guanli.jpg"></a></li>
                    <li>
                        <p>您的手机号码：<span><%=Model.Mobile %></span> 将用于找回密码、认购与发布网店！</p>
                        <p>请不要向他人透露您的手机号码与密码！</p>
                    </li>
                    <li class="fence"><span>超过90%的用户选择了填写安全设置，账户更安全网店交易更放心<a href="/Users/AuthMobile.aspx"><img src="/Public/Home/Shops/Images/reg/ZC-anquanshezhi.jpg" style="cursor: pointer;" border="0"></a></span></li>
                </ul>
            </div>
        </div>
    </div>
    <div class="clear mb10"></div>
</asp:Content>
