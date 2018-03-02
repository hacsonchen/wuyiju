<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShopsTransferSubmit.aspx.cs" Inherits="Wuyiju.Web.users.ShopsTransferSubmit" MasterPageFile="~/Users/UserCenter.Master" %>
<%@ Import Namespace="Wuyiju.Domain.Model" %>


<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/user2.css" media="all">
    <script type="text/javascript" src="/Public/Home/Shops/js/jquery.min.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/layer/layer.js"></script>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter glzx MC_height1">
        <!--<div class="tab-glzx">
            		<li><a class="cur" href="/user/shopstransfersubmit/pid/1.html" target="_self">出售淘宝店</a></li>
            		<li><a href="/user/shopstransfersubmit/pid/2.html" target="_self">出售天猫商城</a></li>
                </div>-->



        <form name="spsendform" id="ifbform" method="post" action="#">
            <input type="hidden" name="type" value="1">
            <input type="hidden" name="status" value="0">
            <div class="shop-news">

                <div class="mt10">
                    <img src="/Public/Home/Shops/Images/user/chushouwangdian.png"><br>
                </div>
                <div class="red tc mt20 mb10" id="istrshow">
                    温馨提示：出售网店，交易成功后，选猫网将收取网店成交价格的<%=ApplicationConfig.DepositLabel %>%作为手续费！
                </div>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 信息标题 </dt>
                    <dd class="xhz">
                        <div style="width: 255px;" class="txt-style2">
                            <input name="spTitle" id="spTitle" type="text" value="">
                        </div>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 网店描述 </dt>
                    <dd class="xhz" style="height: 100%">
                        <div style="width: 530px;" class="txt-style2">
                            <textarea name="spBrief" id="spBrief"></textarea>
                        </div>
                    </dd>
                </dl>
                <div class="dianpu">
                    <h2>店铺信息</h2>
                </div>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 网店链接 </dt>
                    <dd class="xhz">
                        <div style="width: 435px;" class="txt-style2">
                            <input type="text" name="spUrl" id="spUrl" value="">
                        </div>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 旺旺名 </dt>
                    <dd class="xhz">
                        <div style="width: 255px;" class="txt-style2">
                            <input type="text" name="spAdmin" id="spAdmin" value="">
                        </div>
                        <span class="fabu_blue">(提交后不可修改,请正确填写)</span></dd>
                </dl>
                <p></p>
                <%--<dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 开店时间 </dt>
                    <dd class="xhz">
                        <div style="width: 120px;" class="txt-style2">
                            <input type="text" name="shopHours" id="shopHours" value="">
                        </div>
                        <span class="fabu">年</span></dd>
                </dl>
                <p></p>--%>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 网店价格</dt>
                    <dd class="xhz">
                        <div style="width: 120px;" class="txt-style2">
                            <input type="text" name="shopsPrice" id="shopsPrice" value="" maxlength="8">
                        </div>
                        <span class="fabu">元</span></dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 所属行业</dt>
                    <dd class="xhz">
                        <select name="category_id" style="height: 24px; margin-left: 20px; vertical-align: -2px; margin-top: 10px; color: #666666;">
                            <option value="0">== 请选择 ==</option>
                            <asp:Loop LoopType="Category" runat="server">
                                <ItemTemplate>
                                    <option value="<%# Eval("Id") %>"><%# Eval("Name") %></option>
                                </ItemTemplate>
                            </asp:Loop>
                        </select>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> 所在地区</dt>
                    <dd class="xhz">
                        <select name="area" style="height: 24px; margin-left: 20px; vertical-align: -2px; margin-top: 10px; color: #666666;">
                            <option value="0">== 请选择 ==</option>
                            <option value="华北地区">华北地区</option>
                            <option value="东北地区">东北地区</option>
                            <option value="华东地区">华东地区</option>
                            <option value="华南地区">华南地区</option>
                            <option value="西北地区">西北地区</option>
                            <option value="华中地区">华中地区</option>
                            <option value="西南地区">西南地区</option>
                            <option value="海外地区">海外地区</option>
                        </select>
                    </dd>
                </dl>

                <!------and------->
                <% foreach (var root in attributes.Where(d => d.Pid == ShopId && d.Recommend == 1))
                    { %>
                <p></p>
                <dl class="clearfix">
                    <dt class="wyfb"><i class="tipsRed">*</i> <%=root.Name %></dt>

                    <% if (root.Input == 0)
                        { %>
                    <dd class="xhz">
                        <select name="attr[]" style="height: 26px; margin-left: 20px; vertical-align: -2px; margin-top: 10px; color: #666666;">
                            <option value="0">== 请选择 ==</option>
                            <% foreach (var attr in attributes.Where(d => d.Pid == root.Id).ToList())
                                { %>
                            <option value="<%=string.Format("{0}_{1}_{2}", ShopId, root.Id, attr.Id) %>"><%=attr.Name %></option>
                            <%} %>
                        </select>
                    </dd>
                    <%}
                        else if (root.Input == 1)
                        {%>
                    <dd class="xhz">
                        <div style="width: 120px;" class="txt-style2">
                            <input type="text" name="input[1][<%=root.Id %>][]"  value="" maxlength="13">
                        </div>

                    </dd>
                    <% }
                        else if (root.Input == 2)
                        { %>
                    <dd class="xhz" style="height: auto;">
                        <div class="txt-style2">
                            <textarea name="input[2][<%=root.Id %>][]" style="resize: none; width: 420px; height: 70px; padding: 5px; font-size: 15px; border-radius: 3px;" autocomplete="off"></textarea>
                        </div>
                    </dd>
                    <%}
                        else if (root.Input == 3)
                        { %>
                    <dd class="xhz">
                        <% foreach (var attr in attributes.Where(d => d.Pid == root.Id).ToList())
                            { %>
                        <input class="check" style="width: 16px; height: 16px; border: #00FFFF;" type="checkbox" value="<%=attr.Id %>" name="input[3][<%=root.Id %>][]"><%=attr.Name %> &nbsp;
                    
                    <%} %>
                    </dd>
                    <%} %>
                </dl>
                <%} %>

                <!------end------->
                <dl class="clearfix">
                    <dt></dt>
                    <dd class="queren">
                        <input class="qrtj" type="button" value="" onclick="SendMind()"><a href="#">选猫网责任与义务相关声明</a></dd>
                </dl>
            </div>
        </form>
    </div>
    <script language="javascript" type="text/javascript" src="/Public/Home/Shops/Js/shops.js"></script>
    <% if (!ViewState["Message"].IsNull())
        { %>
    <script language="javascript" type="text/javascript">
        layer.alert('<%=ViewState["Message"].ToString() %>');
    </script>
    <%} %>
</asp:Content>
