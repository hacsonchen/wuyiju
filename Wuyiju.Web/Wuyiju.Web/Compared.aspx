<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compared.aspx.cs" Inherits="Wuyiju.Web.Compared" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/compared.css" media="all" />
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">

    <div id="biyibi" class="wrap">
        <h3 class="biyibi-title">比一比 简单对比 轻松选择</h3>
        <div class="search-box">
            <div class="search-form">
                <form action="/Tmall.aspx" method="get">
                    <input type="text" name="q" placeholder="搜索想要的天猫店铺" />
                    <button type="submit">搜索</button>
                </form>

            </div>
            <div class="clear"></div>
            <div class="search-tags">
                <a class="tags-left" href="/Tmall.aspx">全新店铺热卖 <i class="biyibi-go"></i></a>
                <a class="tags-right" href="/Tmall.aspx">全新店铺热卖 <i class="biyibi-go"></i></a>
            </div>
        </div>
    </div>

    <div id="quick-bi" class="wrap">
        <div class="quick-title">
            <h3 class="biyibi-title">快速对比</h3>
            <p>选猫网全新店铺和其它二手店铺哪个好</p>
        </div>

        <div class="quick-body">
            <div class="quick-shop new-shop">
                <div class="shop-image"></div>
                <h4>全新旗舰店铺</h4>
                <p class="price">￥19万</p>
                <p class="buynow"><a href="/Tmall.aspx">立即购买</a></p>
            </div>
            <div class="pk-area">
                <p><a class="btn-pk" href="#">去PK</a></p>
                <p><a class="btn-random" href="#">随机比较一家二手旗舰店</a></p>
            </div>
            <asp:Loop LoopType="Product" runat="server" Limit="1" IsBest="true">
                <ItemTemplate>
                    <div class="quick-shop used-shop">
                        <div class="shop-image"></div>
                        <h4>二手旗舰店铺</h4>
                        <p class="price">￥<%# Eval("FormatPrice") %></p>
                        <p class="buynow"><a href="/ShopView.aspx?id=<%# Eval("Id") %>">立即购买</a></p>
                    </div>
                </ItemTemplate>
            </asp:Loop>


        </div>

    </div>

    <div class="clear"></div>

    <div id="biyibi-vs">
        <div class="vs-content wrap">
            <a class="btn-vs-buynow" href="#"></a>
        </div>
    </div>

    <div id="biyibi-choose">
        <div class="choose-content wrap">
            <div class="choose-title">
                <h3>帮您挑选</h3>
                <p>花一分让我们了解您的需求</p>
            </div>
            <div class="choose-body">
                <div class="choose-step-title"></div>
                <div id="step1">
                    <h4>1.你理想中心怡的网店？</h4>
                    <ul>
                        <li>
                            <input id="opt1" type="checkbox" /><span></span><label for="opt1"> 旗舰店？</label></li>
                        <li>
                            <input id="opt2" type="checkbox" /><span></span><label for="opt2"> 鞋包服饰类？</label></li>
                        <li>
                            <input id="opt3" type="checkbox" /><span></span><label for="opt3"> 全新店铺/二手店铺？</label></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="biyibi-footer-title wrap"></div>
    </div>

</asp:Content>
