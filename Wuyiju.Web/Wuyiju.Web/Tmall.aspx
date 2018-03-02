<%@ Page Title="天猫商城" Language="C#" AutoEventWireup="true" CodeBehind="Tmall.aspx.cs" Inherits="Wuyiju.Web.Tmall" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/tmall.css" media="all" />
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/bread.css" media="all" />
    <script type="text/javascript" src="/Public/Home/Shops/Js/tmall.js"></script>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="wrap" style="position: relative;">
        <div class="guide">

            <div class="crumbs-nav-item">
                当前位置：
            </div>

            <div class="crumbs-nav-item">
                首页
                <i class="crumbs-arrow">&gt;</i>
            </div>
            <div class="crumbs-nav-item">
                天猫商城
                <i class="crumbs-arrow">&gt;</i>
            </div>
            <% if (!HasCat.IsNullOrEmpty())
                { %>
            <div class="crumbs-nav-item">
                <div class="menu-drop">
                    <div class="trigger"><span class="curr"><%=HasCat %></span><i class="menu-drop-arrow"></i></div>
                    <div class="menu-drop-main">
                        <ul class="menu-drop-list">
                            <asp:Loop LoopType="Category" runat="server" CatId="0">
                                <ItemTemplate>
                                    <li><a  href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"c") %>&c=<%# Eval("Id") %>" title="<%# Eval("Name") %>"><%# Eval("Name") %></a></li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
                <i class="crumbs-arrow">&gt;</i>
            </div>
            <%} %>

            <% if (!HasMallType.IsNullOrEmpty())
                { %>
            <div class="crumbs-nav-item">
                <div class="menu-drop">
                    <div class="trigger"><span class="curr"><%=HasMallType %></span><i class="menu-drop-arrow"></i></div>
                    <div class="menu-drop-main">
                        <ul class="menu-drop-list">
                            <asp:Loop LoopType="Attribute" runat="server" CatId="26">
                                <ItemTemplate>
                                    <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"t") %>&t=<%# Eval("Id") %>" title="<%# Eval("Name") %>"><%# Eval("Name") %></a></li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
                <i class="crumbs-arrow">&gt;</i>
            </div>

            <%} %>

            <% if (!HasTM.IsNullOrEmpty())
                { %>
            <div class="crumbs-nav-item">
                <div class="menu-drop">
                    <div class="trigger"><span class="curr"><%=HasTM %></span><i class="menu-drop-arrow"></i></div>
                    <div class="menu-drop-main">
                        <ul class="menu-drop-list">
                            <asp:Loop LoopType="Attribute" runat="server" CatId="30">
                                <ItemTemplate>
                                    <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"m") %>&m=<%# Eval("Id") %>" title="<%# Eval("Name") %>"><%# Eval("Name") %></a></li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
                <i class="crumbs-arrow">&gt;</i>
            </div>

            <%} %>

            <% if (!HasLevel.IsNullOrEmpty())
                { %>
            <div class="crumbs-nav-item">
                <div class="menu-drop">
                    <div class="trigger"><span class="curr"><%=HasLevel %></span><i class="menu-drop-arrow"></i></div>
                    <div class="menu-drop-main">
                        <ul class="menu-drop-list">
                            <asp:Loop LoopType="Attribute" runat="server" CatId="33">
                                <ItemTemplate>
                                    <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"l") %>&l=<%# Eval("Id") %>" title="<%# Eval("Name") %>"><%# Eval("Name") %></a></li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
                <i class="crumbs-arrow">&gt;</i>
            </div>
            <%} %>

            <% if (!HasPrice.IsNullOrEmpty())
                { %>
            <div class="crumbs-nav-item">
                <div class="menu-drop">
                    <div class="trigger"><span class="curr"><%=HasPrice %></span><i class="menu-drop-arrow"></i></div>
                    <div class="menu-drop-main">
                        <ul class="menu-drop-list">
                            <asp:Loop LoopType="Attribute" runat="server" CatId="19">
                                <ItemTemplate>
                                    <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"d") %>&d=<%# Eval("Id") %>" title="<%# Eval("Name") %>"><%# Eval("Name") %></a></li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
                <i class="crumbs-arrow">&gt;</i>
            </div>

            <%} %>

            <% if (!HasKey.IsNullOrEmpty())
                { %>
            <div class="crumbs-nav-item">
                <div class="menu-drop">
                    <div class="trigger"><span class="curr"><%=HasKey %></span><i class="menu-drop-arrow"></i></div>
                    
                </div>
                <i class="crumbs-arrow">&gt;</i>
            </div>

            <%} %>


            <%if (!HasCat.IsNullOrEmpty()
                            || !HasMallType.IsNullOrEmpty()
                            || !HasLevel.IsNullOrEmpty()
                            || !HasTM.IsNullOrEmpty()
                            || !HasPrice.IsNullOrEmpty()
                            || !HasKey.IsNullOrEmpty())
                { %>
            <div class="crumbs-nav-item clear-selected"><a href="/Tmall.aspx">清空筛选</a></div>
            <%} %>
        </div>
    </div>

    <div class="wrap tmall clearfix" style="margin-top: 15px;">
        <!--tmall_menu S -->

        <div class="filtrateList">
            <!-- <dl class="yourSel" style="display:none;">
            <dt>您的选择</dt>
            <dd id="onselect"></dd>
        </dl>-->
            <% if (HasMallType.IsNullOrEmpty())
                { %>
            <dl>
                <dt><span>按商城类型</span></dt>
                <dd style="width: 330px; height: 60px;">
                    <asp:Loop runat="server" LoopType="Attribute" CatId="26">
                        <ItemTemplate>
                            <span class="fltTabTo"><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"t") %>&t=<%# Eval("Id") %>"><%# Eval("Name") %></a></span>
                        </ItemTemplate>
                    </asp:Loop>

                </dd>

                <dt><span>按商标类型</span></dt>
                <dd style="width: 314px; height: 60px;">
                    <asp:Loop runat="server" LoopType="Attribute" CatId="30">
                        <ItemTemplate>
                            <span class="fltTabTo"><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"m") %>&m=<%# Eval("Id") %>"><%# Eval("Name") %></a></span>
                        </ItemTemplate>
                    </asp:Loop>
                </dd>
            </dl>
            <%} %>
            <% if (HasCat.IsNullOrEmpty())
                {%>
            <dl>
                <dt><span>按所属行业</span></dt>
                <dd style="height: 110px;">
                    <asp:Loop LoopType="Category" runat="server" CatId="0">
                        <ItemTemplate>
                            <span class="fltTabTo"><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"c") %>&c=<%# Eval("Id") %>"><%# Eval("Name") %></a></span>
                        </ItemTemplate>
                    </asp:Loop>

                </dd>
            </dl>
            <%} %>
            <% if (HasPrice.IsNullOrWhiteSpace())
                {%>
            <dl>
                <dt><span>按价格选择</span></dt>
                <dd style="height: 60px;">
                    <asp:Loop runat="server" LoopType="Attribute" CatId="19">
                        <ItemTemplate>
                            <span class="fltTabTo"><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"d") %>&d=<%# Eval("Id") %>"><%# Eval("Name") %></a></span>
                        </ItemTemplate>
                    </asp:Loop>
                </dd>
            </dl>
            <%} %>


            <dl>
                <dt><span>其他筛选</span></dt>
                <dd style="height: 60px;">

                    <div class='diy_select'>
                        <div class="select-text">
                            <input type='hidden' name='' id="a" class='diy_select_input' />
                            <% if (HasArea.IsNullOrWhiteSpace())
                                {%>
                            <div class='diy_select_txt'>所属区域</div>
                            <%}
                                else { %>
                            <div class='diy_select_txt'><%=HasArea %></div>
                            <%} %>
                            <div class='diy_select_btn'></div>
                        </div>
                        <div class="select-option">
                            <ul class='diy_select_list'>
                                <%--<asp:Loop runat="server" LoopType="Attribute" CatId="19">
                            <ItemTemplate>
                            <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"d") %>&d=<%# Eval("Id") %>"><%# Eval("Name") %></a></li>
                            </ItemTemplate>
                         </asp:Loop>--%>
                                <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"a") %>&a=华北">华北</a></li>
                                <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"a") %>&a=东北">东北</a></li>
                                <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"a") %>&a=华东">华东</a></li>
                                <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"a") %>&a=华南">华南</a></li>
                                <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"a") %>&a=华中">华中</a></li>
                                <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"a") %>&a=西南">西南</a></li>
                                <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"a") %>&a=西北">西北</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class='diy_select'>
                        <div class="select-text">
                            <input type='hidden' name='' id="a" class='diy_select_input' />
                            <div class='diy_select_txt'>商标类型</div>
                            <div class='diy_select_btn'></div>
                        </div>
                        <div class="select-option">
                            <ul class='diy_select_list'>
                                <asp:Loop runat="server" LoopType="Attribute" CatId="290">
                                    <ItemTemplate>
                                        <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"m2") %>&m2=<%# Eval("Id") %>"><%# Eval("Name") %></a></li>
                                    </ItemTemplate>
                                </asp:Loop>
                            </ul>
                        </div>
                    </div>
                    <div class='diy_select'>
                        <div class="select-text">
                            <input type='hidden' name='' id="a" class='diy_select_input' />
                            <div class='diy_select_txt'>纳税类型</div>
                            <div class='diy_select_btn'></div>
                        </div>
                        <div class="select-option">
                            <ul class='diy_select_list'>
                                <%--<asp:Loop runat="server" LoopType="Attribute" CatId="19">
                            <ItemTemplate>
                            <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"d") %>&d=<%# Eval("Id") %>"><%# Eval("Name") %></a></li>
                            </ItemTemplate>
                         </asp:Loop>--%>
                                <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"ct") %>&ct=0">一般纳税</a></li>
                                <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"ct") %>&ct=1">小规模纳税</a></li>
                            </ul>
                        </div>
                    </div>
                    <%--<div class='diy_select'>
                   <div class="select-text">
                     <input type='hidden' name='' id="a" class='diy_select_input' />
                     <div class='diy_select_txt'>动态评分</div>
                     <div class='diy_select_btn'></div>
                   </div>
                    <div class="select-option">
                       <ul class='diy_select_list'>
                         <asp:Loop runat="server" LoopType="Attribute" CatId="19">
                            <ItemTemplate>
                            <li><a href="/Tmall.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"d") %>&d=<%# Eval("Id") %>"><%# Eval("Name") %></a></li>
                            </ItemTemplate>
                         </asp:Loop>
                      </ul>
                    </div>
                  </div>--%>
                </dd>
            </dl>

        </div>
        <!--tmall_menu E -->
        <div class="rightImg" style="height: auto;">
            <a class="fbxq" href="/Users/QiugouSubmit.aspx"><i></i>
                <img src="/Public/Home/Shops/Images/fabuxuqiu-rightImg.png" alt="发布购店需求" /></a>
            <a class="djdp" href="/Users/ShopsTransferType.aspx"><i></i>
                <img src="/Public/Home/Shops/Images/chushoudianpu-rightImg.png" alt="登记出售网店" /></a>
            <div class="hideOne" style="display: none;">
                <img src="/Public/Home/Shops/Images/tmall-hidden-b.png" />
            </div>
        </div>
    </div>

    <%-- <div id="itopshopdiv" class="wrap tmall" style="position: relative; margin-top: 5px; display: block;">
        <!--<a href="javascript:void(0)" onclick="ShowTopShops(shopStr)" class="hyp" title="换一批"></a>-->
        <div id="itopshop" class="recommend choicenesslist clearfix">
            <asp:Repeater runat="server" ID="rptRecommend">
                <ItemTemplate>
                    <div class="listItem">
                        <a class="leftPrice" href="/ShopView.aspx?id=<%# Eval("Id") %>"><span class="classifyIcon t112"></span>
                            <span class="price">￥<br>
                                <%# Eval("FormatPrice") %></span>
                            <i class="tjIco"></i>
                        </a>
                        <div class="rightBox">
                            <h2 class="linkTitle"><a href="<%# string.Format("/ShopView.aspx?id={0}",Eval("Id")) %>" title="汽车配件">汽车配件</a></h2>
                            <ul>
                                <li><span>所属行业</span><%# Eval("Category_Name") %></li>
                                <li><span>消 保 金</span><%# Eval("price") %>元</li>
                            </ul>
                            <ul>
                                <li><span>所在地区</span><%# Eval("Area") %></li>
                                <li><span>技术年费</span><%# Eval("Tech_Fee") %>元</li>
                            </ul>
                            <ul>
                                <li><span>商城类型</span>
                                    <%# Eval("MallType") %>                                                                                </li>
                                <li><span></span></li>
                            </ul>
                            <ul>
                                <li>
                                    <span>商标类型</span><%# Eval("TrademarkType") %>标
                                </li>
                                <li><span>违规扣分</span><b>0 - # - #</b></li>
                            </ul>
                            <ul>
                                <li><span>纳税资质</span>
                                    <%# Eval("TaxQualification") %>                                                  </li>
                                <li><span>是否带货</span><%# Eval("WhetherGoods") %></li>
                            </ul>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>--%>

    <div class="wrap tmall" style="margin-top: 20px;">
        <div class="recommend listBox clearfix">
            <div class="hd">
                <input type="button" class="sort sort0" value="综合排序" onclick="window.location.href = <%=string.Format("'/Tmall.aspx{0}'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <% if (Request.QueryString["s"].TryParseToInt32(-1) != 1)
                    { %>
                <input type="button" class="sort sort1" value="上架时间" onclick="window.location.href = <%=string.Format("'/Tmall.aspx{0}&s=1'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <%}
                    else { %>
                <input type="button" class="sort sort2" value="上架时间" onclick="window.location.href = <%=string.Format("'/Tmall.aspx{0}&s=6'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <%} %>

                <% if (Request.QueryString["s"].TryParseToInt32(-1) != 2)
                    { %>
                <input type="button" class="sort sort2" value="出售价格" onclick="window.location.href = <%=string.Format("'/Tmall.aspx{0}&s=2'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <%}
                    else { %>
                <input type="button" class="sort sort1" value="出售价格" onclick="window.location.href = <%=string.Format("'/Tmall.aspx{0}&s=4'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <%} %>

                <% if (Request.QueryString["s"].TryParseToInt32(-1) != 3)
                    { %>
                <input type="button" class="sort sort1" value="点赞数" onclick="window.location.href = <%=string.Format("'/Tmall.aspx{0}&s=3'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <%}
                    else { %>
                <input type="button" class="sort sort2" value="点赞数" onclick="window.location.href = <%=string.Format("'/Tmall.aspx{0}&s=5'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <%} %>

                <%--<div class="yemian-tip">
                    <span class="prev-yemian">
                        <img src="/Public/Home/Shops/Img/left.png"></span>1/213<span class="next-yemian"><img src="/Public/Home/Shops/Img/right.png"></span>
                </div>--%>
            </div>
            <asp:Repeater runat="server" ID="rptTmalls">
                <ItemTemplate>
                    <%--<div class="listItem">
                        <div class="leftPrice">
                            <a class="leftPrice" href="/ShopView.aspx?id=<%# Eval("Id") %>"><span class="classifyIcon t1<%# Eval("Category_Id") %>"></span>
                                <span class="price">￥<br>
                                    <%# Eval("FormatPrice") %></span></a>
                        </div>
                        <div class="rightBox">
                            <h2 class="linkTitle">
                                <a href="/shopview.aspx?id=<%# Eval("Id") %>" title="<%# Eval("Name") %>">
                                    <img src="/Public/Home/Shops/Images/tmlogo.jpeg" /><%# Eval("Name") %></a>
                            </h2>
                            <ul>
                                <li><span>所属行业</span><%# Eval("Category_Name") %></li>
                                <li><span>消 保 金</span><%# Eval("price") %>元</li>
                            </ul>
                            <ul>
                                <li><span>所在地区</span><%# Eval("Area") %></li>
                                <li><span>技术年费</span><%# Eval("Tech_Fee") %>元 (要退还)元</li>
                            </ul>
                            <ul>
                                <li><span>商城类型</span>
                                    <%# Eval("MallType") %>                                                                                </li>
                                <li><span></span></li>
                            </ul>
                            <ul>
                                <li>
                                    <span>商标类型</span><%# Eval("TrademarkType") %>标
                                </li>
                                <li><span>违规扣分</span><b>0 - # - #</b></li>
                            </ul>
                            <ul>
                                <li><span>纳税资质</span>
                                    <%# Eval("TaxQualification") %>                                                  </li>
                                <li><span>是否带货</span><%# Eval("WhetherGoods") %></li>
                            </ul>
                            <ul class="markLine2">
                                <li><span>一级类目</span><%# Wuyiju.Model.ProductFrontend.GetAttrValue(101,Eval("Attrs")) %></li>
                            </ul>
                            <ul class="storeMark">
                                <li><span>店铺标签</span>
                                    <%# Eval("Keywords") %>
                                   
                                </li>
                            </ul>
                            <ul class="storeMark">
                                <li style="color: #6f6f6f;"><span>卖家描述</span><div class="mjmsjlnr"><%# Eval("Brief") %></div>
                                    &nbsp;<a class="mjmsDetail" href="<%# string.Format("/ShopView.aspx?id={0}",Eval("Id")) %>">详细</a></li>
                            </ul>
                        </div>
                    </div>--%>
                    <div class="listItem">
                        <div class="leftPrice1">
                            <a class="leftPrice2"><span class="price"><%# Eval("FormatPrice") %></span> </a>
                            <a class="leftPrice3" target="_blank" href="/shopview.aspx?id=<%# Eval("Id") %>" title="<%# Eval("Name") %>"><%# Eval("Name") %></a>
                            <img class="tianmao-img" src="/Public/Home/Shops/Images/tmlogo.jpeg" />
                            <a class="see-xiangqing" target="_blank" href="/shopview.aspx?id=<%# Eval("Id") %>">查看详情</a>
                            <a class="call-kefu" onclick="ShowAskWin('http://wpa.qq.com/msgrd?v=3&uin=<%# Eval("QQ") %>&site=qq&menu=yes')"><span>联系在线客服<span><img src="/Public/Home/Shops/Img/qq.jpg" /></a>

                        </div>
                        <div class="leftImg">
                            <img src="/Public/Home/Shops/Images/category/icon-cat-<%# Eval("Category_Id") %>.png" />
                        </div>
                        <div class="rightBox">
                            <ul>
                                <li><span>商城类型：</span>
                                    <%# Wuyiju.Model.ProductFrontend.GetAttrValue(26,Eval("Attrs")) %>                                                                               </li>
                                </li>                                
                                <li><span>入住时间：</span><%# Eval("StartTime","{0:yyyy-MM}") %></li>
                            </ul>
                            <ul>
                                <li><span>经营类目：</span><%# Eval("Category_Name") %></li>

                                <li><span>动态评分：</span><span class="changegan"><%# Eval("ScoreLevel") %></span></li>
                            </ul>
                            <ul>
                                <li><span>所在地区：</span><%# Eval("Area") %></li>
                                <li><span>违规扣分：</span>
                                    <span class="changegan1"><%# Eval("Weiscore") %> </span></li>
                                </li>
                            </ul>
                            <ul>
                                <li>
                                    <span>商标类型：</span><%# Wuyiju.Model.ProductFrontend.GetAttrValue(30,Eval("Attrs")) %>
                                </li>
                                <li><span>价&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;     格：</span><%# Eval("Price") %>元</li>
                            </ul>
                            <%--            <ul>
                                <li><span>纳税资质</span>
                                    <%# Eval("TaxQualification") %>                                                  </li>
                                <li><span>是否带货</span><%# Eval("WhetherGoods") %></li>
                            </ul>--%>
                            <ul class="markLine2">
                                <li><span style="margin-left: 5px; font-size: 14px; color: #000;">一级类目：</span><span class="changedou" title="<%# Wuyiju.Model.ProductFrontend.GetAttrValue(101,Eval("Attrs")) %>"><%# Wuyiju.Model.ProductFrontend.GetAttrValue(101,Eval("Attrs")) %></span></li>
                            </ul>
                            <ul class="storeMark">
                                <li><span style="margin-left: 10px; font-size: 14px; color: #000;">店铺标签：</span>
                                    <span class="changedou" title="<%# Eval("Keywords") %>"><%# Eval("Keywords") %></span>

                                </li>
                            </ul>
                            <ul class="storeMark" style="width: 85%">
                                <li><span style="margin-left: 5px; font-size: 14px; color: #000;">卖家描述：</span><div class="mjmsjlnr" title="<%# Eval("Brief") %>"><%# Eval("Brief") %></div>
                                    &nbsp;</li>
                            </ul>
                            <a class="xiangqing-to" target="_blank" href="<%# string.Format("/ShopView.aspx?id={0}",Eval("Id")) %>">【详细】</a>
                            <a class="dianzan-link" href="javascript:;" onclick="likeshop(this,<%# Eval("Id") %>)">
                                <img alt="赞一个" src="/Public/Home/Shops/Img/like.png" /><span>喜欢(<%# Eval("Click") %>)</span></a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
        <asp:AspNetPager ID="paging" runat="server" CssClass="fenye clearfix" UrlPageIndexName="p" AlwaysShow="True" UrlPaging="True" NumericButtonCount="10" PageSize="10" AlwaysShowFirstLastPageNumber="True" CurrentPageButtonClass="current" FirstLastButtonsClass="firstlast" FirstPageText="首页" HorizontalAlign="Center" LastPageText="末页" MoreButtonsClass="more" NextPageText="下一页" PageIndexBoxClass="indexbox" PagingButtonsClass="" PagingButtonSpacing="0px" PrevNextButtonsClass="prenext" PrevPageText="上一页" ShowFirstLast="False" SubmitButtonClass="submitbtn" SubmitButtonText="前往"></asp:AspNetPager>
    </div>

    <div class="postwant-lf">
        <div class="wrap">
            <img src="/Public/Home/Shops/Images/nofindwant.png" alt="" style="vertical-align: middle;">
            <div class="shixiaoms">
                <h2 class="title">暂未找到心仪网店？</h2>
                <p>让300名服务顾问帮您搜寻，10分钟找到心仪网店！</p>
                <p style="margin-top: 10px;"><a class="fbxq-btn" href="/Users/QiugouSubmit.aspx" >立即发布购店需求</a></p>
            </div>
        </div>
    </div>

    <div class="clear"></div>

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

    <script type="text/javascript">

        function likeshop(self,id){
            debugger;
            $.ajax({
                type:'POST',
                url:'/Malls/AddLikeShop.aspx',
                data:{id:id},
                success:function(data){
                    if(data > 0){
                        $(self).find('span').text('喜欢(' + data +')');
                    }
                }
            });
        }

        function ShowAskWin(aurl) {
	        window.open(aurl,'',"width=644,height=544,toolbar=no,scrollbars=no,menubar=no,status=no");
        }

        $(function () {
            $('#ishopName').val('<%=HasKey %>');

            $(".menu-drop").mouseenter(function () {
                $(this).addClass('z-menu-drop-open');
            }).mouseleave(function () {
                $(this).removeClass('z-menu-drop-open');
            });
        });

        function diy_select() {
      this.init.apply(this, arguments)
     };
    diy_select.prototype = {
    init: function (opt) {
        this.setOpts(opt);
        this.o = this.getByClass(this.opt.TTContainer, document, 'div'); //容器
        this.b = this.getByClass(this.opt.TTDiy_select_btn); //按钮
        this.t = this.getByClass(this.opt.TTDiy_select_txt); //显示
        this.l = this.getByClass(this.opt.TTDiv_select_list); //列表容器
        this.ipt = this.getByClass(this.opt.TTDiy_select_input); //列表容器
        this.lengths = this.o.length;
        this.showSelect();
    },
    addClass: function (o, s) //添加class
    {
        o.className = o.className ? o.className + ' ' + s : s;
    },
    removeClass: function (o, st) //删除class
    {
        var reg = new RegExp('\\b' + st + '\\b');
        o.className = o.className ? o.className.replace(reg, '') : '';
    },
    addEvent: function (o, t, fn) //注册事件
    {
        return o.addEventListener ? o.addEventListener(t, fn, false) : o.attachEvent('on' + t, fn);
    },
    showSelect: function () //显示下拉框列表
    {
        var This = this;
        var iNow = 0;
        this.addEvent(document, 'click', function () {
            for (var i = 0; i < This.lengths; i++) {
                This.l[i].style.display = 'none';
            }
        })
        for (var i = 0; i < this.lengths; i++) {
            this.l[i].index = this.b[i].index = this.t[i].index = i;
            this.t[i].onclick = this.b[i].onclick = function (ev) {
                var e = window.event || ev;
                var index = this.index;
                This.item = This.l[index].getElementsByTagName('li');

                This.l[index].style.display = This.l[index].style.display == 'block' ? 'none' : 'block';
                for (var j = 0; j < This.lengths; j++) {
                    if (j != index) {
                        This.l[j].style.display = 'none';
                    }
                }
                This.addClick(This.item);
                e.stopPropagation ? e.stopPropagation() : (e.cancelBubble = true); //阻止冒泡
            }
        }
    },
    addClick: function (o) //点击回调函数
    {

        if (o.length > 0) {
            var This = this;
            for (var i = 0; i < o.length; i++) {
                o[i].onmouseover = function () {
                    This.addClass(this, This.opt.TTFcous);
                }
                o[i].onmouseout = function () {
                    This.removeClass(this, This.opt.TTFcous);
                }
                o[i].onclick = function () {
                    var index = this.parentNode.index; //获得列表
                    This.t[index].innerHTML = This.ipt[index].value = this.innerHTML.replace(/^\s+/, '').replace(/\s+&/, '');
                    This.l[index].style.display = 'none';
                    window.location = this.childNodes.item(0).href;
                }
            }
        }
    },
    getByClass: function (s, p, t) //使用class获取元素
    {
        var reg = new RegExp('\\b' + s + '\\b');
        var aResult = [];
        var aElement = (p || document).getElementsByTagName(t || '*');

        for (var i = 0; i < aElement.length; i++) {
            if (reg.test(aElement[i].className)) {
                aResult.push(aElement[i])
            }
        }
        return aResult;
    },

    setOpts: function (opt) //以下参数可以不设置  //设置参数
    {
        this.opt = {
            TTContainer: 'diy_select', //控件的class
            TTDiy_select_input: 'diy_select_input', //用于提交表单的class
            TTDiy_select_txt: 'diy_select_txt', //diy_select用于显示当前选中内容的容器class
            TTDiy_select_btn: 'diy_select_btn', //diy_select的打开按钮
            TTDiv_select_list: 'diy_select_list', //要显示的下拉框内容列表class
            TTFcous: 'focus' //得到焦点时的class
        }
        for (var a in opt) //赋值 ,请保持正确,没有准确判断的
        {
            this.opt[a] = opt[a] ? opt[a] : this.opt[a];
        }
    }
}


var TTDiy_select = new diy_select({ //参数可选
    TTContainer: 'diy_select', //控件的class
    TTDiy_select_input: 'diy_select_input', //用于提交表单的class
    TTDiy_select_txt: 'diy_select_txt', //diy_select用于显示当前选中内容的容器class
    TTDiy_select_btn: 'diy_select_btn', //diy_select的打开按钮
    TTDiv_select_list: 'diy_select_list', //要显示的下拉框内容列表class
    TTFcous: 'focus' //得到焦点时的class
}); 
    </script>

</asp:Content>
