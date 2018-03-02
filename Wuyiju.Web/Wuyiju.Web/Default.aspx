<%@ Page Title="【选猫网-自有网店出售平台】一手直转|专注于天猫网店转让,天猫新店转让,国内网店转让资深可靠品牌" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Wuyiju.Web.Default" MasterPageFile="~/Site.Master" %>

<%@ Register TagPrefix="asp" TagName="WebMenu" Src="~/UserControls/WebMenu.ascx" %>
<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/index.css" media="all" />
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/index2.css" media="all" />
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/iconfont.css" media="all" />

    <link rel="stylesheet" type="text/css" href="Public/Home/Shops/Css/focusStyle.css" media="all" />
    <script type="text/javascript" src="/Public/Home/Shops/layer/layer.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/Js/index.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/Js/jquery.cookie.js"></script>

    <script type="text/javascript">

        function getPhoto(getval) {

            var htm = "<div id='getPh' class='getPh'></div>";

            if (getval == "1") {
                $("body").append(htm);
                $("#jianz").css("display", "block");
                //增加外层div透明背景色:
                $("#getPh").css({ "width": $(document).width(), "height": $(document).height() });
                //为弹出框居中显示:
                $("#jianz").css({ "left": ($(document).width() - $("#jianz").width() - 10) / 2, "top": "160px" });
                //绑定关闭事件:
                $("#closePHoto").click(function () {
                    $("#getPh").remove();
                    $("#jianz").css("display", "none");
                });

                setTimeout("$('#getPh').remove();$('#jianz').css('display','none');", 15000);
            }

        }

        $(document).ready(function () {
            showMenuDownList();
            $("#close").click(function () {
                $.cookie('reid', 'ishide', { expires: 1, path: '/' });
                $("#tips").hide();
            });



            $("#newyu li,#right-menu li").mouseenter(function () {


                $("#newyu li,#right-menu li").removeClass('cur');
                $(this).addClass("cur");
                $(this).find("a").animate({ marginLeft: +10 });
                var catid = $(this).data('cat');
                var $yinchang = $("#" + catid);
                var inde = $(this).index();


                if (inde <= 1) {
                    $yinchang.css("display", "none");
                    var num = 352;
                    var num2 = 0 - 35 * inde;
                    var $jihe = $("#newyu li strong,#right-menu li strong");
                    if ($(this).hasClass('left')) {
                        $yinchang.css({ "top": num, "left": 145 }).fadeIn(500);
                    } else {
                        $yinchang.css({ "top": num, "right": 145 }).fadeIn(500);
                    }
                    $jihe.eq(inde).css({ "background-repeat": " no-repeat", "background-position-y": num2 });
                    $jihe.eq(inde).addClass("strong" + inde);

                } else {

                    $yinchang.css("display", "none");

                    var num = 360 + (inde - 2) * 35;

                    var num2 = 0 - 35 * inde;

                    var $jihe = $("#newyu li strong,#right-menu li strong");

                    //$yinchang.css({ "display": "block", "top": num });
                    if ($(this).hasClass('left')) {
                        $yinchang.css({ "top": num, "left": 145 }).fadeIn(500);
                    } else {
                        $yinchang.css({ "top": num, "right": 145 }).fadeIn(500);
                    }
                    $jihe.eq(inde).css({ "background-repeat": " no-repeat", "background-position-y": num2 });

                    $jihe.eq(inde).addClass("strong" + inde);

                }

            }).mouseleave(function () {
                //$(this).siblings().find("a").stop(true).css({ marginLeft :0});
                //var $a = $(this).find("a");
                //$a.css({ marginLeft: 0 });

                var $a = $("#newyu li,#right-menu li").find("a");
                $a.css({ marginLeft: 0 }).stop(true);

            });

            $(".YinCang").mouseenter(function () {
                $(this).show();
                var inde = $(this).index();
                $("#newyu li,#right-menu li").eq(inde - 1).addClass("cur");
            });

            $(".YinCang").mouseleave(function () {
                $(this).hide();
                $("#newyu li,#right-menu li").removeClass("cur");
            });

            $("#newyu li,#right-menu li").mouseleave(function () {
                $(".YinCang").hide();
                $("#newyu li,#right-menu li").removeClass("cur");
            });
            //切换
            $("#hd_tmall li").hover(function () {

                $(this).addClass("hover");

                $(this).siblings().removeClass("hover");

                var index = $("#hd_tmall li").index(this);

                $("#bd_tmall .index_li_div").eq(index).show();

                $("#bd_tmall .index_li_div").eq(index).siblings().hide();

            });

            if ($(this).width() <= 1200) {

                scrollBann2();

            }

            $('div.shop-show').mouseenter(function () {
                $(this).find('.shop-image').animate({ paddingLeft: +10 }).animate({ paddingLeft: -10 });
            });



            window.setTimeout(function () {
                $('#sidebar-helper').animate({ right: -123 }, 300);

                $('#sidebar-helper').mouseenter(function () {
                    if (!$(this).hasClass('show')) {
                        $(this).stop().animate({ right: 0 }, 300);
                        //$(this).parent().hide();
                        $(this).addClass('show');
                    }
                });

                $('#btn-sidebar-helper').click(function () {
                    if ($(this).hasClass('show')) {
                        $('#sidebar-helper').animate({ right: -123 }, 300);
                        $(this).removeClass('show');
                    } else {
                        $('#sidebar-helper').animate({ right: 0 }, 300);
                        $(this).addClass('show');
                    }
                });

                $('#sidebar-helper').mouseleave(function () {
                    if ($(this).hasClass('show')) {
                        $(this).stop().animate({ right: -123 }, 300);
                        $(this).removeClass('show');

                    }
                });

            }, 10000);




            //var $kefu = $('#main-kefu');
            var kefu_time = $.cookie('__kefu__');

            var $kefu = $('#main-kefu');
            $kefu.fadeIn(2000);
            $kefu.mouseenter(function () {
                $(this).stop().show().animate({ 'opacity': 1 });
            });
            $kefu.mouseleave(function () {
                $(this).animate({ 'opacity': 0.9 });
            });

            if (!kefu_time) {

                var now = new Date();
                now.setTime(now.getTime() + (5 * 60 * 1000));
                $.cookie('__kefu__', now.getTime(), { path: '/', expires: 1 });
                var $kefu = $('#main-kefu');
                $kefu.fadeIn(2000);
                $kefu.mouseenter(function () {
                    $(this).stop().show().animate({ 'opacity': 1 });
                });
                $kefu.mouseleave(function () {
                    $(this).animate({ 'opacity': 0.9 });
                });
            } else {
                var now = new Date().getTime();
                if (now > kefu_time) {
                    var now = new Date();
                    now.setTime(now.getTime() + (15 * 60 * 1000));
                    $.cookie('__kefu__', now, { path: '/', expires: 1 });
                    var $kefu = $('#main-kefu');
                    $kefu.fadeIn(2000);
                    $kefu.mouseenter(function () {
                        $(this).stop().show().animate({ 'opacity': 1 });
                    });
                    $kefu.mouseleave(function () {
                        $(this).animate({ 'opacity': 0.9 });
                    });
                }
            }

            $('#main-kefu-close').click(function () {
                $kefu.fadeOut(500);
            });


        });
    </script>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div id="focus-banner">
        <ul id="focus-banner-list" style="height: 350px">
            <asp:Loop LoopType="Advertisement" runat="server" AdType="index_scroll">
                <ItemTemplate>
                    <li onclick="window.open('<%# Eval("Url")%>')">
                    <a href="<%# Eval("Url")%>" class="focus-banner-img" style="background: url(http://image.tmallzr.com/<%# Eval("Thumb")%>) center center no-repeat">
                    </a>
                    <div class="focus-banner-text">
                    </div>
                </li>
                </ItemTemplate>
            </asp:Loop>


        </ul>
        <a href="javascript:;" id="next-img" class="focus-handle"></a>
  
