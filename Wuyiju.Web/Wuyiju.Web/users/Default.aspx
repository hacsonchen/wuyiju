<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Wuyiju.Web.users.Default" %>



<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>会员中心</title>

    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/base.css" media="all" />

    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/user.css" media="all" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <script type="text/javascript" src="/Public/Home/Shops/Js/jquery.min.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/Js/common.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/layer/layer.js"></script>
</head>
<body>

    <script type="text/javascript">

        $().ready(function () {
            showMenuDownList();
        });
    </script>
    <script type="text/javascript">
        function check_data() {
            if (document.form1.jycontent.value.length == 0)
                alert("内容不能为空!");
            else
                form1.submit();
        }
    </script>
    <div id="users-banner">
    </div>
    <div class="header-bar">
        <div class="wrap">
            <div class="bar-logo">
                <h1>选猫网</h1>
            </div>
            <div class="bar-menu">
                <ul>
                    <li><a href="/">首页</a></li>
                    <li><a href="/Tmall.aspx">购买网店</a></li>
                    <li><a href="/Users/ShopsTransferType.aspx">出售网店</a></li>
                    <li><a href="/Users/QiugouSubmit.aspx">求购网店</a></li>
                    <li><a href="/Compared.aspx">网店估价</a></li>
                    <li><a href="#">淘宝知识</a></li>
                    <li><a href="/Question/">在线问答</a></li>
                    <li><a href="#">帮助中心</a></li>
                    <li><a href="#">客服中心</a></li>
                </ul>
            </div>
        </div>
    </div>
    <div id="users-container" class="wrap clearfix">
        <div class="navLeft">
            <div class="company-intro">
                <h2>公司简介</h2>
                <p>
                    <%=Application["slogan"] %>
                </p>
            </div>
            <dl id="itag1" class="list-down">
                <dt><b></b>我是卖家</dt>
                <dd><a id="it1_1" href="/Users/SellList.aspx"><i></i>我要出售网店</a></dd>
                <dd><a id="it1_2" href="/Users/SellList.aspx"><i></i>我出售的网店</a></dd>
                <!--<dd><a id="it1_9" href="/Users/qiugoujoin.html" ><i></i>我参与的求购</a></dd>
       	<dd><a id="it1_10" href="/Users/qiugoucollection.html" ><i></i>我收藏的求购</a></dd>-->
            </dl>
            <dl id="itag7" class="list-down">
                <dt><b></b>我是买家</dt>
                <dd><a id="it7_1" href="/Users/BoughtList.aspx"><i></i>我购买的网店</a></dd>
                <dd><a id="it7_2" href="/Users/Favorites.aspx"><i></i>我收藏的网店</a></dd>
                <!--
		<dd><a id="it7_3" href="/Users/qiugou_submit.html" ><i></i>我要求购网店</a></dd>
       	<dd><a id="it7_4" href="/Users/qiugoulist.html" ><i></i>我的求购信息</a></dd>
		-->
            </dl>
            <dl id="itag2" class="list-down">
                <dt><b></b>资金管理</dt>
                <dd><a id="it2_1" href="/Users/Recharge.aspx"><i></i>我要充值</a></dd>
                <dd><a id="it2_2" href="/Users/RechargeRecords.aspx"><i></i>充值记录</a></dd>
                <dd><a id="it2_3" href="/Users/Takecash.aspx"><i></i>我要提现</a></dd>
                <dd><a id="it2_4" href="/Users/TakecashRecords.aspx"><i></i>提现记录</a></dd>
                <dd><a id="it2_7" href="/Users/FundsDetails.aspx"><i></i>收支明细</a></dd>
                <dd><a id="it2_8" href="/Users/FreezeDetails.aspx"><i></i>冻结明细</a></dd>
            </dl>
            <%-- <dl id="itag8" class="list-down">
                    <dt><b></b>电商学院</dt>
                    <dd><a id="it8_1" href="/school/index.html" ><i></i>学院介绍</a></dd>
                    <dd><a id="it8_2" href="/Users/school.html"><i></i>报名信息</a></dd>
                </dl>--%>

            <dl id="itag3" class="list-down">
                <dt><b></b>信息管理</dt>
                <dd><a id="it3_1" href="/Users/EditInfo.aspx" class="over"><i></i>修改个人资料</a></dd>
                <dd><a id="it3_2" href="/Users/ChangePassword.aspx"><i></i>修改登录密码</a></dd>
                <dd><a id="it3_3" href="/Users/PaymentPassword.aspx"><i></i>设置支付密码</a></dd>
                <dd><a id="it3_4" href="/Users/ProtectPassword.aspx"><i></i>修改密码保护</a></dd>
                <dd><a id="it3_7" href="/Users/AuthMobile.aspx"><i></i>手机认证</a></dd>
                <dd><a id="it3_8" href="/Users/AuthEmail.aspx"><i></i>邮箱认证</a></dd>
            </dl>
            <dl id="itag4">
                <dt><b></b>咨询建议</dt>
                <dd><a id="it4_1" href="/Users/QuestionSubmit.aspx"><i></i>我要提问</a></dd>
                <dd><a id="it4_2" href="/Question/MyList.aspx"><i></i>我的提问</a></dd>
                <dd><a id="it4_3" href="/Users/SuggestSubmit.aspx"><i></i>我要建议</a></dd>
                <dd><a id="it4_4" href="/Users/wdjianyi.html"><i></i>我的建议</a></dd>
            </dl>
            <div class="question-online">
                <h3>在线问答</h3>
                <ul>
                    <asp:Loop runat="server" LoopType="Question" Limit="4">
                        <ItemTemplate>
                            <li><a href="/Question/Answer.aspx?id=<%# Eval("Id") %>"><%# Eval("Title") %></a></li>
                        </ItemTemplate>
                    </asp:Loop>
                </ul>
            </div>
            <form name="form1" id="iform1" method="post" action="/users/AddSuggest.aspx" style="position: absolute" onsubmit="return CheckYjForm()">
                <div class="infoList">
                    <div class="hd">投诉与建议</div>
                    <div class="suggestions-q">
                        <textarea name="jycontent" id="ijycontent" placeholder="是否满意？有话您直说" autocomplete="off"></textarea>
                        <input type="button" value="确认提交" class="subsug-btn" id="btn-suggest">
                    </div>
                </div>
            </form>
        </div>

        <script type="text/javascript">
            var oflag = "";
            $(document).ready(function () {
                $("div.navLeft dl dd a").click(function () {
                    oflag = "ahref";
                });

                $("div.navLeft dl").click(function () {
                    var issel = $(this).hasClass("list-down");
                    if (issel == true && oflag != "ahref") {
                        $(this).removeClass("list-down");
                    } else {
                        $(this).addClass("list-down");
                    }
                });

                $("#btn-suggest").click(function () {
                    if ($.trim($('#ijycontent').val()) == '') {

                        layer.alert('请填写您的建议！');
                    } else {
                        $.ajax({
                            url: '/Users/AddSuggest.aspx',
                            data: { jycontent: $('#ijycontent').val() },
                            success: function (data) {
                                $('#ijycontent').val('');
                                layer.alert('谢谢反馈宝贵的建议！');
                            }
                        });
                    }
                });
            });

            var ig = "";
            $("div.navLeft dl dd a").removeClass("over");
            if (ig != "") {
                document.getElementById("it" + ig).className = "over";
                var itag = ig.substring(0, ig.indexOf("_"));
                if (itag == "3" || itag == "4" || itag == "5" || itag == "6" || itag == "8") {
                    document.getElementById("itag" + itag).className = "list-down";
                }
            }
        </script>

        <div class="part-middle">
            <div class="partOne-m">
                <div class="ts-part" id="user-info">
                    <div class="user-image">
                        <img src="../Public/Home/Shops/Images/user-default-img.jpg" />
                    </div>
                    <div class="user-baseinfo">
                        <div class="user-name">
                            <%=LoggedUser.Name %>
                        </div>
                        <div class="user-action">
                            <ul>
                                <li><a href="/Users/AuthMobile.aspx" class="mobile">手机认证</a></li>
                                <li><a href="/Users/EditInfo.aspx" class="account">账户信息</a></li>
                                <li><a href="/Users/AuthEmail.aspx" class="email">邮箱认证</a></li>
                                <li><a href="/Users/PaymentPassword.aspx" class="password">用户密码</a></li>
                            </ul>
                        </div>
                        <div class="clear"></div>
                        <p class="login-info">上次登录IP：<%=LoggedUser.Last_Ip %> 上次登录时间：<%=LoggedUser.LastTime %> 本次登录IP：<%=LoggedUser.Login_Ip %></p>
                    </div>
                </div>
                <div class="clear"></div>
                <div class="ts-part" id="money-info">
                    <ul>
                        <li class="money"><strong>账户余额<span class="money-format"><%=LoggedUser.Money+LoggedUser.Frozen_Money %></span>元</strong></li>
                        <li class="hongbao">
                            <p><strong>红包余额</strong></p>
                            <p><span class="money-format">00.00</span> 元</p>
                        </li>
                        <li class="action short">
                            <a class="btn-recharge" href="/Users/Recharge.aspx">充值</a>
                            <a class="btn-takecash" href="/Users/Takecash.aspx">提现</a>
                        </li>
                        <li class="keyong">
                            <p><strong>可用余额</strong></p>
                            <p><span class="money-format"><%=LoggedUser.Money %></span></p>
                        </li>
                        <li class="dongjie">
                            <p><strong>冻结资金</strong></p>
                            <p><span class="money-format"><%=string.Format("{0:####.##}",LoggedUser.Frozen_Money) %></span>元</p>
                        </li>
                        <li class="kandianka short"><span class="kdk-count"><%=LoggedUser.Rank_Points %></span></li>
                    </ul>
                </div>
                <div class="clear"></div>
                <div class="ts-part">
                    <ul class="ts_1 clearfix">
                        <li class="hasNum"><span class="ts_1_1"></span><a href="/Users/SellList.aspx">我出售的网店(<strong><%=SellingCount %></strong>)</a></li>
                        <li class="hasNum"><span class="ts_1_2"></span><a href="/Users/BoughtList.aspx">我购买的网店(<strong><%=BoughtCount %></strong>)</a></li>
                        <li><span class="ts_1_3"></span><a href="/Users/ShopsTransferType.aspx">我要出售网店</a></li>
                        <!--
					<li><span class="ts_1_4"></span><a href="/Users/QiugouSubmit.aspx">我要求购网店</a></li>
                    -->
                        <li class="last"><span class="ts_1_5"></span><a href="/Users/Favorites.aspx">我收藏的网店</a></li>
                    </ul>
                    <div class="ts_2">
                        <dl class="clearfix">
                            <dt>卖家提醒：</dt>
                            <dd class="one"><a href="/Users/SellList.aspx">审核的网店（<em><%=SellingAuditCount %></em>）</a></dd>
                            <dd class="two"><a href="/Users/SellList.aspx">出售中（<em><%=SellingTradeCount %></em>）</a></dd>
                            <dd class="one"><a href="/Users/SellList.aspx">正在交易（<em>0</em>）</a></dd>
                            <dd class="two"><a href="/Users/SellList.aspx">退款中（<em>0</em>）</a></dd>
                        </dl>
                        <dl class="clearfix">
                            <dt>买家提醒：</dt>
                            <dd class="one"><a href="/Users/BoughtList.aspx?pay_status=0">等待付款（<em><%=BoughtDFCount %></em>）</a></dd>
                            <dd class="two"><a href="/Users/BoughtList.aspx?pay_status=1">已付定金（<em><%=BoughtYFDJCount %></em>）</a></dd>
                            <dd class="one"><a href="/Users/BoughtList.aspx?pay_status=2">已付全额（<em><%=BoughtYFQECount %></em>）</a></dd>
                            <dd class="two"><a href="/Users/BoughtList.aspx?pay_status=4">已退款（<em><%=BoughtTKCount %></em>）</a></dd>
                        </dl>
                    </div>
                </div>
            </div>
            <div class="liuchengBox">
                <dl>
                    <dt>购店流程：</dt>
                    <dd class="clearfix">
                        <a href="javascript:void(0);">选购网店</a>
                        <b></b>
                        <a href="javascript:void(0);">拍下付款</a>
                        <b></b>
                        <a href="javascript:void(0);">账户充值</a>
                        <b></b>
                        <a href="javascript:void(0);">付款成功</a>
                        <b></b>
                        <a href="javascript:void(0);">交接信息</a>
                        <b></b>
                        <a href="javascript:void(0);">签订合同</a>
                        <b></b>
                        <a href="javascript:void(0);">交易完成</a>
                        <b></b>
                        <a href="javascript:void(0);">售后服务</a>
                    </dd>
                </dl>
                <dl class="maijia">
                    <dt>卖家入门：</dt>
                    <dd class="clearfix">
                        <a href="javascript:void(0);">登记网店</a>
                        <b></b>
                        <a href="javascript:void(0);">买家拍下</a>
                        <b></b>
                        <a href="javascript:void(0);">完成付款</a>
                        <b></b>
                        <a href="javascript:void(0);">交接信息</a>
                        <b></b>
                        <a href="javascript:void(0);">签订合同</a>
                        <b></b>
                        <a href="javascript:void(0);">交易完成</a>
                        <b></b>
                        <a href="javascript:void(0);">申请提现</a>
                        <b></b>
                        <a href="javascript:void(0);">售后服务</a>
                    </dd>
                </dl>
            </div>

            <div id="best-shop" class="similar">
                <h3>精品店铺推荐</h3>
                <ul>
                    <asp:Loop LoopType="Product" runat="server" IsBest="true" Limit="4">
                        <ItemTemplate>
                            <li>
                                <a href="/ShopView.aspx?id=<%# Eval("Id") %>" class="image">
                                    <img src="/Public/Home/Shops/Images/category/icon-cat-<%# Eval("Category_Id") %>.png" /></a>
                                <a href="/ShopView.aspx?id=<%# Eval("Id") %>" class="text"><%# Eval("Name") %></a>
                            </li>
                        </ItemTemplate>
                    </asp:Loop>

                </ul>
            </div>

        </div>
        <!-- 右侧 -->
    </div>

</body>
</html>

