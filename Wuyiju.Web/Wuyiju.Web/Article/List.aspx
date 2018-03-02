<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Wuyiju.Web.Article.List" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/news.css" media="all"/>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="main">
        <div class="guide" style="position: relative;">
            您现在的位置：<a href="/" title="首页">首页</a> － <a href="/List.aspx?cat=<%=Category.Id %>"><%=Category.Name %></a>
            <!--<form name="formcz" id="iformcz" method="post" action="#" target="_blank">
        	<div class="newsSearch">
                <input class="newStxt" type="text" name="ndesc" id="indesc" value="" maxlength="10">
                <input type="button" class="nsBtn" value="搜索" onclick="zxcz()">
            </div>
            </form>-->
        </div>
        <div id="wrapper">
            <div id="webNoteL">
                <div class="webNoteL1"><%=Category.Name %></div>
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
                <div class="webNoteR1">置顶<%=Category.Name %></div>
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
</asp:Content>
