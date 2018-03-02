<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Wuyiju.Web.Article.Search" MasterPageFile="~/Site.Master" %>

<asp:content runat="server" contentplaceholderid="HeadHolder">
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/news.css" media="all"/>
</asp:content>

<asp:content runat="server" contentplaceholderid="BodyHolder">
    <div class="main">
        <div class="guide" style="position: relative;">
            您现在的位置：<a href="/" title="首页">首页</a> － 搜索： <a href="/Article/Search.aspx?q=<%=ViewState["q"] %>"><%=ViewState["q"] %></a>
            <!--<form name="formcz" id="iformcz" method="post" action="#" target="_blank">
        	<div class="newsSearch">
                <input class="newStxt" type="text" name="ndesc" id="indesc" value="" maxlength="10">
                <input type="button" class="nsBtn" value="搜索" onclick="zxcz()">
            </div>
            </form>-->
        </div>
        <div id="wrapper">
            <div id="webNoteL">
                <div class="webNoteL1">您搜索的“<%=ViewState["q"] %>”</div>
                <div class="webNoteL2">
                    <asp:Repeater runat="server" ID="rptList">
                        <ItemTemplate>
                            <div class="noteNews">
                                <a href="<%# string.Format("/detail.aspx?id={0}",Eval("Id")) %>" target="_blank"><%# Eval("Title") %></a><span><%# Eval("AddDate") %></span>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <asp:AspNetPager ID="paging" runat="server" CssClass="fenye clearfix" UrlPageIndexName="p" AlwaysShow="True" UrlPaging="True" NumericButtonCount="10" PageSize="10" AlwaysShowFirstLastPageNumber="True" CurrentPageButtonClass="current" FirstLastButtonsClass="firstlast" FirstPageText="首页" HorizontalAlign="Right" LastPageText="末页" MoreButtonsClass="more" NextPageText="下一页" PageIndexBoxClass="indexbox" PagingButtonsClass="" PagingButtonSpacing="0px" PrevNextButtonsClass="prenext" PrevPageText="上一页" ShowFirstLast="False" SubmitButtonClass="submitbtn" SubmitButtonText="前往"></asp:AspNetPager>
                </div>
            </div>
            <div id="webNoteR">
                <div class="webNoteR1">置顶<%=ViewState["q"] %></div>
                <div class="webNoteR2">
                    <asp:Loop LoopType="Article" CatId="43" Limit="3" runat="server" ID="Loop7">
                        <ItemTemplate>
                             <div class="noteNlist">
                                <a href="<%# string.Format("/detail.aspx?id={0}",Eval("Id")) %>">
                                    <b></b>
                                    <%# Eval("Title") %>
                                </a>
                            </div>
                        </ItemTemplate>
                    </asp:Loop>
                </div>
            </div>
        </div>

    </div>
</asp:content>
