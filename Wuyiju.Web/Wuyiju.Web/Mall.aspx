<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mall.aspx.cs" Inherits="Wuyiju.Web.Mall" MasterPageFile="~/Site.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/tmall.css" media="all">
    <script type="text/javascript" src="/Public/Home/Shops/Js/tmall.js"></script>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="wrap" style="position: relative;">
        <div class="guide">当前位置：首页 – 淘宝网店  </div>
    </div>

    <div class="wrap tmall clearfix" style="margin-top: 15px;">
        <!--tmall_menu S -->

        <div class="filtrateList">
            <!-- <dl class="yourSel" style="display:none;">
            <dt>您的选择</dt>
            <dd id="onselect"></dd>
        </dl>-->

            <dl>
                <dt>所属行业</dt>
                <dd>
                    <asp:Loop LoopType="Category" runat="server" CatId="0">
                        <ItemTemplate>
                            <span class="fltTabTo"><a class="<%# ViewState["catid"] != null && ViewState["catid"].TryParseToInt32() == (int)Eval("Id") ? "cur":"" %>" href="<%# string.Format("Mall.aspx?c={0}&q={1}",Eval("Id"),Request.QueryString["q"]) %>"><%# Eval("Name") %></a></span>
                        </ItemTemplate>
                    </asp:Loop>

                </dd>
            </dl>
            <!--<dl>
            <dt>商城类型</dt>
            <dd>
			<span class="fltTabTo"><a href="/mall/tmall/sort/1-0-27-0-0-0-0-0.html" >旗舰店</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-28-0-0-0-0-0.html" >专营店</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-29-0-0-0-0-0.html" >专卖店</a></span>    	
            </dd>
        </dl><dl>
            <dt>商标类型</dt>
            <dd>
			<span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-31-0-0-0-0.html" >R标</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-32-0-0-0-0.html" >TM标</a></span>    	
            </dd>
        </dl><dl>
            <dt>信用等级</dt>
            <dd>
			<span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-169-0-0-0.html" >无</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-34-0-0-0.html" >1钻</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-35-0-0-0.html" >2钻</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-36-0-0-0.html" >3钻</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-37-0-0-0.html" >4钻</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-38-0-0-0.html" >5钻</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-39-0-0-0.html" >1皇冠</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-40-0-0-0.html" >2皇冠</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-41-0-0-0.html" >3皇冠</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-42-0-0-0.html" >4皇冠</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-43-0-0-0.html" >5皇冠</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-44-0-0-0.html" >1金冠</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-45-0-0-0.html" >2金冠</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-46-0-0-0.html" >3金冠</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-47-0-0-0.html" >4金冠</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-48-0-0-0.html" >5金冠</a></span>    	
            </dd>
        </dl><dl>
            <dt>价格选择</dt>
            <dd>
			<span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-0-50-0-0.html" >1千-5万</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-0-51-0-0.html" >5万-20万</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-0-52-0-0.html" >20万-50万</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-0-53-0-0.html" >50万-100万</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-0-54-0-0.html" >100万-200万</a></span><span class="fltTabTo"><a href="/mall/tmall/sort/1-0-0-0-0-55-0-0.html" >200万以上</a></span>    	
            </dd>
        </dl>		
		<form name="taobaoform" id="taobaoform" method="post" action="/mall/taobao/sort1/11-0-0-0-0-0-0-0.html">
        <!--<dl class="hideFltItem" style="z-index:20;">
            <dt>其&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;他</dt>
            <dd class="otherFlt">
                <span class="fltTabTo">
                    <div class="selectBox">
                        <input type="text" class="selected" name="ssBean.sarea" id="isarea" value="地区范围" readonly />
                        <i class="dropdown"></i>
                        <ul style="display:none;">
                            <li>地区不限</li>
                            <li>华北地区</li>
		                    <li>东北地区</li>
		                    <li>华东地区</li>
		                    <li>华南地区</li>
		                    <li>西北地区</li>
		                    <li>华中地区</li>
		                    <li>西南地区</li>
		                    <li>海外地区</li>
                        </ul>
                    </div>
                </span>
                <input type="hidden" name="ssBean.shopHour" id="ishopHour" value="" readonly />
                <input type="hidden" name="ssBean.spingf" id="ispingf" value="" readonly />
                <span class="fltTabTo">
                    <div class="selectBox">
                        <input type="text" class="selected" name="ssBean.skouf" id="iskouf" value="扣分情况" readonly />
                        <i class="dropdown"></i>
                        <ul style="display:none;">
                            <li>不限</li>
                            <li>全无扣分</li>
                            <li>有一般违规扣分</li>
                            <li>有严重违规扣分</li>
                            <li>有售假违规扣分</li>
                        </ul>
                    </div>
                </span>
                <span class="fltTabTo">
                    <div class="selectBox">
                        <input type="text" class="selected" name="ssBean.nsrzz" id="nsrzz" value="纳税人资质" readonly />
                        <i class="dropdown"></i>
                        <ul style="display:none;">
                            <li>不限</li>
                            <li>一般纳税人</li>
                            <li>小规模纳税人</li>
                       </ul>
                    </div>
                </span>
                <span class="fltTabTo">
                    <div class="selectBox">
                        <input type="text" class="selected" name="ssBean.sdaih" id="isdaih" value="是否带货" readonly />
                        <i class="dropdown"></i>
                        <ul style="display:none;">
                            <li>不限</li>
                            <li>是</li>
                            <li>否</li>
                       </ul>
                    </div>
                </span>
                <span class="fltTabTo">
                    <div class="selectBox">
                        <input type="text" class="selected" name="ssBean.shuoy" id="ishuoy" value="提供货源" readonly />
                        <i class="dropdown"></i>
                        <ul style="display:none;">
                            <li>不限</li>
                            <li>是</li>
                            <li>否</li>
                       </ul>
                    </div>
                </span>
                <span class="fltTabTo">
                    <div class="selectBox">
                        <input type="text" class="selected" name="ssBean.sbleib" id="sbleib" value="商标类别" readonly />
                        <i class="dropdown"></i>
                        <ul style="display:none;">
                            <li>不限</li>
                            <li>第01类~化学原料</li>
                            <li>第02类~涂料油漆</li>
                            <li>第03类~日化用品</li>
                            <li>第04类~油脂燃料 </li>
                            <li>第05类~医药品</li>
                            <li>第06类~金属材料</li>
                            <li>第07类~机械设备</li>
                            <li>第08类~手工器械</li>
                            <li>第09类~科学仪器</li>
                            <li>第10类~医疗器械</li>
                            <li>第11类~家用电器</li>
                            <li>第12类~运输工具</li>
                            <li>第13类~军火烟火</li>
                            <li>第14类~珠宝钟表</li>
                            <li>第15类~乐器</li>
                            <li>第16类~办公用品</li>
                            <li>第17类~橡胶制品</li>
                            <li>第18类~皮革皮具</li>
                            <li>第19类~建筑材料</li>
                            <li>第20类~家具</li>
                            <li>第21类~厨房洁具</li>
                            <li>第22类~绳网袋篷</li>
                            <li>第23类~纱线丝</li>
                            <li>第24类~布料床单</li>
                            <li>第25类~服装鞋帽</li>
                            <li>第26类~花边衬料</li>
                            <li>第27类~地毯席垫</li>
                            <li>第28类~运动用品</li>
                            <li>第29类~食品</li>
                            <li>第30类~方便食品</li>
                            <li>第31类~饲料种籽</li>
                            <li>第32类~啤酒饮料</li>
                            <li>第33类~酒</li>
                            <li>第34类~烟草烟具</li>
                            <li>第35类~广告贸易</li>
                            <li>第36类~金融物管</li>
                            <li>第37类~建筑修理</li>
                            <li>第38类~通讯传媒</li>
                            <li>第39类~运输旅行</li>
                            <li>第40类~材料加工</li>
                            <li>第41类~教育娱乐</li>
                            <li>第42类~科学服务</li>
                            <li>第43类~餐饮住宿</li>
                            <li>第44类~医疗园艺</li>
                            <li>第45类~社会服务</li>
                       </ul>
                    </div>
                </span>
                <span class="fltTabTo">
                    <div class="selectBox">
                        <input type="text" class="selected" name="ssBean.sbguoh" id="sbguoh" value="商标过户" readonly />
                        <i class="dropdown"></i>
                        <ul style="display:none;">
                            <li>不限</li>
                            <li>可以过户</li>
                            <li>只能授权</li>
                       </ul>
                    </div>
                </span>
                <span class="fltTabTo">
                    <div class="selectBox">
                        <input type="text" class="selected" name="ssBean.steam" id="isteam" value="团队转让" readonly />
                        <i class="dropdown"></i>
                        <ul style="display:none;">
                            <li>不限</li>
                            <li>是</li>
                            <li>否</li>
                       </ul>
                    </div>
                </span>
                <div class="clear"></div>
            </dd>
        </dl>
        <dl style="border-bottom:1px solid #fff;">
            <dt style="line-height:33px;">关键字/编号</dt>
            <dd><input type="text" name="searid" id="searid" value="" class="searchTxt" />
			<input class="searchBtn" type="button" value="确定搜索" onclick="searchSbt();" />
			</dd>
        </dl>
	</form>	
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
                <input type="button" class="sort sort0" value="综合排序" onclick="window.location.href = '/Tmall.aspx'" />

                <input type="button" class="sort sort1" value="上架时间" onclick="window.location.href = '/Tmall.aspx'" />

                <input type="button" class="sort sort2" value="出售价格" onclick="window.location.href = '/Tmall.aspx'" />

                <input type="button" class="sort sort1" value="热门店铺" onclick="window.location.href = '/Tmall.aspx'" />

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


</asp:Content>