<a href="javascript:;" id="prev-img" class="focus-handle"></a>
<a href="javascript:;" id="prev-img" class="focus-handle"></a>
<a href="javascript:;" id="prev-img" class="focus-handle"></a>
        <ul id="focus-bubble"></ul>
    </div>
    <script>
        $(function () {
            var focusBanner = function () {
                var $focusBanner = $("#focus-banner"),
					$bannerList = $("#focus-banner-list li"),
					$focusHandle = $(".focus-handle"),
					$bannerImg = $(".focus-banner-img"),
					$nextBnt = $("#next-img"),
					$prevBnt = $("#prev-img"),
					$focusBubble = $("#focus-bubble"),
					bannerLength = $bannerList.length,
					_index = 0,
					_timer = "";

                var _height = $(".focus-banner-img").find("img").height();
                $focusBanner.height(_height);
                $bannerImg.height(_height);



                for (var i = 0; i < bannerLength; i++) {
                    $bannerList.eq(i).css("zIndex", bannerLength - i);
                    $focusBubble.append("<li></li>");
                }
                $focusBubble.find("li").eq(0).addClass("current");
                var bubbleLength = $focusBubble.find("li").length;
                $focusBubble.css({
                    "width": bubbleLength * 22,
                    "marginLeft": -bubbleLength * 11
                });//初始化

                $focusBubble.find('li').click(function () {
                    $(this).addClass("current").siblings().removeClass("current");
                    _index = $(this).index();
                    changeImg(_index);
                });//点击轮换

                $nextBnt.click(function () {
                    _index++
                    if (_index > bannerLength - 1) {
                        _index = 0;
                    }
                    changeImg(_index);
                });//下一张

                $prevBnt.click(function () {
                    _index--
                    if (_index < 0) {
                        _index = bannerLength - 1;
                    }
                    changeImg(_index);
                });//上一张

                function changeImg(_index) {
                    $bannerList.eq(_index).fadeIn(250);
                    $bannerList.eq(_index).siblings().fadeOut(200);
                    $focusBubble.find("li").removeClass("current");
                    $focusBubble.find("li").eq(_index).addClass("current");
                    clearInterval(_timer);
                    _timer = setInterval(function () { $nextBnt.click() }, 5000)
                }//切换主函数
                _timer = setInterval(function () { $nextBnt.click() }, 5000)
            }();
        })
    </script>
    <div class="wrap">
        <div class="xyquan">
            <!--index_category_tree S -->
            <div class="quanzuo">
                <ul id="newyu">
                    <asp:Loop LoopType="Category" CatId="0" ID="CategoryTree" Start="0" Limit="8" runat="server">
                        <ItemTemplate>
                            <li class="left" data-cat="cat_<%# Eval("Id") %>">
                                <a href="javascript:void(0);">
                                    <%--<strong class="<%# Eval("Css_Cla") %>"></strong>--%>
                                    <i class="iconfont icon icon-menu-<%# Eval("Id") %>"></i><%# Eval("Name") %>
                                </a>
                            </li>
                        </ItemTemplate>
                    </asp:Loop>
                </ul>
            </div>

            <asp:WebMenu runat="server" />
            <!--index_category_tree end-->
            <%--<div class="quanzhong">
                <div class="bann1" id="carousellist" style="overflow: hidden; position: relative;">
                    <div class="pic-box slider" id="playcarouse" style="position: absolute; left: 0px; top: 0px;">

                        <asp:Loop LoopType="Advertisement" AdType="index_scroll" Type="image" Limit="5" runat="server" ID="rptBanner">
                            <ItemTemplate>
                                <p>
                                    <a href="<%# Eval("Url") %>" title="<%# Eval("Name") %>" style="background-image: url('<%# Eval("Thumb")%>')"></a>
                                </p>
                            </ItemTemplate>
                        </asp:Loop>
                    </div>
                    <ul class="num" id="numID">
                        <asp:Loop LoopType="Advertisement" AdType="index_scroll" Type="image" runat="server" ID="Loop1">
                            <ItemTemplate>
                                <li></li>
                            </ItemTemplate>
                        </asp:Loop>
                    </ul>
                </div>
                <div class="bann2" style="width: 891px;">
                    <ul id="b2_in_list">
                        <asp:Loop LoopType="Advertisement" AdType="index_scroll_under" Type="image" runat="server" ID="Loop2">
                            <ItemTemplate>
                                <li class="bann3">
                                    <a href="<%# Eval("Url") %>">
                                        <img src="<%# Eval("Thumb")%>" alt="<%# Eval("Name") %>" border="0" width="250" height="160" />
                                    </a>
                                </li>
                            </ItemTemplate>
                        </asp:Loop>
                    </ul>
                </div>
            </div>--%>
            <div class="quanyou">
                <ul id="right-menu">
                    <asp:Loop LoopType="Category" CatId="0" ID="Loop1" Start="8" Limit="8" runat="server">
                        <ItemTemplate>
                            <li class="right" data-cat="cat_<%# Eval("Id") %>">
                                <a href="javascript:void(0);">
                                    <%--<strong class="<%# Eval("Css_Cla") %>"></strong>--%>
                                    <i class="iconfont icon icon-menu-<%# Eval("Id") %>"></i><%# Eval("Name") %>
                                </a>
                            </li>
                        </ItemTemplate>
                    </asp:Loop>
                </ul>
                <%--<div class="quanyou-s">
                    <input type="button" class="xyinp" value="登录" onclick="window.open('/Users/login.aspx', '', '')" />
                    <input type="button" class="xyinp xyinp1" value="注册" onclick="window.open('/Users/register.aspx', '', '')" />
                </div>
                <div class="quanyou-s1">
                    <a href="#" rel="nofollow">
                        <img src="Public/Home/Shops/Images/1506/1c00_03_2.png" border="0" />
                    </a>
                </div>
                <div class="quanyou-s1" style="margin-top: 0px;">
                    <dl>
                        <dt></dt>
                        <dd class="bl">
                            <a href="javascript:;" rel="nofollow">开创模式
                            </a>
                        </dd>
                        <dd>选猫网首创了网店转让模式
                        </dd>
                    </dl>
                    <dl class="xybi">
                        <dt class="dt1"></dt>
                        <dd class="bl">
                            <a href="javascript:;" rel="nofollow">规模领先
                            </a>
                        </dd>
                        <dd>目前全国有六家全资公司
                        </dd>
                    </dl>
                    <dl>
                        <dt class="dt2"></dt>
                        <dd class="bl">
                            <a href="javascript:;" rel="nofollow">数量领先
                            </a>
                        </dd>
                        <dd>拥有待售中的网店上万家
                        </dd>
                    </dl>
                    <dl class="xybi">
                        <dt class="dt3"></dt>
                        <dd class="bl">
                            <a href="javascript:;" rel="nofollow">交易量大
                            </a>
                        </dd>
                        <dd>已经出售店铺超过三万家
                        </dd>
                    </dl>
                    <dl>
                        <dt class="dt4"></dt>
                        <dd class="bl">
                            <a href="javascript:;" rel="nofollow">多方认证
                            </a>
                        </dd>
                        <dd>获得七家第三方机构认证
                        </dd>
                    </dl>--%>
            </div>
            <%--<div class="quanyou-s1">
                    <ul>
                        <li id="iggli" class="cur" style="left: 0px;">
                            <a href="#" onmouseover="zxshow(1)">网站公告
                            </a>
                        </li>
                        <li id="izxli" style="right: 0px;">
                            <a href="#" onmouseover="zxshow(2)">行业资讯
                            </a>
                        </li>
                    </ul>
                </div>--%>
            <%--<div class="xyxian">
                    <ul id="iwzggs">
                        <asp:Loop LoopType="Article" CatId="43" runat="server" ID="GongGao">
                            <ItemTemplate>
                                <li>
                                    <a class="Awidth1" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>" title="<%# Eval("Title") %>"><%# Eval("Title") %>
                                    </a>
                                    <span><%# Eval("AddDate","{0:MM-dd}") %>
                                    </span>
                                </li>
                            </ItemTemplate>
                        </asp:Loop>
                    </ul>
                    <ul id="ihyzxs" class="hyzx" style="display: none">
                        <asp:Loop LoopType="Article" CatId="44" runat="server" ID="Zixun">
                            <ItemTemplate>
                                <li>
                                    <a class="Awidth2" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>" title="<%# Eval("Title") %>"><%# Eval("Title") %>
                                    </a>
                                </li>
                            </ItemTemplate>
                        </asp:Loop>
                    </ul>
                </div>--%>
        </div>
    </div>

    <div class="clear"></div>
    <div class="like-wrap wrap">
        <div class="i-like-it">
            <h3>喜欢这个网站</h3>
            <a class="btn-like" href="javascript:;" id="btn-like">点个赞</a>
            <p>（已有<i id="like-count">3389</i>位商家赞过）</p>
        </div>
        <div class="qq-validate">
            <h3>客服QQ检验</h3>
            <div class="qq-validate-input">
                <input id="txt-valid-qq" type="text" />
                <button id="btn-valid-qq">验证</button>
            </div>
            <p class="share-friends">
                <span>分享给朋友</span>
                <a class="weibo" href="#"></a>
                <a class="qqwb" href="#"></a>
                <a class="qzone" href="#"></a>
                <a class="qq" href="#"></a>
                <a class="renren" href="#"></a>
                <a class="weixin" href="#"></a>
            </p>
        </div>
    </div>
    <div class="clear"></div>
    <%--    <div class="wrap">

        <div class="ensure-title"></div>
    </div>--%>
    <div class="wrap">
        <div class="goods-row">
            <div class="goods-col left">
                <asp:Loop LoopType="Product" runat="server" Limit="1" IsNew="1" IsBest="True">
                    <ItemTemplate>
                        <div class="best-show  ">
                            <div class="best-info">
                                <h3>全新店铺</h3>
                                <h3><a target="_blank" href="/ShopView.aspx?id=<%# Eval("Id") %>">[<%# Eval("Name") %>]</target="_blank"> </h3>
                                <p>店铺类型： <%# Eval("MallType") %></p>
                                <%--<p>动态评分 <%# Eval("ScoreValue") %></p>
                                <p>创店时间 <%# Eval("StartTime","{0:yyyy-MM}") %></p>--%>
                                <p style="min-height:18px;height:auto;width:200px">一级类目： <%# ((string)Eval("Categories")).Trim(',') %></p>
                                <p>所在地区： <%# Eval("Area") %></p>
                                <p>商标分类： <%# Eval("Trademark") %></p>
                                <p class="price">￥<%# Eval("FormatPrice") %></p>
                                <a class="btn-buynow" href="/ShopView.aspx?id=<%# Eval("Id") %>">立即秒杀</a>
                                <p class="description">秒杀店铺限时物价中</p>
                            </div>
                            <div class="best-image">
                                <img src="Public/Home/Shops/Images/Category/big-cat-<%# Eval("Category_Id") %>.png" height="238" alt="<%# Eval("Name") %>"/>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Loop>

            </div>
            <div class="goods-col">
                <asp:Loop LoopType="Product" runat="server" Limit="1" IsNew="1" IsHot="1">
                    <ItemTemplate>
                        <div class="best-show  ">
                            <div class="best-info">
                                <h3>全新店铺</h3>
                                <h3><a target="_blank" href="/ShopView.aspx?id=<%# Eval("Id") %>">[<%# Eval("Name") %>]</a></h3>
                                <p>店铺类型： <%# Eval("MallType") %></p>
                                <%--<p>动态评分 <%# Eval("ScoreValue") %></p>
                                <p>创店时间 <%# Eval("StartTime","{0:yyyy-MM}") %></p>--%>
                                <p style="min-height:18px;height:auto;width:200px">一级类目： <%# ((string)Eval("Categories")).Trim(',') %></p>
                                <p>所在地区： <%# Eval("Area") %></p>
                                <p>商标分类： <%# Eval("Trademark") %></p>
                                 <p class="price">￥<%# Eval("FormatPrice") %></p>
                                <a class="btn-buynow" href="/ShopView.aspx?id=<%# Eval("Id") %>">立即秒杀</a>
                                <p class="description">秒杀店铺限时物价中</p>
                            </div>
                            <div class="best-image">
                                <img src="Public/Home/Shops/Images/Category/big-cat-<%# Eval("Category_Id") %>.png" height="238" alt="<%# Eval("Name") %>"/>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Loop>
            </div>
            <div class="clear"></div>
        </div>
        <div class="clear"></div>
        <div class="goods-row">
            <div class="goods-col left">
                <div class="goods-show left red">
                    <div class="goods-head">
                        <h3>公开名字店铺 特惠出售中</h3>
                        <p>交易透明 各类型天猫旗舰店应有尽有 安全快捷</p>
                    </div>
                    <div class="goods-body">
                        <ul class="goods-list">
                            <asp:Loop LoopType="Product" runat="server" Limit="3" IsBest="true">
                                <ItemTemplate>
                                    <li>
                                        <span><i>￥</i><%# Eval("FormatPrice") %></span>
                                        <strong><%# Eval("Category_Name") %></strong>
                                    </li>
                                </ItemTemplate>
                            </asp:Loop>

                        </ul>
                        <a target="_blank" href="/Tmall.aspx" class="goods-buynow">立即购买</a>
                    </div>
                </div>
            </div>
            <div class="goods-col">
                <div class="goods-show yellow">
                    <div class="goods-head">
                        <h3>精品店铺 特惠出售中</h3>
                        <p>交易透明 各类型天猫旗舰店应有尽有 安全快捷</p>
                    </div>
                    <div class="goods-body">
                        <ul class="goods-list">
                            <asp:Loop LoopType="Product" runat="server" Limit="3" Recommend="true">
                                <ItemTemplate>
                                    <li>
                                        <span><i>￥</i><%# Eval("FormatPrice") %></span>
                                        <strong><%# Eval("Category_Name") %></strong>
                                    </li>
                                </ItemTemplate>
                            </asp:Loop>

                        </ul>
                        <a target="_blank" href="/Tmall.aspx" class="goods-buynow">立即购买</a>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
        </div>
        <div class="clear"></div>

        <div class="goods-row">
            <div class="goods-col left">
                <div class="goods-more">
                    <div class="more-head">
                        <h3>选猫网会员权益<a href="javascript:;"><i class="icon if-others">&#xe608;</i>了解详情</a></h3>
                    </div>
                    <div class="more-body red">
                    </div>
                </div>
            </div>
            <div class="goods-col">
                <div class="goods-more">
                    <div class="more-head">
                        <h3>选猫网会员权益<a href="javascript:;"><i class="icon if-others">&#xe608;</i>了解详情</a></h3>
                    </div>
                    <div class="more-body yellow">
                    </div>
                </div>
            </div>
            <div class="clear"></div>
        </div>
        <%--<!--index_recommend_category S -->
        <div class="index_list tmall" style="margin-top: 15px;">
            <div class="title_wrap">
                <i></i>
                <ul id="hd_tmall">
                    <li class="hover">
                        <a href="mall/tmall.aspx">全部
                        </a>
                    </li>
                    <asp:Loop LoopType="Category" Recommend="True" runat="server">
                        <ItemTemplate>
                            <li>
                                <a href="/tmall.aspx"><%# Eval("Name") %>
                                </a>
                            </li>
                        </ItemTemplate>
                    </asp:Loop>
                </ul>
            </div>
            <div id="bd_tmall">
                <div class="index_li_div" style="">
                    <div class="index_li_left">
                        <img src="Public/Home/Shops/Img/index_list_01.jpg">
                    </div>
                    <div class="index_li_right">
                        <asp:Loop runat="server" LoopType="Product" Type="2" CatId="1" Limit="9">
                            <ItemTemplate>
                                <a href="ShopView.aspx?id=<%# Eval("Id") %>">
                                    <div class="index_li">
                                        <h2>
                                            <img src="Public/Home/Shops/Img/tmlogo.jpeg">
                                            &nbsp;&nbsp;<%# Eval("Name") %>
                                        </h2>
                                        <p>
                                            类型：
                      <span><%# Eval("MallType") %>
                      </span>
                                            商标：
                      <span>R 标（第0类）
                      </span>
                                        </p>
                                        <p>
                                            售价：
                      <em>￥<%# Eval("Price") %>
                      </em>
                                        </p>
                                    </div>
                                </a>
                            </ItemTemplate>
                        </asp:Loop>
                    </div>
                    <div class="clear">
                    </div>
                </div>
                <div class="index_li_div" style="display: none;">
                    <div class="index_li_left">
                        <img src="Public/Home/Shops/Img/index_list_01.jpg">
                    </div>
                    <div class="index_li_right">
                        <a href="mall/shopsGet/id/7.html">
                            <div class="index_li">
                                <h2>
                                    <img src="Public/Home/Shops/Img/tmlogo.jpeg">
                                    &nbsp;&nbsp;服装淘宝店
                                </h2>
                                <p>
                                    类型：
                      <span>旗舰店
                      </span>
                                    商标：
                      <span>TM标（第25类）
                      </span>
                                </p>
                                <p>
                                    售价：
                      <em>￥120000.00
                      </em>
                                </p>
                            </div>
                        </a>
                        <a href="mall/shopsGet/id/6.html">
                            <div class="index_li">
                                <h2>
                                    <img src="Public/Home/Shops/Img/tmlogo.jpeg">
                                    &nbsp;&nbsp;天猫服装
                                </h2>
                                <p>
                                    类型：
                      <span>旗舰店
                      </span>
                                    商标：
                      <span>R 标（第25类）
                      </span>
                                </p>
                                <p>
                                    售价：
                      <em>￥150000.00
                      </em>
                                </p>
                            </div>
                        </a>
                    </div>
                    <div class="clear">
                    </div>
                </div>
                <div class="index_li_div" style="display: none;">
                    <div class="index_li_left">
                        <img src="Public/Home/Shops/Img/index_list_01.jpg">
                    </div>
                    <div class="index_li_right">
                        <a href="mall/shopsGet/id/23.html">
                            <div class="index_li">
                                <h2>
                                    <img src="Public/Home/Shops/Img/tmlogo.jpeg">
                                    &nbsp;&nbsp;广东地区化妆品专营店转让
                                </h2>
                                <p>
                                    类型：
                      <span>旗舰店
                      </span>
                                    商标：
                      <span>R 标（第0类）
                      </span>
                                </p>
                                <p>
                                    售价：
                      <em>￥95000.00
                      </em>
                                </p>
                            </div>
                        </a>
                    </div>
                    <div class="clear">
                    </div>
                </div>
                <div class="index_li_div" style="display: none;">
                    <div class="index_li_left">
                        <img src="Public/Home/Shops/Img/index_list_01.jpg">
                    </div>
                    <div class="index_li_right">
                    </div>
                    <div class="clear">
                    </div>
                </div>
                <div class="index_li_div" style="display: none;">
                    <div class="index_li_left">
                        <img src="Public/Home/Shops/Img/index_list_01.jpg">
                    </div>
                    <div class="index_li_right">
                    </div>
                    <div class="clear">
                    </div>
                </div>
                <div class="index_li_div" style="display: none;">
                    <div class="index_li_left">
                        <img src="Public/Home/Shops/Img/index_list_01.jpg">
                    </div>
                    <div class="index_li_right">
                    </div>
                    <div class="clear">
                    </div>
                </div>
                <div class="index_li_div" style="display: none;">
                    <div class="index_li_left">
                        <img src="Public/Home/Shops/Img/index_list_01.jpg">
                    </div>
                    <div class="index_li_right">
                        <a href="mall/shopsGet/id/20.html">
                            <div class="index_li">
                                <h2>
                                    <img src="Public/Home/Shops/Img/tmlogo.jpeg">
                                    &nbsp;&nbsp;家居，家装
                                </h2>
                                <p>
                                    类型：
                      <span>-
                      </span>
                                    商标：
                      <span>- 标（第0类）
                      </span>
                                </p>
                                <p>
                                    售价：
                      <em>￥40000.00
                      </em>
                                </p>
                            </div>
                        </a>
                    </div>
                    <div class="clear">
                    </div>
                </div>
            </div>
        </div>--%>

        <div class="shops">
            <div class="shops-col">
                <div class="shops-head">
                    <h3>全新热卖店铺</h3>
                    <span class="line"></span>
                </div>

                <ul class="shops-list">
                    <asp:Loop LoopType="Product" runat="server" Limit="4" IsHot="True">
                        <ItemTemplate>
                            <li>
                                <div class="shop-show">
                                    <div class="shop-line title">
                                        <h2><a target="_blank" href="/ShopView.aspx?id=<%# Eval("Id") %>"><%# Eval("Name") %></a></h2>
                                    </div>
                                    <div class="shop-line image">
                                        <div class="shop-image icon-cat-<%# Eval("Category_Id") %>">
                                        </div>
                                    </div>

                                    <%-- <div class="shop-line attribute">
                                        <span class="prop-label">创店时间：<i><%# Eval("StartTime","{0:yyyy-MM}") %></i></span>
                                    </div>--%>

                                    <div class="shop-line attribute">
                                        <span class="prop-label">所在地区：<i><%# Eval("Area") %></i></span>
                                    </div>

                                    <div class="shop-line attribute">
                                        <span class="prop-label">店铺类型：<i><%# Eval("MallType") %></i></span>
                                    </div>
                                    <div class="shop-line attribute">
                                         <span class="prop-label">一级类目：<i><%# ((string)Eval("Categories")).Trim(',') %></i></span>
                                    </div>
                                    <div class="shop-line attribute">
                                        <span class="prop-label">商标分类：<i><%# Eval("Trademark") %></i></span>
                                    </div>

                                    <%-- <div class="shop-line attribute">
                                        <p>
                                            <strong>所在地区：<i><%# Eval("Area") %></i></strong>
                                            <strong>商标：<i><%# Eval("TrademarkType") %></i></strong>
                                        </p>
                                        <p>
                                            <strong>动态评分：<i><%# Eval("ScoreValue") %></i></strong>
                                        </p>
                                    </div>--%>

                                    <div class="shop-line price">
                                        <strong class="">￥<%# Eval("FormatPrice") %></strong>
                                        <a target="_blank" href="/ShopView.aspx?id=<%# Eval("Id") %>">购买</a>
                                    </div>
                                </div>

                            </li>
                        </ItemTemplate>
                    </asp:Loop>



                </ul>
            </div>
            <div class="shops-col">
                <h3>全新热卖店铺</h3>
                <span class="line"></span>
                <ul class="shops-list" style="margin-left: 0">
                    <asp:Loop LoopType="Product" runat="server" Limit="4" IsNew="1">
                        <ItemTemplate>
                            <li>
                                <div class="shop-show">
                                    <div class="shop-line title">
                                        <h2><a target="_blank" href="/ShopView.aspx?id=<%# Eval("Id") %>"><%# Eval("Name") %></a></h2>
                                    </div>
                                    <div class="shop-line image">
                                        <div class="shop-image icon-cat-<%# Eval("Category_Id") %>">
                                        </div>
                                    </div>

                                    <%-- <div class="shop-line attribute">
                                        <span class="prop-label">创店时间：<i><%# Eval("StartTime","{0:yyyy-MM}") %></i></span>
                                    </div>--%>

                                    <div class="shop-line attribute">
                                        <span class="prop-label">所在地区：<i><%# Eval("Area") %></i></span>
                                    </div>

                                    <div class="shop-line attribute">
                                        <span class="prop-label">店铺类型：<i><%# Eval("MallType") %></i></span>
                                    </div>
                                    <div class="shop-line attribute">
                                         <span class="prop-label">一级类目：<i><%# ((string)Eval("Categories")).Trim(',') %></i></span>
                                    </div>
                                    <div class="shop-line attribute">
                                        <span class="prop-label">商标分类：<i><%# Eval("Trademark") %></i></span>
                                    </div>

                                    <%-- <div class="shop-line attribute">
                                        <p>
                                            <strong>所在地区：<i><%# Eval("Area") %></i></strong>
                                            <strong>商标：<i><%# Eval("TrademarkType") %></i></strong>
                                        </p>
                                        <p>
                                            <strong>动态评分：<i><%# Eval("ScoreValue") %></i></strong>
                                        </p>
                                    </div>--%>

                                    <div class="shop-line price">
                                        <strong class="">￥<%# Eval("FormatPrice") %></strong>
                                        <a target="_blank" href="/ShopView.aspx?id=<%# Eval("Id") %>">购买</a>
                                    </div>
                                </div>

                            </li>
                        </ItemTemplate>
                    </asp:Loop>

                </ul>
            </div>
        </div>
        <div class="clear"></div>

        <div class="buyer-setup">
        </div>
        <div class="seller-setup">
        </div>

        <div class="goods-row">
            <div class="goods-col left">
                <div class="goods-show blue">
                    <div class="goods-head">
                        <h3>全新店铺 特惠出售中</h3>
                        <p>交易透明 各类型天猫旗舰店应有尽有 安全快捷</p>
                    </div>
                    <div class="goods-body">
                        <ul class="goods-list">
                            <asp:Loop LoopType="Product" runat="server" Limit="3" IsNew="1">
                                <ItemTemplate>
                                    <li>
                                        <span><i>￥</i><%# Eval("FormatPrice") %></span>
                                        <strong><%# Eval("Category_Name") %></strong>
                                    </li>
                                </ItemTemplate>
                            </asp:Loop>

                        </ul>
                        <a target="_blank" href="/Tmall.aspx" class="goods-buynow">立即购买</a>
                    </div>
                </div>
            </div>
            <div class="goods-col">
                <div class="goods-more">
                    <div class="more-head">
                        <h3>更多店铺<a href="/Tmall.aspx"><i class="icon if-others">&#xe608;</i>了解详情</a></h3>

                    </div>
                    <div class="more-body shop" style="height:300px">
                    </div>
                </div>
            </div>

        </div>

        <div class="shops">
            <div class="shops-col left">
                <h3>全新热卖店铺</h3>
                <span class="line"></span>
                <ul class="shops-list">
                    <ul class="shops-list" style="margin-left: 0">
                        <asp:Loop LoopType="Product" runat="server" Limit="2" IsNew="1">
                            <ItemTemplate>
                                <li>
                                    <div class="shop-show">
                                        <div class="shop-line title">
                                            <h2><a href="/ShopView.aspx?id=<%# Eval("Id") %>"><%# Eval("Name") %></a></h2>
                                        </div>
                                        <div class="shop-line image">
                                            <div class="shop-image icon-cat-<%# Eval("Category_Id") %>">
                                            </div>
                                        </div>

                                        <%-- <div class="shop-line attribute">
                                        <span class="prop-label">创店时间：<i><%# Eval("StartTime","{0:yyyy-MM}") %></i></span>
                                    </div>--%>

                                        <div class="shop-line attribute">
                                            <span class="prop-label">所在地区：<i><%# Eval("Area") %></i></span>
                                        </div>

                                        <div class="shop-line attribute">
                                            <span class="prop-label">店铺类型：<i><%# Eval("MallType") %></i></span>
                                        </div>
                                        <div class="shop-line attribute">
                                             <span class="prop-label">一级类目：<i><%# ((string)Eval("Categories")).Trim(',') %></i></span>
                                        </div>
                                        <div class="shop-line attribute">
                                            <span class="prop-label">商标分类：<i><%# Eval("Trademark") %></i></span>
                                        </div>

                                        <%-- <div class="shop-line attribute">
                                        <p>
                                            <strong>所在地区：<i><%# Eval("Area") %></i></strong>
                                            <strong>商标：<i><%# Eval("TrademarkType") %></i></strong>
                                        </p>
                                        <p>
                                            <strong>动态评分：<i><%# Eval("ScoreValue") %></i></strong>
                                        </p>
                                    </div>--%>

                                        <div class="shop-line price">
                                            <strong class="">￥<%# Eval("FormatPrice") %></strong>
                                            <a target="_blank" href="/ShopView.aspx?id=<%# Eval("Id") %>">购买</a>
                                        </div>
                                    </div>

                                </li>
                            </ItemTemplate>
                        </asp:Loop>

                    </ul>

                </ul>
            </div>
            <div class="shops-col">
                <h3>全新热卖店铺</h3>
                <span class="line"></span>
                <ul class="shops-list" style="margin-left: 0">
                    <asp:Loop LoopType="Product" runat="server" Limit="2" IsBest="True" IsNew="1">
                        <ItemTemplate>
                            <li>
                                <div class="shop-show">
                                    <div class="shop-line title">
                                        <h2><a href="/ShopView.aspx?id=<%# Eval("Id") %>"><%# Eval("Name") %></a></h2>
                                    </div>
                                    <div class="shop-line image">
                                        <div class="shop-image icon-cat-<%# Eval("Category_Id") %>">
                                        </div>
                                    </div>

                                    <%-- <div class="shop-line attribute">
                                        <span class="prop-label">创店时间：<i><%# Eval("StartTime","{0:yyyy-MM}") %></i></span>
                                    </div>--%>

                                    <div class="shop-line attribute">
                                        <span class="prop-label">所在地区：<i><%# Eval("Area") %></i></span>
                                    </div>

                                    <div class="shop-line attribute">
                                        <span class="prop-label">店铺类型：<i><%# Eval("MallType") %></i></span>
                                    </div>
                                    <div class="shop-line attribute">
                                        <span class="prop-label">一级类目：<i><%# ((string)Eval("Categories")).Trim(',') %></i></span>
                                    </div>
                                    <div class="shop-line attribute">
                                        <span class="prop-label">商标分类：<i><%# Eval("Trademark") %></i></span>
                                    </div>

                                    <%-- <div class="shop-line attribute">
                                        <p>
                                            <strong>所在地区：<i><%# Eval("Area") %></i></strong>
                                            <strong>商标：<i><%# Eval("TrademarkType") %></i></strong>
                                        </p>
                                        <p>
                                            <strong>动态评分：<i><%# Eval("ScoreValue") %></i></strong>
                                        </p>
                                    </div>--%>

                                    <div class="shop-line price">
                                        <strong class="">￥<%# Eval("FormatPrice") %></strong>
                                        <a href="/ShopView.aspx?id=<%# Eval("Id") %>">购买</a>
                                    </div>
                                </div>

                            </li>
                        </ItemTemplate>
                    </asp:Loop>
                </ul>
            </div>
        </div>
    </div>
    <div class="clear">
    </div>
    <style>
        .news-head {
            border-bottom:2px solid #e71f19;
            clear:both;
            height:50px;
        }
            .news-head h3 {
                background-color:#eae7e7;
                padding:10px;
                float:left
            }

        .news-list {
            margin-top:20px;
        }
        .first-news-img {
            float:left;
            width:200px;
        }
        .news-body li {
            padding:5px 0;

        }


        .news-body li span.time {
            float:right;
        }
        .first-news-item a.title {
            height:30px;
            line-height:30px;
            color:#fea545;
            font-size:16px;
        }
        .first-news-item {
            
        }
        .news-body li a {
            font-size:14px;
            font-family:'Microsoft YaHei'
        }
        .question-body li {
            background-color:#ece9e6;
            height:38px;
            margin-bottom:10px;
            padding:10px;
        }
        .question-body .question-img, .question-body .question-item {
            float:left
        }
        .question-body .question-item {
            padding-left:10px;
            width:350px;
            white-space:nowrap;
            overflow:hidden;
        }
        .interview-body {
            position:relative;
            min-height:350px;

        }
            .interview-body ul {
                padding-left:220px;
            }
            .interview-adv {
                position:absolute;

            }
    </style>
    <div class="wrap goods-row news-list">
        <div class="goods-col left">
            <div class="news-head">
                <h3>网站公告</h3>
            </div>
            <div class="clear"></div>
            <div class="news-body">
                <ul>
                    
                   
                    <asp:Loop runat="server" LoopType="Article" CatId="65" Limit="1">
                        <ItemTemplate>
                            <li style="border-bottom:1px dashed #ccc;">
                        <div class="first-news-img"><img  src="/Public/Home/Shops/img/index_wzgg.jpg" height="80" /></div>
                        
                        <div class="first-news-item">
                        <a href="/Detail.aspx?id=<%# Eval("Id") %>" class="title"><%# Eval("Title") %></a>
                        <p><%# Eval("Brief") %> <a href="/Detail.aspx?id=<%# Eval("Id") %>">查看更多</a></p>
                        </div>
                        <div class="clear"></div>
                    </li>
                        </ItemTemplate>
                    </asp:Loop>
                    <asp:Loop runat="server" LoopType="Article" CatId="65" Limit="4">
                        <ItemTemplate>
                            <li><a href="/Detail.aspx?id=<%# Eval("Id") %>"><%# Eval("Title") %></a><span class="time"><%# Eval("AddDate") %></span></li>
                        </ItemTemplate>
                    </asp:Loop>
                   
                </ul>
            </div>
        </div>
        <div class="goods-col">
                        <div class="news-head">
                <h3>电商资讯</h3>
            </div>
            <div class="clear"></div>
            <div class="news-body">
                <ul>
                    
                   
                    <asp:Loop runat="server" LoopType="Article" CatId="66" Limit="1">
                        <ItemTemplate>
                            <li style="border-bottom:1px dashed #ccc;">
                        <div class="first-news-img"><img  src="/Public/Home/Shops/Img/index_dszx.jpg" height="80" /></div>
                        
                        <div class="first-news-item">
                        <a href="/Detail.aspx?id=<%# Eval("Id") %>" class="title"><%# Eval("Title") %></a>
                        <p><%# Eval("Brief") %> <a href="/Detail.aspx?id=<%# Eval("Id") %>">查看更多</a></p>
                        </div>
                        <div class="clear"></div>
                    </li>
                        </ItemTemplate>
                    </asp:Loop>
                    <asp:Loop runat="server" LoopType="Article" CatId="66" Limit="4">
                        <ItemTemplate>
                            <li><a href="/Detail.aspx?id=<%# Eval("Id") %>"><%# Eval("Title") %></a><span class="time"><%# Eval("AddDate") %></span></li>
                        </ItemTemplate>
                    </asp:Loop>
                </ul>
            </div>
        </div>
    </div>
    <div class="clear">
    </div>
    <div class="wrap">
        <div class="newlist" style="width:60%;float:left">
                                    <div class="news-head">
                <h3>售后采访</h3>
            </div>
            <div class="clear"></div>
            <div class="news-body interview-body">
                <div class="interview-adv">
                    <img src="/Public/Home/Shops/img/index_shcf.jpg" width="200" />
                </div>
                <ul>
                    
                   
                    <asp:Loop runat="server" LoopType="Article" CatId="46" Limit="1">
                        <ItemTemplate>
                            <li style="border-bottom:1px dashed #ccc;">
                        <div class="first-news-img"><img  src="/Public/Home/Shops/img/index_interview.jpg" height="80" /></div>
                        
                        <div class="first-news-item">
                        <a href="/Detail.aspx?id=<%# Eval("Id") %>" class="title"><%# Eval("Title") %></a>
                        <p><%# Eval("Brief") %> <a href="/Detail.aspx?id=<%# Eval("Id") %>">查看更多</a></p>
                        </div>
                        <div class="clear"></div>
                    </li>
                        </ItemTemplate>
                    </asp:Loop>
                    <asp:Loop runat="server" LoopType="Article" CatId="46" Limit="4">
                        <ItemTemplate>
                            <li><a href="/Detail.aspx?id=<%# Eval("Id") %>"><%# Eval("Title") %></a><span class="time"><%# Eval("AddDate") %></span></li>
                        </ItemTemplate>
                    </asp:Loop>
                </ul>
            </div>
        </div>
        <div class="online-question" style="float:right; width:35%">
                                                <div class="news-head">
                <h3>在线问答</h3>
            </div>
            <div class="clear"></div>
            <div class="question-body">
                <ul>
                    <asp:Loop runat="server" LoopType="Question" Limit="4">
                        <ItemTemplate>
                             <li>
                        <div class="question-img">
                            <img  src="/Public/Home/Shops/Img/head.jpg" height="32" />
                        </div>
                        <div class="question-item">
                            <p>
                                <%# Eval("Title") %>
                            </p>
                            <p><%# Eval("Title") %><a href="#">详情</a></p>
                        </div></li>
                        </ItemTemplate>
                    </asp:Loop>
                   
                </ul>
            </div>
        </div>
    </div>
    <div class="clear">
    </div>
    <div class="New-honor">
        <%--<div class="img">

            <a href="javascript:;" rel="nofollow" class="link1">
                <img src="Public/Home/Shops/Images/1506/1c_honour_01.png" />
                <div class="ryms">
                    <p class="honourL-1">
                        开创模式
                    </p>
                    <p class="honourL-2">
                        选猫网首创了网店转让模式
                    </p>
                </div>
            </a>
            <span class="v-line"></span>


            <a href="javascript:;" rel="nofollow" class="link1">
                <img src="Public/Home/Shops/Images/1506/1c_honour_02.png" />
                <div class="ryms">
                    <p class="honourL-1">
                        规模领先
                    </p>
                    <p class="honourL-2">
                        目前全国有六家全资公司
                    </p>
                </div>
            </a>
            <span class="v-line"></span>
            <a href="javascript:;" rel="nofollow" class="link1">
                <img src="Public/Home/Shops/Images/1506/1c_honour_03.png" />
                <div class="ryms">
                    <p class="honourL-1">
                        数量领先
                    </p>
                    <p class="honourL-2">
                        拥有待售中的网店上万家
                    </p>
                </div>
            </a>
            <span class="v-line"></span>
            <a href="javascript:;" rel="nofollow" class="link1">
                <img src="Public/Home/Shops/Images/1506/1c_honour_04.png" />
                <div class="ryms">
                    <p class="honourL-1">
                        交易量大
                    </p>
                    <p class="honourL-2">
                        已经出售店铺超过三万家
                    </p>
                </div>
            </a>
            <span class="v-line"></span>
            <a href="javascript:;" rel="nofollow" class="link1">
                <img src="Public/Home/Shops/Images/1506/1c_honour_05.png" />
                <div class="ryms">
                    <p class="honourL-1">
                        多方认证
                    </p>
                    <p class="honourL-2">
                        拥有七家第三方认证机构
                    </p>
                </div>
            </a>
        </div>--%>
    </div>
    <div class="clear">
    </div>
    <div id="sidebar-helper">

        <div class="helper-head">
            <a href="/Users/Register.aspx"></a>
        </div>
        <div class="helper-body">
            <div class="helper-title"><a href="javascript:;" id="btn-sidebar-helper"></a></div>
            <ul>
                <li class="item1"><a href="/Tmall.aspx?go=0&new=2&q=<%="男装".UrlEncode() %>"></a></li>
                <li class="item2"><a href="/Tmall.aspx?go=0&new=2&q=<%="洗护".UrlEncode() %>"></a></li>
                <li class="item3"><a href="/Tmall.aspx?go=0&new=2&q=<%="户外".UrlEncode() %>"></a></li>
                <li class="item4"><a href="/Tmall.aspx?go=0&new=2&q=<%="彩妆".UrlEncode() %>"></a></li>
                <li class="item5"><a href="/Tmall.aspx?go=0&new=2&q=<%="居家".UrlEncode() %>"></a></li>
            </ul>
        </div>
        <div class="helper-foot">
            <a href="javascript:;" onclick="ShowAskWin('http://wpa.qq.com/msgrd?v=3&uin=<%=MainKefu %>&site=qq&menu=yes')"></a>
        </div>
    </div>
    <div id="main-kefu">
        <div class="kefu-lady">
            <div class="lady-image">
                <a href="javascript:;" onclick="ShowAskWin('http://wpa.qq.com/msgrd?v=3&uin=<%=MainKefu %>&site=qq&menu=yes')"></a>
            </div>
            <a href="javascript:;" onclick="ShowAskWin('http://wpa.qq.com/msgrd?v=3&uin=<%=MainKefu %>&site=qq&menu=yes')"></a>

        </div>
        <div class="kefu-body">
            <a href="/Tmall.aspx">
                <span><%=DateTime.Now.Year %></span>
                <a class="about-more" href="/Tmall.aspx">点击了解</a>
                <img src="Public/Home/Shops/Images/main-kefu-body-image.png" alt="点击了解" />
            </a>
        </div>
        <div class="kefu-foot">
            <a class="kefu-qrcode">
                <img src="Public/Home/Shops/Images/main-kefu-qrcode.png" alt="关注微信公众号！" />
            </a>
        </div>
        <a id="main-kefu-close" href="javascript:;">关闭窗口</a>
    </div>

</asp:Content>
