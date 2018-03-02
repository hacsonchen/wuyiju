<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Answer.aspx.cs" Inherits="Wuyiju.Web.Question.Answer" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/liststyle.css" media="all" />

</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="main">
        <div class="current">当前位置：<a href="/">首页</a> &gt; <a href="/question/">在线问答</a></div>
        <div style="width: 100%; overflow: hidden;"></div>
        <div class="main_content2">
            <div class="List_ask">
                <h2></h2>
                <div class="cart_table">
                    <div class="wpuser">
                        <img src="/Public/Home/Shops/Images/question/head.jpg" border="0" width="80" height="98">
                        <div class="user_ser">选猫网用户</div>
                    </div>
                    <div class="wdq">
                        <ul class="ask_asw">
                            <li><strong class="aa_tits"><%=Model.Title %></strong></li>
                            <li class="gre">浏览：<%=Model.Click %> &nbsp;&nbsp;&nbsp;提问时间：<%=string.Format("{0:yyyy-MM-dd HH:mm}",Model.AddTime) %></li>
                            <li style="word-wrap: break-word; color: #848484;"><%=Model.Info %></li>
                        </ul>
                    </div>
                </div>
            </div>

            <% if (!Model.Resp.IsNullOrWhiteSpace())
                {%>

            <div class="seperate"></div>

            <div class="List_ask">
                <h3></h3>
                <div class="cart_table" style="position: relative;">
                    <div class="wpuser">
                        <img src="/Public/Home/Shops/Images/question/head.jpg" border="0" width="80" height="98">
                        <div class="user_ser">客服人员</div>
                    </div>
                    <div class="wdq" style="padding-bottom: 15px;">
                        <ul class="ask_asw">
                            <li class="gre">回答时间：<%=string.Format("{0:yyyy-MM-dd HH:mm}", Model.AddTime) %></li>
                            <li style="word-wrap: break-word; color: #848484;"><%=Model.Resp %></li>
                        </ul>
                    </div>
                    <div style="position: absolute; bottom: 8px; left: 178px; color: #777;"><a href="/" title="">选猫网</a> - 选猫</div>
                </div>
            </div>

            <%} %>
        </div>
        <div class="on-line-right">
            <div class="WebNoteR-GG hello">
                <div class="title">
                    <img src="/Public/Home/Shops/Images/question/ManageCenterRightTitle.png">
                </div>
                <div class="con-homeR clearfix">
                    <% if (LoggedState.IsLogged)
                        { %>
                    <p class="hello-ss">您好，<%=LoggedState.DisplayName %></p>
                    <%}
                        else {%>
                    <p class="hello-ss">您好，选猫网用户</p>
                    <%} %>
                    <p class="sum"><a href="/Question/MyList.aspx">&gt;&gt; 查看我的全部提问</a></p>
                </div>
            </div>

            <div class="twjy">
                <input type="button" class="wytw" value="" onclick="location.href = '/Users/QuestionSubmit.aspx'" />
                <input type="button" class="wyjy" value="" onclick="location.href = '/Users/SuggestSubmit.aspx'" />
            </div>

            <div class="WebNoteR-GG WenTi">
                <div class="title">
                    <img src="/Public/Home/Shops/Images/question/ManageCenterRightTitle.png">
                </div>
                <div class="con-homeR clearfix">
                    <ul class="list-WNr clearfix">
                        <asp:Loop runat="server" LoopType="Question" IsBest="true" Limit="5">
                            <ItemTemplate>
                                <li><a href="/Question/Answer.aspx?id=<%# Eval("Id") %>" class="ahover" title="" ><%# Eval("Title") %></a></li>
                            </ItemTemplate>
                        </asp:Loop>

                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class="clear"></div>
</asp:Content>
