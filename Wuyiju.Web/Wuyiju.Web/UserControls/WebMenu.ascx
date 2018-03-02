<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebMenu.ascx.cs" Inherits="Wuyiju.Web.UserControls.WebMenu" %>

<asp:Loop LoopType="Category" CatId="0" ID="Loop3" runat="server">
    <ItemTemplate>
        <div class="YinCang" id="cat_<%# Eval("Id") %>" style="display: none">
            <div class="YC-Left">
                <%--<dl class="YC-one'>">
                    <dt>天猫类型：</dt>--%>
                <% var roots = attributes.Where(d => d.Pid == 0).Take(2).ToList();%>

                <%--                    <% foreach (var root in roots)
                        { %>
                    <dd id="dd_<%# Eval("Id") %>_<%= root.Sort %>" onmouseover="daover('<%# Eval("Id") %>','<%= root.Sort %>')" class="cur">
                        <a href="#"><%= root.Name %></a>
                    </dd>
                    <%} %>--%>
                <%--</dl>--%>
                <% int i = 0; %>
                <% foreach (var root in roots)
                    { %>
                <%--                <% if (i == 0)
                    {%>
                <div id="div_<%# Eval("Id") %>_<%= root.Sort %>" style="display: block;">
                    <%}
                        else { %>--%>
                <div id="div_<%# Eval("Id") %>_<%= root.Sort %>" style="display: block;">
                    <%--                        <%} %>--%>

                    <% i++; %>
                    <% foreach (var level2 in attributes.Where(d => d.Pid == root.Id && root.Id == 2 && d.Recommend == 1).ToList())
                        { %>
                    <dl class="<%= level2.Extend1 %>" style="width: auto;">
                        <dt style="<%= level2.Extend2 %>"><%= level2.Name %>：</dt>
                        <% foreach (var level3 in attributes.Where(d => d.Pid == level2.Id).ToList())
                            { %>
                        <dd>
                            <a href="<%= string.Format("/tmall.aspx?{0}={1}", level2.Id == 26 ? "t": level2.Id == 30 ? "m": level2.Id == 33 ? "l" : level2.Id == 19 ? "d":"none" , level3.Id) %>"><%= level3.Name %>
                            </a>
                        </dd>
                        <%} %>
                    </dl>
                    <%} %>
                </div>
                <%} %>

                <dl class="YC-five" style="width: auto;">
                    <dt style="height: 30px;">纳税资质：</dt>

                    <dd>
                        <a href="/tmall.aspx?ct=0">一般纳税</a>
                    </dd>

                    <dd>
                        <a href="/tmall.aspx?ct=1">小规模纳税</a>
                    </dd>
                    <dd>
                        <a href="/tmall.aspx">不限</a>
                    </dd>
                </dl>
            </div>

        </div>
    </ItemTemplate>
</asp:Loop>
