<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Taobao.aspx.cs" Inherits="Wuyiju.Web.Taobao" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/tmall.css" media="all">
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
                淘宝网店
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
                                    <li><a href="/Taobao.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"c") %>&c=<%# Eval("Id") %>" title="<%# Eval("Name") %>"><%# Eval("Name") %></a></li>
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
                                    <li><a href="/Taobao.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"l") %>&l=<%# Eval("Id") %>" title="<%# Eval("Name") %>"><%# Eval("Name") %></a></li>
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
                                    <li><a href="/Taobao.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"d") %>&d=<%# Eval("Id") %>" title="<%# Eval("Name") %>"><%# Eval("Name") %></a></li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
                <i class="crumbs-arrow">&gt;</i>
            </div>

            <%} %>


            <%if (!HasCat.IsNullOrEmpty() 
                    || !HasLevel.IsNullOrEmpty() 
                    || !HasPrice.IsNullOrEmpty() )
                { %>
            <div class="crumbs-nav-item clear-selected"><a href="/Taobao.aspx">清空筛选</a></div>
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
 <% if (HasCat.IsNullOrEmpty())
                {%>
            <dl>
                <dt>所属行业</dt>
                <dd>
                    <asp:Loop LoopType="Category" runat="server" CatId="0">
                        <ItemTemplate>
                            <span class="fltTabTo"><a href="/Taobao.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"c") %>&c=<%# Eval("Id") %>"><%# Eval("Name") %></a></span>
                        </ItemTemplate>
                    </asp:Loop>

                </dd>
            </dl>
            <%} %>

              <% if (HasLevel.IsNullOrWhiteSpace())
                { %>
            <dl>
                <dt>信用等级</dt>
                <dd>
                    <asp:Loop runat="server" LoopType="Attribute" CatId="3">
                        <ItemTemplate>
                            <span class="fltTabTo"><a href="/Taobao.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"l") %>&l=<%# Eval("Id") %>"><%# Eval("Name") %></a></span>
                        </ItemTemplate>
                    </asp:Loop>
                </dd>
            </dl>
            <%} %>
            <% if (HasPrice.IsNullOrWhiteSpace())
                {%>
            <dl>
                <dt>价格选择</dt>
                <dd>
                    <asp:Loop runat="server" LoopType="Attribute" CatId="19">
                        <ItemTemplate>
                            <span class="fltTabTo"><a href="/Taobao.aspx<%=Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param,"d") %>&d=<%# Eval("Id") %>"><%# Eval("Name") %></a></span>
                        </ItemTemplate>
                    </asp:Loop>
                </dd>
            </dl>
            <%} %>
          
        <!--<div class="fold"><a class="moreFlt" href="javascript:void(0)" onclick="fltHide('1');">更多</a></div>-->
        </div>
        <!--tmall_menu E -->
        <div class="rightImg" style="height: auto;">
            <a class="fbxq" href="javascript:void(0)"><i></i>
                <img src="/Public/Home/Shops/Images/fabuxuqiu-rightImg.png" alt="发布购店需求"></a>
            <a class="djdp" href="/Users/ShopsTransferType.aspx"><i></i>
                <img src="/Public/Home/Shops/Images/chushoudianpu-rightImg.png" alt="登记出售网店"></a>
            <div class="hideOne" style="display: none;">
                <img src="/Public/Home/Shops/Images/tmall-hidden-b.png">
            </div>
        </div>
    </div>

    <div id="itopshopdiv" class="wrap tmall" style="position: relative; margin-top: 5px; display: block;">
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
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <div class="wrap tmall" style="margin-top: 20px;">
        <div class="recommend listBox clearfix">
            <div class="hd">
                <input type="button" class="sort sort0" value="综合排序" onclick="window.location.href = <%=string.Format("'/Taobao.aspx{0}'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <% if (Request.QueryString["s"].TryParseToInt32(-1) != 1)
                    { %>
                <input type="button" class="sort sort1" value="上架时间" onclick="window.location.href = <%=string.Format("'/Taobao.aspx{0}&s=1'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <%}
                    else { %>
                <input type="button" class="sort sort2" value="上架时间" onclick="window.location.href = <%=string.Format("'/Taobao.aspx{0}&s=6'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <%} %>

                <% if (Request.QueryString["s"].TryParseToInt32(-1) != 2)
                    { %>
                <input type="button" class="sort sort2" value="出售价格" onclick="window.location.href = <%=string.Format("'/Taobao.aspx{0}&s=2'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <%}
                    else { %>
                <input type="button" class="sort sort1" value="出售价格" onclick="window.location.href = <%=string.Format("'/Taobao.aspx{0}&s=4'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <%} %>

                <% if (Request.QueryString["s"].TryParseToInt32(-1) != 3)
                    { %>
                <input type="button" class="sort sort1" value="热门店铺" onclick="window.location.href = <%=string.Format("'/Taobao.aspx{0}&s=3'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <%}
                    else { %>
                <input type="button" class="sort sort2" value="热门店铺" onclick="window.location.href = <%=string.Format("'/Taobao.aspx{0}&s=5'",Wuyiju.Web.Utils.UrlHelper.BuildQueryString(param))  %>" />
                <%} %>
            </div>
            <asp:Repeater runat="server" ID="rptTmalls">
                <ItemTemplate>
                    <div class="listItem">
                        <div class="leftPrice">
                            <a class="leftPrice" href="/ShopView.aspx?id=<%# Eval("Id") %>"><span class="classifyIcon t112"></span>
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
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
        <asp:AspNetPager ID="paging" runat="server" CssClass="fenye clearfix" UrlPageIndexName="p" AlwaysShow="True" UrlPaging="True" NumericButtonCount="10" PageSize="10" AlwaysShowFirstLastPageNumber="True" CurrentPageButtonClass="current" FirstLastButtonsClass="firstlast" FirstPageText="首页" HorizontalAlign="Right" LastPageText="末页" MoreButtonsClass="more" NextPageText="下一页" PageIndexBoxClass="indexbox" PagingButtonsClass="" PagingButtonSpacing="0px" PrevNextButtonsClass="prenext" PrevPageText="上一页" ShowFirstLast="False" SubmitButtonClass="submitbtn" SubmitButtonText="前往"></asp:AspNetPager>
    </div>

    <div class="postwant-lf">
        <div class="wrap">
            <img src="/Public/Home/Shops/Images/nofindwant.png" alt="" style="vertical-align: middle;">
            <div class="shixiaoms">
                <h2 class="title">暂未找到心仪网店？</h2>
                <p>让300名服务顾问帮您搜寻，10分钟找到心仪网店！</p>
                <p style="margin-top: 10px;"><a class="fbxq-btn" href="javascript:void(0)" onclick="/Users/QiugouSubmit.aspx">立即发布购店需求</a></p>
            </div>
        </div>
    </div>

    <div class="clear"></div>

    <script>
        $(function () {
            $(".menu-drop").mouseenter(function () {
                $(this).addClass('z-menu-drop-open');
            }).mouseleave(function () {
                $(this).removeClass('z-menu-drop-open');
            });
        });
    </script>
</asp:Content>
