<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="Wuyiju.Web.Detail" MasterPageFile="~/Site.Master" %>

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
    <div class="main">

        <div class="guide">您现在的位置：<a href="/" title="首页">首页</a>－ <a href="/Article/List.aspx?id=<%=Model.Cate_Id %>"><%=Model.Cate_Name %></a> － <a href="#"><%=Model.Title %></a></div>

        <div id="wrapper">

            <div id="webNoteL" style="border: none;">

                <div id="bulletin1">
                    <h1><%=Model.Title %></h1>
                    <span>发布于：<%=Model.AddDate %> &nbsp;&nbsp;阅读次数：<%=Model.Click %>次</span>
                </div>
                <div id="bulletin2">
                    <%=Model.Info %>
                    <div>
                        <br>
                    </div>
                </div>

                <div id="bulletin3">
                   
                </div>
            </div>

            <div id="webNoteR">

                <div class="webNoteR1">置顶<%=Model.Cate_Name %></div>

                <div class="webNoteR2">
                    <asp:Repeater runat="server" ID="rptTop">
                        <ItemTemplate>
                            <div class="noteNlist">
                                <a href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>"  title="<%# Eval("Title") %>"><%# Eval("Title") %></a>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>

                <div class="webNoteR3"></div>

            </div>

        </div>

    </div>

</asp:Content>
