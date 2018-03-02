<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="See.aspx.cs" Inherits="Wuyiju.Web.See" %>

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" charset="UTF-8" content="width=device-width" />
    <title>看一看 实时关注行业动态 知己知彼 百战不殆</title>
    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/iconfont.css" media="all" />
    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/see.css" media="all" />
</head>
<body>
    <div class="header-content">
        <div>
            <img src="/Public/Home/Shops/Images/%E7%9C%8B%E4%B8%80%E7%9C%8B.png" />
            <span>实时关注行业动态 知己知彼 百战不殆</span>
        </div>
    </div>

    <div class="site-content">
        <div class="left-content">
            <div class="left-top-contain">
                <asp:Loop LoopType="Article" CatId="6" Limit="1" runat="server" ID="Loop4">
                    <ItemTemplate>
                        <a href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>" class="art-title"><%# Eval("Title") %></a>
                        <span class="art-content"><%# Eval("Brief") %></span>
                    </ItemTemplate>
                </asp:Loop>
            </div>
            <div class="left-middle-contain">
                <ul>
                    <asp:Loop LoopType="Article" CatId="6" Limit="15" runat="server" ID="Loop3">
                        <ItemTemplate>
                            <li>
                                <a class="Awidth1" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>"><b></b><span class="span-suoxie"><%# Eval("Title") %></span> [<%# Eval("AddDate","{0:yyyy/MM/dd}") %>] </a>
                            </li>
                        </ItemTemplate>
                    </asp:Loop>
                </ul>
            </div>
            <div class="left-bottom-contain">
                <div class="left-left-bottom-contain">
                    <div class="bottom-contain-title">
                        <span>市场营销</span>
                    </div>
                    <div class="bottom-contain-content">
                        <ul>
                            <asp:Loop LoopType="Article" CatId="21" Limit="9" runat="server" ID="Loop1">
                                <ItemTemplate>
                                    <li>
                                        <a class="Awidth1 content-suoxie" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>"><b></b><%# Eval("Title") %></a>
                                    </li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
                <div class="right-left-bottom-contain">
                    <div class="bottom-contain-title">
                        <span>淘宝资讯</span>
                    </div>
                    <div class="bottom-contain-content">
                        <ul>
                            <asp:Loop LoopType="Article" CatId="23" Limit="9" runat="server" ID="Loop2">
                                <ItemTemplate>
                                    <li>
                                        <a class="Awidth1 content-suoxie" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>"><b></b><%# Eval("Title") %> </a>
                                    </li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class="right-content">
            <div class="right-top-contain">
                <div class="right-top-top-contain">
                    <div class="right-top-top-contain-title">
                        <span>淘宝营销</span>
                    </div>
                    <div class="right-top-top-contain-xiangqing">
                        <asp:Loop LoopType="Article" CatId="22" Limit="1" runat="server" ID="Loop6">
                            <ItemTemplate>
                                <span class="foot-art-title "><%# Eval("Title") %></span>
                                <span class="foot-art-content xianzhi-length"><%# Eval("Brief") %></span><a class="foot-art-des xianzhi-length-add" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>">详细>></a>
                            </ItemTemplate>
                        </asp:Loop>
                    </div>
                    <div class="right-top-top-contain-ul">
                        <ul>
                            <asp:Loop LoopType="Article" CatId="22" Limit="6" runat="server" ID="Loop7">
                                <ItemTemplate>
                                    <li class="right-top-bottom-contain-li">
                                        <a class="Awidth1 suoxie" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>"><%# Eval("Title") %> </a>
                                    </li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
                <div class="right-top-bottom-contain">
                    <div class="right-top-bottom-contain-title">
                        <span>互联网</span>
                    </div>
                    <div class="right-top-bottom-contain-xiangqing">
                        <asp:Loop LoopType="Article" CatId="14" Limit="1" runat="server" ID="Loop8">
                            <ItemTemplate>
                                <span class="foot-art-title "><%# Eval("Title") %></span>
                                <span class="foot-art-content xianzhi-length"><%# Eval("Brief") %></span><a class="foot-art-des xianzhi-length-add " href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>">详细>></a>
                            </ItemTemplate>
                        </asp:Loop>
                    </div>
                    <div class="right-top-bottom-contain-ul">
                        <ul>
                            <asp:Loop LoopType="Article" CatId="14" Limit="6" runat="server" ID="Loop9">
                                <ItemTemplate>
                                    <li class="right-top-bottom-contain-li">
                                        <a class="Awidth1 suoxie" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>"><%# Eval("Title") %> </a>
                                    </li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="right-bottom-contain">
                <img src="/Public/Home/Shops/Images/%E5%B9%BF%E5%91%8A.png" width="267" />
                <div class="choose-store-leibie">
                    <asp:Loop LoopType="Category" CatId="0" ID="CategoryTree" Start="0" Limit="9" runat="server">
                        <ItemTemplate>
                            <div class="choose-store-leibie-children">
                                <i class="icon iconfont icon-menu-<%# Eval("Id") %>"></i>
                                <a href="#"><%# Eval("Name") %></a>
                            </div>
                        </ItemTemplate>
                    </asp:Loop>
                </div>
            </div>
        </div>
    </div>
    <div class="clear"></div>
    <div class="foot-content">
        <asp:Loop LoopType="Article" CatId="6" Limit="2" runat="server" ID="Loop5">
            <ItemTemplate>
                <span class="foot-art-title"><%# Eval("Title") %></span>
                <span class="foot-art-content xianzhi-length"><%# Eval("Brief") %></span><a class="foot-art-des  xianzhi-length-add" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>">[详情]</a>
            </ItemTemplate>
        </asp:Loop>
    </div>
    <script src="Public/Home/Jq/jquery-1.6.4.min.js"></script>
    <script type="text/javascript">
        $(function () {
            var str = $('.xianzhi-length').html();
            var _str = $('.xianzhi-length-add').prop('outerHTML');
            $('.xianzhi-length-add').remove();
            if (str.length > 55) {
                str = str.substring(0, 55) + "...";
            }
            $('.xianzhi-length').html(str + _str);
            $('.suoxie').each(function () {
                var newstr = $(this).html();
                if (newstr.length > 13) {
                    newstr = newstr.substring(0, 13) + "...";
                }
                $(this).html(newstr);
            })

            $('.content-suoxie').each(function () {
                var newstr = $(this).html();
                if (newstr.length > 17) {
                    newstr = newstr.substring(0, 17) + "...";
                }
                $(this).html(newstr);
            })

            $('.span-suoxie').each(function () {
                var newstr = $(this).html();
                if (newstr.length > 15) {
                    newstr = newstr.substring(0, 15) + "...";
                }
                $(this).html(newstr);
            })

        })

    </script>
</body>

</html>
