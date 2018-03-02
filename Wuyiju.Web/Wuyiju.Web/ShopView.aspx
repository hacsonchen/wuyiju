<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShopView.aspx.cs" Inherits="Wuyiju.Web.ShopView" MasterPageFile="~/Site.Master" %>

<%@ Import Namespace="Wuyiju.Domain.Model" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/shopsGet.css" media="all" />
    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/user2.css" media="all" />
    <script type="text/javascript" src="/Public/Home/Shops/Js/jquery.timeago.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/layer/layer.js"></script>

    <script type="text/javascript" src="/Public/Home/Shops/Js/shopsGet.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/Js/dafen.js"></script>
    <style type="text/css">
    </style>
    <script type="text/javascript">



    </script>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="BodyHolder"> 
    <div class="product-info wrap clearfix" style="margin-top: 15px;">
        <input id="product_id" type="hidden" value="<%=Model.Id %>" />
        <div class="storeInfo">
            <div class="hd">
                <div class="title">
                    <img src="/Public/Home/Shops/Images/tmall-wdxxxx-hd-img.png">网店编号：<%=Model.Sn %>
                </div>
            </div>
            <div id="storeAttr">
                <ul>
                    <asp:Repeater runat="server" ID="rptAttrs">
                        <ItemTemplate>
                            <li><span><%# Eval("Attr_Name") %>：</span><strong><%# Eval("Attr_Value") %></strong></li>
                        </ItemTemplate>
                    </asp:Repeater>
                    <li><span>公司资质：</span><strong><%=Model.CompanyLevel %></strong></li>
                     <li><span>违规扣分：</span><strong><%=(string.IsNullOrWhiteSpace(Model.Weiscore) ? "": Model.Weiscore .Trim(',').Trim('，')) %></strong></li>
                </ul>
                <div class="clear"></div>
                <dl>
                    <dt>店铺半年动态评分</dt>
                    <% if ("高".Equals(Model.GetArray("level", 0)) || "持平".Equals(Model.GetArray("level", 0)))
                        { %>
                    <dd>宝贝与描述相符：<span class="score-level score-high"><i class="score-arrow"></i>比同行业平均水平<strong><%=Model.GetArray("level", 0) %></strong></span></dd>
                    <% }
                        else if ("低".Equals(Model.GetArray("level", 0)))
                        { %>
                    <dd>宝贝与描述相符：<span class="score-level score-middle"><i class="score-arrow"></i>比同行业平均水平<strong><%=Model.GetArray("level", 0) %></strong></span></dd>

                    <%}
                        else if ("无".Equals(Model.GetArray("level", 0)))
                        { %>

                    <dd>宝贝与描述相符：<span class="score-level score-low"><i class="score-arrow"></i>比同行业平均水平<strong><%=Model.GetArray("level", 0) %></strong></span></dd>
                    <%} %>


                    <% if ("高".Equals(Model.GetArray("level", 1)) || "持平".Equals(Model.GetArray("level", 0)))
                        { %>
                    <dd>卖家的服务态度：<span class="score-level score-high"><i class="score-arrow"></i>比同行业平均水平<strong><%=Model.GetArray("level", 1) %></strong></span></dd>
                    <% }
                        else if ("低".Equals(Model.GetArray("level", 1)))
                        { %>

                    <dd>卖家的服务态度：<span class="score-level score-middle"><i class="score-arrow"></i>比同行业平均水平<strong><%=Model.GetArray("level", 1) %></strong></span></dd>
                    <%}
                        else if ("无".Equals(Model.GetArray("level", 1)))
                        { %>
                    <dd>卖家的服务态度：<span class="score-level score-low"><i class="score-arrow"></i>比同行业平均水平<strong><%=Model.GetArray("level", 1) %></strong></span></dd>
                    <%} %>

                    <% if ("高".Equals(Model.GetArray("level", 2)) || "持平".Equals(Model.GetArray("level", 0)))
                        { %>
                    <dd>卖家的发货速度：<span class="score-level score-high"><i class="score-arrow"></i>比同行业平均水平<strong><%=Model.GetArray("level", 2) %></strong></span></dd>
                    <% }
                        else if ("低".Equals(Model.GetArray("level", 2)))
                        { %>

                    <dd>卖家的发货速度：<span class="score-level score-middle"><i class="score-arrow"></i>比同行业平均水平<strong><%=Model.GetArray("level", 2) %></strong></span></dd>
                    <%}
                        else if ("无".Equals(Model.GetArray("level", 2)))
                        { %>
                    <dd>卖家的发货速度：<span class="score-level score-low"><i class="score-arrow"></i>比同行业平均水平<strong><%=Model.GetArray("level", 2) %></strong></span></dd>
                    <%} %>
                </dl>
            </div>
            <% if (!ProductImgs.IsNull())
                { %>
            <div id="storeImg">
                <div class="preview">
                    <div id="vertical" class="bigImg">

                        <img src="<%=ProductImgs[0] %>" width="800" height="600" alt="" id="midimg">

                        <div style="left: 51.5px; top: 190px; display: block;" id="winSelector"></div>

                    </div>
                    <!--bigImg end-->

                    <div class="smallImg">
                        <div class="scrollbutton smallImgUp disabled"></div>
                        <div id="imageMenu">
                            <ul>
                                <asp:Repeater runat="server" ID="ProductImages">
                                    <ItemTemplate>
                                        <li>
                                            <img src="http://image.tmallzr.com<%# GetDataItem() %>" width="68" height="68" alt=""></li>
                                        <li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>

                        </div>

                        <div class="scrollbutton smallImgDown"></div>

                    </div>
                    <!--smallImg end-->

                    <%--<div id="bigView" style="width: 470px; height: 420px; top: 75px; left: 565px; display: block;">
                        <img width="800" height="800" alt="" src="big/01.jpg" style="left: -103px; top: -380px;">
                    </div>--%>

                </div>

            </div>
            <%} %>
            <%--<div class="fd clearfix">
                <div style="float: left;">
                    <span>
                        <img src="/Public/Home/Shops/Images/shijian.jpg" title="发布日期"><time class="timeago" datetime="<%=Model.AddTime %>">无</time></span>
                    <span style="margin-right: 0;">
                        <img src="/Public/Home/Shops/Images/renshu.jpg" title="浏览量"><%=Model.Click %></span>
                </div>
                <div style="float: right; width: 167px;">
                    <!--<a href="javascript:void(0)" onclick="sendMsg();" style="margin-left:0;"><img src="/Public/Home/Shops/Images/shouji.jpg">发送到手机</a>-->
                    <a href="javascript:void(0)" onclick="saveCollection(<%=Model.Id %>);">
                        <img src="/Public/Home/Shops/Images/shoucang.png">收藏</a>
                </div>
            </div>--%>
        </div>
        <div class="sellInfo">
            <h2><%=Model.Name %>&nbsp;
            <span class="apu azz1" title="正品保障"></span></h2>

            <div class="priceBox">
                <div class="price"><span class="price-label">出售价格</span><span class="price-flag">￥</span><%=Model.Price %></div>
                <%--<div class="sale">
                    <p class="saleNum"><%=Model.Discount %>折</p>
                    <p class="noPrice">官方估价：￥<%=Model.FormatMarketPrice %>元</p>
                </div>--%>
                <div class="favorite"><a href="javascript:;" onclick="saveCollection(1);">收藏此网店</a></div>
                <div class="lqyhq">
                    <!--<a href="javascript:void(0)" >点击领取优惠券</a>
                <div id="ewmyhq" class="ewmyhq-show" onclick="$('#ewmyhq').toggle(0);" style="display:none;">
                <i></i>
                <div class="ewmyhq-con">
                  <img src="/Public/Home/Shops/Images/0301/lingquyouhuiquanewm.png" usemap="#Map" border="0">
                  <map name="Map" id="Map">
                    <area shape="circle" coords="689,21,15" href="javascript:void(0)" onclick="$('#ewmyhq').hide(0);">
                  </map>
                  </div>
                </div>-->
                </div>
            </div>

            <dl class="item-si ensure">
                <dt>消保金：</dt>
                <dd><% if ("信用消保".Equals(Wuyiju.Model.ProductFrontend.GetAttrValue(100, Model.Attrs)))
                        { %>
                            信用消保
                            <%}
                                else { %>
                    <%=Model.Protection_Deposit %>元<font color="#B61212"><%=string.Format("({0})",Wuyiju.Model.ProductFrontend.GetAttrValue(100, Model.Attrs)) %></font>
                    <%} %>
                </dd>
                <dt style="">技术年费：</dt>
                <dd><%=Model.Tech_Fee %>元 <%=string.Format("({0})",Wuyiju.Model.ProductFrontend.GetAttrValue(105, Model.Attrs)) %></dd>
            </dl>

            <div class="labelStore clearfix">
                <asp:Repeater runat="server" ID="rptKeywords">
                    <ItemTemplate>
                        <i class="label-sihd"><%# GetDataItem() %></i>
                    </ItemTemplate>
                </asp:Repeater>
            </div>

            <div style="clear: both;"></div>

            <div class="shop-info">
                <% if (LoggedState.IsLogged)
                    {%>
                <% if (Model.Whether_Goods == 1)
                    {%>
                <p><strong>可过户商标：</strong><%=Model.TrademarkType %> <%--<a id="btn-tm-view" href="javascript:;"><span class="hide-block">使用看店卡查看(还有<%=LoggedUser.Rank_Points %>张)</span></a>--%></p>
                <p><strong>卖家联系方式：</strong><%=Model.Seller_Phone %><%--<a id="btn-contract-view" href="javascript:;"><span class="hide-block">使用看店卡查看(还有<%=LoggedUser.Rank_Points %>张)</span></a>--%></p>
                <p><strong>店铺名称：</strong><%=Model.Subname.Replace(Model.Subname.Substring(1,1),"*") %><%--<a id="btn-url-view" href="javascript:;"><span class="hide-block">使用看店卡查看(还有<%=LoggedUser.Rank_Points %>张)</span></a>--%></p>
                <p><strong>店铺经营状况：</strong><%--<a id="btn-shop-view" href="javascript:;"><span class="hide-block">使用看店卡查看(还有<%=LoggedUser.Rank_Points %>张)</span></a>--%></p>
                <%}
    else
    { %>
<%--                <p><strong>可过户商标：</strong> <a id="btn-tm-view" href="javascript:;"><span class="hide-block">使用看店卡查看(还有<%=LoggedUser.Rank_Points %>张)</span></a></p>
                <p><strong>卖家联系方式：</strong><a id="btn-contract-view" href="javascript:;"><span class="hide-block">使用看店卡查看(还有<%=LoggedUser.Rank_Points %>张)</span></a></p>
                <p><strong>店铺名称：</strong><a id="btn-url-view" href="javascript:;"><span class="hide-block">使用看店卡查看(还有<%=LoggedUser.Rank_Points %>张)</span></a></p>
                <p><strong>店铺经营状况：</strong><a id="btn-shop-view" href="javascript:;"><span class="hide-block">使用看店卡查看(还有<%=LoggedUser.Rank_Points %>张)</span></a></p>--%>


                <p><strong>可过户商标：</strong> <%=Model.TrademarkType %></p>
                <p><strong>卖家联系方式：</strong><span class="hide-block">名字不公开</span></p>
                <p><strong>店铺名称：</strong><span class="hide-block">名字不公开</span></p>
                <p><strong>店铺经营状况：</strong></p>

                <%} }
                    else { %>
                <p><strong>可过户商标：</strong><%=Model.TrademarkType %></p>
                <p><strong>卖家联系方式：</strong><span class="hide-block">VIP会员可查看，<a href="/Users/Login.aspx?return=<%=Request.RawUrl %>">登陆</a></span></p>
                <p><strong>店铺名称：</strong><span class="hide-block">VIP会员可查看，<a href="/Users/Login.aspx?return=<%=Request.RawUrl %>">登陆</a></span></p>
                <p><strong>店铺经营状况：</strong></p>
                <%} %>
            </div>


            <div class="xq-btn clearfix">
                <input class="ljgm" type="button" value="立即购买" onclick="window.location.href = '<%=string.Format("/Users/MakeOrder.aspx?id={0}",Model.Id)%>    ';">
                <input class="ljyd" type="button" value="立即预定" onclick="window.location.href = '<%=string.Format("/Users/MakeOrder.aspx?id={0}",Model.Id)%>    ';">
                <input class="jrdb" type="button" value="加入对比" onclick="AddToSesList()" />
            </div>

            <div class="bd clearfix">

                <dl class="item-si">
                    <dt>服务承诺：</dt>
                    <dd style="padding-top: 3px;">
                        <ul class="transaction">
                            <li><i class="step flow1"></i>签署合同</li>
                            <li><i class="step flow4"></i>极速退款</li>
                        </ul>
                        <ul class="transaction">
                            <li><i class="step flow2"></i>担保交易</li>
                            <li><i class="step flow5"></i>支持线下</li>
                        </ul>
                        <ul class="transaction">
                            <li><i class="step flow3"></i>提供证件</li>
                            <li><i class="step flow6"></i>确认后放款</li>
                        </ul>
                    </dd>
                    <!--<dd><a class="gksp" href="javascript:void(0)" onclick="helpVideo()">观看帮助视频</a></dd>-->
                </dl>

            </div>




        </div>

        <div class="salesman">
            <h3>咨询业务客服</h3>
            <div class="photo">
                <div class="radius-bg"></div>
                <% if (Admin.Photo_Img.IsNullOrWhiteSpace())
                    { %>
                <img src="/Public/Home/Shops/Images/152348730_1.jpg" height="170" />
                <%}
                    else { %>
                <img alt="<%=Admin.Name %>" src="http://image.tmallzr.com/<%=Admin.Photo_Img %>" height="170" />
                <%} %>
            </div>
            <div class="name"><span><%=Admin.Name %></span></div>
            <div class="zixsaleman">
                <a href="javascript:void(0)" onclick="ShowAskWin('http://wpa.qq.com/msgrd?v=3&uin=<%=Admin.Qq %>&site=qq&menu=yes')">
                    <img src="/Public/Home/Shops/Images/mall/salesman_zixun_btn.png" border="0"></a>
            </div>
            <div class="salemaninfo">
                <p>联系Q Q：<%=Admin.Qq %></p>
                <p>联系电话：<%=Admin.Mobile %></p>
            </div><% string tmqq = (TeamMaster == null ? "" : TeamMaster.Qq); %>

            <div class="superior"><a href="javascript:void(0)" onclick="ShowAskWin('http://wpa.qq.com/msgrd?v=3&uin=<%=tmqq %>&site=qq&menu=yes')">联系主管</a><a href="javascript:void(0)" onclick="ShowAskWin('http://wpa.qq.com/msgrd?v=3&uin=<%=Manager.Qq %>&site=qq&menu=yes')">联系经理</a></div>
            <div class="pjman">
                <a class="more-answer" href="javascript:void(0)" onclick="ShowAskWin('http://wpa.qq.com/msgrd?v=3&uin=<%=Admin.Qq %>&site=qq&menu=yes')">TA的答复回复</a>
                <a class="more-shop" href="/Tmall.aspx?sell=<%=Admin.Id %>">更多TA的网店>></a>
            </div>
        </div>

    </div>

    <div class="tab-XiangQing-wrap wrap clearfix" style="margin-top: 20px;">
        <ul class="tab-XiangQing">
            <li><a href="javascript:void(0)" onclick="infoTabNew(1)" target="_self" class="cur">卖家描述</a></li>
            <li><a href="javascript:void(0)" onclick="infoTabNew(2)" target="_self">购买流程</a></li>
            <li><a href="javascript:void(0)" onclick="infoTabNew(3)" target="_self">常见问题</a></li>
            <li><a href="javascript:void(0)" onclick="infoTabNew(4)" target="_self">法律援助</a></li>
        </ul>
    </div>

    <div class="wrap tabOne">
        <div class="mjms"><%=Model.Brief %></div>
    </div>

    <div class="wrap tabTwo" style="margin-top: 40px;">
        <div class="borderMol clearfix" style="border-top: 1px solid #e6e6e6;">
            <div class="gmlc">
                <div class="hd">购买流程</div>
                <div class="bd"></div>
            </div>
        </div>
    </div>

    <div id="isameshopdiv" class="wrap tabThree" style="margin-top: 40px;">
        <div class="borderMol" style="border-top: 1px solid #e6e6e6;">
            <div class="faq">
                <div class="hd">
                    <!--<a class="hdRight gksp2" href="javascript:void(0)" onclick="helpVideo()">观看帮助视频</a>-->
                    常见问题
                </div>
                <div class="bd">
                    <ul class="WenDa-box">
                        <li class="tiwen">天猫转让是商标，公司与店铺一起卖的吗？</li>
                        <li class="huida">天猫商标是公司与店铺一并转让给您的，商标是否转让，需根据店铺类型决定，旗舰店属于店铺自有商标，过户时商标必须一并转给您，专营店是商标授权类型，主要是转让商标授权，不转商标不会影响经营。
                        </li>
                    </ul>
                    <ul class="WenDa-box">
                        <li class="tiwen">小规模纳税人升级一般纳税人需要什么条件？</li>
                        <li class="huida">亲爱的选猫会员您好！小规模纳税人升级一般纳税人是可以的，大概升级费用几百不定，但是每个地区的方式和条件都不一样，具体条件还请咨询当地税务局或者相关代办人员。
                        </li>
                    </ul>
                    <ul class="WenDa-box">
                        <li class="tiwen">在你平台买天猫服务费和代办费是怎么收的？多久可以办好？</li>
                        <li class="huida">我们是收取店铺全额成交价格的3%作为佣金。代办公司的代办过户费用大概是1500左右的，如商标不在公司名下，会有个商标过户1500左右，如果有印花税的话，这部分的价格另算。公司变更法人等信息大概是3-15个工作日完成，具体时间看当地工商局的一个办事的效率的，因为每个地方的时间都是不一样的，但是最慢的2周之内基本会变更完成的。在变更期间，您可以先接手店铺先运营的哦！具体想了解更多详情可联系400-0668-698.
                        </li>
                    </ul>
                    <ul class="WenDa-box">
                        <li class="tiwen">购买天猫店铺过户时间周期是多久？</li>
                        <li class="huida">亲爱的选猫会员您好,具体过户时间视当地工商等局的办理周期而定，每个省、市、地区不同，办理周期也会有所差异，通常情况下是1个月左右。
                        </li>
                    </ul>

                </div>
            </div>
            <div class="faq">
                <div class="hd">
                    <!--<a class="hdRight gksp2" href="javascript:void(0)" onclick="helpVideo()">观看帮助视频</a>-->
                    <a target="_blank" href="/Question/">其它网友正在问这些问题</a> 
                </div>
                <div class="bd">
                    <ul class="WenDa-box">
                        <li class="tiwen">买你们这里的天猫店铺，万一他公司不能过户怎么办？</li>
                        <li class="huida">亲爱的选猫会员您好，正确的说应该是变更公司的法人以及股权，受理变更业务的是国家工商局（所），是国家职能部门。不存在不能变更（过户）的情况。只有公司存在债务，债权等问题时工商会要求会计去税务局处理好才能变更。这些我们会提前告知您，并协助您进行处理的，确保买店的安全，不会存在公司不能过户的。如咨询具体详情可联系：400-0668-698.
                        </li>
                    </ul>
                    <ul class="WenDa-box">
                        <li class="tiwen">买来的天猫公司会不会税务债务问题？</li>
                        <li class="huida">亲爱的选猫会员您好,.如果卖家公司有银行欠款的话在公司过户时会被工商局拒绝过户申请，其它债务通过签署具备法律效力的股权转让协议来规定归属问题。
                        </li>
                    </ul>
                    <ul class="WenDa-box">
                        <li class="tiwen">公司过户以后，后期税务，账目，发票怎么弄？</li>
                        <li class="huida">亲爱的选猫会员您好！可以继续沿用卖家原来的会计或代记账公司继续给公司做账，或者在当地寻找另外的代账会计或者代记账公司办理。只需每月支付相关费用即可。（小规模公司大概300左右，一般公司500左右）
                        </li>
                    </ul>
                    <ul class="WenDa-box">
                        <li class="tiwen">公司过户，公司名字可以更改吗？地址可否变迁？</li>
                        <li class="huida">亲爱的选猫会员您好，公司名是可以变更的，但是需要您更改的公司名此前没有被注册，同时需要支付一定费用。（大概700左右）
