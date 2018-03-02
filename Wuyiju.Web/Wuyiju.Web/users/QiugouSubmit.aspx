<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QiugouSubmit.aspx.cs" Inherits="Wuyiju.Web.users.QiugouSubmit" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter glzx MC_height1">
        <% if (!ViewState["Message"].IsNull() && !ViewState["Message"].ToString().IsNullOrEmpty())
            { %>
        <div class="err" style="width: 250px;">
            <div class="icon_1"><%=ViewState["Message"] %></div>
        </div>
        <% } %>

        <form name="spsendform" id="ifbform" method="post" action="/Users/QiugouSubmit.aspx">


            <div class="tab-glzx">
                <li><a class="cur" href="javascript:void(0)">发布求购</a></li>
            </div>
            <div class="shop-news">
                <div class="red tc mt20 mb10">
                </div>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 信息标题 </dt>
                    <dd class="xhz">
                        <div style="width: 255px;" class="txt-style2">
                            <input type="text" name="title" id="title" value="">
                        </div>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 求购描述 </dt>
                    <dd class="xhz" style="height: 102px">
                        <div style="width: 530px;" class="txt-style2">
                            <textarea name="brief" id="brief"></textarea>
                        </div>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb">参考价格 </dt>
                    <dd class="xhz">
                        <div style="width: 100px;" class="txt-style2">
                            <input type="text" name="start_price" id="start_price" value="">
                        </div>
                        <span class="fl">-</span>
                        <div style="width: 100px;" class="txt-style2">
                            <input type="text" name="end_price" id="end_price" value="">
                        </div>
                        &nbsp;元
                            <span class="BuXian" style="margin-left: 5px; _margin-top: 11px; display: inline-block; vertical-align: middle; _vertical-align: 2px; line-height: 52px;">
                                <input type="checkbox" name="is_price" id="is_price" value="0">不限</span>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb">求购数量 </dt>
                    <dd class="xhz">
                        <div style="width: 100px;" class="txt-style2">
                            <input type="text" name="stocks" id="stocks" value="" autocomplete="off">
                        </div>
                        <span class="BuXian" style="_margin-top: 11px; display: inline-block; _vertical-align: 2px; line-height: 52px;">
                            <input type="checkbox" name="is_stocks" id="is_stocks" value="0">不限</span>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb">求购有效期 </dt>
                    <dd class="xhz">
                        <select name="validDay" id="validDay" style="width: 80px; margin: 12px 0 0 20px;">
                            <option value="30">一个月</option>
                            <option value="90" selected="">三个月</option>
                        </select>
                    </dd>
                </dl>
                <div class="dianpu">
                    <h2>店铺信息</h2>
                </div>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 网店所属</dt>
                    <dd class="xhz" style="height:auto">
                        <asp:Loop runat="server" LoopType="Attribute" CatId="0">
                            <ItemTemplate>
                                <input type="radio" name="type" id="type" value="<%# Eval("Id") %>" checked=""><%# Eval("Name") %>
                            </ItemTemplate>
                        </asp:Loop>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 网店类型 </dt>
                    <dd class="xhz" >
                        <select name="cate_id" id="cate_id" style="width: 145px; margin: 12px 0 0 20px;">
                            <option value="">请选择网店所属类别</option>
                            <asp:Loop LoopType="Category" CatId="0" runat="server">
                                <ItemTemplate>
                                    <option value="<%# Eval("Id") %>"><%# Eval("Name") %></option>
                                </ItemTemplate>
                            </asp:Loop>

                        </select>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb">网店等级 </dt>
                    <dd class="xhz">
                        <input type="radio" class="xytk" name="level" id="level" value="0" onclick="ErJiLevel(\'0\');" checked="true">不限
						<input type="radio" class="xytk" name="level" id="level" value="1" onclick="ErJiLevel(\'1\');">心
						<input type="radio" class="xytk" name="level" id="level" value="2" onclick="ErJiLevel(\'2\');">钻
						<input type="radio" class="xytk" name="level" id="level" value="3" onclick="ErJiLevel(\'3\');">皇冠
						<input type="radio" class="xytk" name="level" id="level" value="4" onclick="ErJiLevel(\'4\');">金冠</dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb">等级子类 </dt>
                    <dd class="xhz">
                        <select style="width: 80px; margin: 12px 0 0 20px;" name="level_child" id="level_child">
                            <option value="0">所有等级</option>
                        </select>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb">好评率 </dt>
                    <dd class="xhz">
                        <select name="good_rating" id="good_rating" style="width: 80px; margin: 12px 0 0 20px;">
                            <option value="0.0">-请选择-</option>
                            <option value="99.0">99%以上</option>
                            <option value="98.0">98%以上</option>
                            <option value="97.0">97%以上</option>
                            <option value="96.0">96%以上</option>
                            <option value="95.0">95%以上</option>
                            <option value="94.0">94%以上</option>
                            <option value="93.0">93%以上</option>
                            <option value="92.0">92%以上</option>
                            <option value="91.0">91%以上</option>
                            <option value="90.0">90%以上</option>
                            <option value="89.0">89%以上</option>
                            <option value="88.0">88%以上</option>
                            <option value="87.0">87%以上</option>
                            <option value="86.0">86%以上</option>
                            <option value="85.0">85%以上</option>
                            <option value="84.0">84%以上</option>
                            <option value="83.0">83%以上</option>
                            <option value="82.0">82%以上</option>
                            <option value="81.0">81%以上</option>
                            <option value="80.0">80%以上</option>
                        </select>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb">动态评分 </dt>
                    <dd class="xhz">
                        <select name="rating" id="rating" style="width: 80px; margin: 12px 0 0 20px;">
                            <option value="0.0">-请选择-</option>
                            <option value="5.0">5.0以上</option>
                            <option value="4.5">4.5以上</option>
                            <option value="4.0">4.0以上</option>
                            <option value="3.5">3.5以上</option>
                            <option value="3.0">3.0以上</option>
                            <option value="2.5">2.5以上</option>
                            <option value="2.0">2.0以上</option>
                        </select>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb">创店时间 </dt>
                    <dd class="xhz">
                        <select name="created" id="created" style="width: 100px; margin: 12px 0 0 20px;">
                            <option value="0">-请选择-</option>
                            <% for (int i = DateTime.Now.Year; i >= 2003; i--)
                                {%>
                            <option value="<%=i %>"><%=i %>年以前</option>
                            <%} %>
                        </select>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb">卖家证件</dt>
                    <dd class="xhz">
                        <input class="check" type="checkbox" name="credentials[]" value="tzj1">身份证
                        <input class="check" type="checkbox" name="credentials[]" value="tzj2">手持身份证与上半身照
                        <input class="check" type="checkbox" name="credentials[]" value="tzj3">户口本
                        <input class="check" type="checkbox" name="credentials[]" value="tzj4">手持户口本</dd>
                </dl>
                <p></p>
                <div class="dianpu">
                    <h2>联系方式</h2>
                </div>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 您的姓名 </dt>
                    <dd class="xhz">
                        <div style="width: 255px;" class="txt-style2">
                            <input type="text" name="user_name" id="user_name" value="" maxlength="8">
                        </div>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 您的手机</dt>
                    <dd class="xhz">
                        <div style="width: 255px;" class="txt-style2">
                            <input type="text" name="mobile" id="mobile" value="" maxlength="11">
                        </div>
                    </dd>
                </dl>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> QQ号码</dt>
                    <dd class="xhz">
                        <div style="width: 255px;" class="txt-style2">
                            <input type="text" name="qq" id="qq" value="" maxlength="11">
                        </div>
                    </dd>
                </dl>
                <dl class="clearfix">
                    <dt></dt>
                    <dd class="queren">
                        <input class="qrtj" type="submit" value="" onclick="SendMind()"></dd>
                </dl>
            </div>
        </form>
        <script language="javascript" type="text/javascript" src="/Public/Home/Shops/Js/qiugou.js"></script>
    </div>
</asp:Content>
