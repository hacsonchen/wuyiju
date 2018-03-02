<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Wuyiju.Web.Special._20170117.Default" MasterPageFile="~/Site.Master"  %>
<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/news.css" media="all" />
    <!--IE6透明判断-->
    <!--[if IE 6]>

    <script src="../../..\Public\Home\Jq\DD_belatedPNG_0.0.8a-min.js"></script>
    <script>
        DD_belatedPNG.fix('.png_ie6,.flipTransDot');
    </script>

    <![endif]-->
    <script type="text/javascript">
        $().ready(function () {
            showMenuDownList();
        });
    </script>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <table id="__01" width="100%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <img src="images/01.jpg" width="100%" alt=""></td>
        </tr>
        <tr>
            <td>
                <img src="images/02.jpg" width="100%" alt=""></td>
        </tr>
        <tr>
            <td>
                <img src="images/03.jpg" width="100%" alt=""></td>
        </tr>
        <tr>
            <td>
                <img src="images/04.jpg" width="100%" alt=""></td>
        </tr>
        <tr>
            <td style="position: relative">
                <img src="images/05.jpg" width="100%" alt="">
                <a href="http://www.tmallzr.com" title="网店转让" style="position: absolute; display: block; left: 25%; width: 21%; height: 10%; top: 67%"><a>
                    <a href="javascript:;" onclick="ShowAskWin('http://wpa.qq.com/msgrd?v=3&uin=<%=MainKefu %>&site=qq&menu=yes')" title="网店转让" style="position: absolute; display: block; left: 53%; width: 21%; height: 10%; top: 67%"><a></td>
        </tr>
    </table>

</asp:Content>

