<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Wuyiju.Web.Question.Default" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link rel="stylesheet" type="text/css" href="/Public/Home/Shops/Css/liststyle.css" media="all" />
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="main">
        <div class="current">当前位置：<a href="/">首页</a> &gt; <a href="/question/">在线问答</a></div>
        <div style="width: 100%; overflow: hidden;"></div>
        <div class="main_content2">
            <div class="shopstyle">
                <ul class="shopname">
                    <li><a id="is0" href="javascript:mkuaitj('0');" class="select">所有栏目</a></li>
                    <!--
                <li><a id="is8" href="javascript:mkuaitj('8');" >网店特卖</a></li>
                <li><a id="is9" href="javascript:mkuaitj('9');" >精品网店</a></li>
                <li><a id="is10" href="javascript:mkuaitj('10');" >拍卖频道</a></li>
                <li><a id="is11" href="javascript:mkuaitj('11');" >求购信息</a></li>
                <li><a id="is12" href="javascript:mkuaitj('12');" >推广联盟</a></li>-->
                </ul>
                <div id="three" style="background: #FFF;">
                    <ul class="question" id="iulshow">

                        <li>·<a onclick="fentj();" style="cursor: hand;" class="ahover" href="/question/">全部问题</a></li>
                        <asp:Loop runat="server" LoopType="QuestionType">
                            <ItemTemplate>
                                <li>·<a onclick="fentj();" style="cursor: pointer;" class="ahover" href="/question/?t=<%# Eval("Id") %>"><%# Eval("Type_Name") %></a></li>
                            </ItemTemplate>
                        </asp:Loop>

                    </ul>
                </div>
            </div>
            <script type="text/javascript">
                showcategory("0");
            </script>
            <div class="tab_box">
                <ul class="tabNavigation">
                    <li><a id="isg1" href="/question/" style="cursor: pointer;" class="ti2">网友正在提问</a></li>
                    <li><a id="isg2" href="/question/MyList.aspx" style="cursor: pointer;" class="ti1">我的提问</a></li>
                </ul>
                <div id="first">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0" id="aa">
                        <tbody>
                            <tr>
                                <th class="bt1" align="left">标题</th>
                                <th align="center" style="width: 80px;">浏览量</th>
                                <th align="center" style="width: 120px;">提问日期</th>
                                <th align="center" style="width: 80px;">问题状态</th>
                                <th align="center" style="width: 120px;">回答日期</th>
                            </tr>
                            <asp:Repeater runat="server" ID="rptQuestions">
                                <ItemTemplate>
                                    <tr>
                                        <td align="left">
                                            <a href="/question/answer.aspx?id=<%# Eval("Id") %>" title="" class="ahover" >· <%# Eval("Title") %></a>
                                        </td>
                                        <td align="center"><%# Eval("Click") %></td>
                                        <td align="center"><%# Eval("AddTime","{0:yyyy-MM-dd HH:mm}") %></td>
                                        <td align="center"><%# Eval("StatusText") %></td>
                                        <td align="center"><%# Eval("RespTime","{0:yyyy-MM-dd HH:mm}") %></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>

                        </tbody>
                    </table>

                    <asp:AspNetPager ID="paging" runat="server" CssClass="fenye clearfix" UrlPageIndexName="p" AlwaysShow="True" UrlPaging="True" NumericButtonCount="10" PageSize="10" AlwaysShowFirstLastPageNumber="True" CurrentPageButtonClass="current" FirstLastButtonsClass="firstlast" FirstPageText="首页" HorizontalAlign="Right" LastPageText="末页" MoreButtonsClass="more" NextPageText="下一页" PageIndexBoxClass="indexbox" PagingButtonsClass="" PagingButtonSpacing="0px" PrevNextButtonsClass="prenext" PrevPageText="上一页" ShowFirstLast="False" SubmitButtonClass="submitbtn" SubmitButtonText="前往"></asp:AspNetPager>
                </div>
            </div>
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