地址也是可以变更的，具体的变更如果是不同市级的话，需要到原注册地工商局开转出证明和到接收地工商局开接收函，才可以办理变迁，同市级直接在当地工商局办理。
                        </li>
                    </ul>
                </div>
            </div>
            <div class="clear"></div>
        </div>

    </div>

    <div class="wrap tabFour" style="margin-top: 40px;">
        <div class="borderMol clearfix" style="border-top: 1px solid #e6e6e6;">
            <div class="flyz">
                <div class="hd">法律援助</div>
                <div class="bd">
                    <div class="desc">
                        <h4>无偿提供售后法律援助</h4>
                        <p>在选猫网，网店交易完成并不意味着服务的结束。选猫网与猪八戒网律师团队签订长期合作协议，24小时随时提供合同纠纷，网络诈骗的咨询服务，你终身无忧。</p>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div id="similar-bg">
        <div class="wrap similar">
            <div class="similar-title">
                <h3>相似网店推荐</h3>
                <p>为您推荐您查看的相似的店铺</p>
            </div>
            <div class="similar-with-time">
                <div class="similar-bg">
                    <img src="Public/Home/Shops/Img/adv/adv-shop-similar.jpg" />
                </div>
                <div class="similar-list">
                    <asp:Repeater runat="server" ID="rptSimilar1">
                        <ItemTemplate>
                            <div class="shop-item">
                                <h4><a href="/ShopView.aspx?id=<%# Eval("Id") %>"><%# Eval("Name") %></a></h4>
                                <div class="shop-attr">
                                    <ul>
                                        <li class="col-4">
                                            <strong>商城类型：</strong>
                                            <a href="#"><%# Eval("MallType") %></a>
                                        </li>
                                        <li class="col-4">
                                            <strong>主营类目：</strong>
                                            <a href="#"><%# Eval("Category_Name") %></a>
                                        </li>
                                        <li class="col-4">
                                            <strong>所在地区：</strong>
                                            <a href="#"><%# Eval("Area") %></a>
                                        </li>
                                        <li class="col-4">
                                            <strong>商标类型：</strong>
                                            <a href="#"><%# Eval("TrademarkType") %>标</a>
                                        </li>
                                        <li class="col-4">
                                            <strong>动态评分：</strong>
                                            <a href="#"><%# Eval("ScoreLevel") %></a>
                                        </li>
                                        <li class="col-4">
                                            <strong>违规评分：</strong>
                                            <a href="#"><%# Eval("WeiScore") %></a>
                                        </li>
                                        <li class="outer">
                                            <strong>一级类目：</strong>
                                            <a href="#"><%# Eval("Categories") %></a>
                                        </li>
                                    </ul>
                                </div>
                                <div class="shop-timer">
                                    <%--<div class="time" data-date="2016-06-08 01:00:00">
                                        距离结束：<span class="hour">19</span>时<span class="minute">19</span>分<span class="seconds">10</span>秒
                                    </div>--%>
                                    <div class="shop-price">
                                        <div class="category">
                                            <%--<img src="/Public/Home/Shops/Img/icon-cat-sm.png" />
                                            <p><%# Eval("Category_Name") %></p>--%>
                                        </div>
                                        <div class="price-box">
                                    
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
            </div>
            <div class="clear"></div>
            <div class="similar-others">
                <ul>
                    <asp:Repeater runat="server" ID="rptSimilar2">
                        <ItemTemplate>
                            <li>
                                <div class="shop-box">
                                    <h4><a href="/ShopView.aspx?id=<%# Eval("Id") %>"><%# Eval("Name") %></a></h4>
                                    <p class="shop-level">等级：<i class="icon-tmall"></i></p>
                                    <p>收藏：<%# Eval("Click") %></p>
                                    <p class="shop-price">售价：<strong>￥<%# Eval("Price") %>元</strong></p>
                                </div>

                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
        </div>
    </div>


</asp:Content>
