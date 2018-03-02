<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuthMobileHandle.aspx.cs" Inherits="Wuyiju.Web.users.AuthMobileHandle" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
     <% if (!ViewState["Error"].IsNull())
            {%>
        <div class="err" style="width: 250px;">
            <div class="icon_0"><%=ViewState["Error"] %></div>
        </div>
        <%}
            else if (!ViewState["Message"].IsNull())
            {%>
        <div class="err" style="width: 250px;">
            <div class="icon_1"><%=ViewState["Message"] %></div>
        </div>
        <%} %>
    <div class="con-manageCenter sjrz">
        <form id="iform1" name="form1" action="" method="post">
            <div class="fillNum">
                <dl class="clearfix">
                    <dt><span style="font-weight: bold; color: #080808">认证：</span></dt>
                    <dd><span style="font-size: 13px; color: #000">已向[<%=LoggedUser.Mobile %>]发送短信验证码!</span></dd>
                    <dd></dd>
                </dl>
                <dl class="clearfix">
                    <dt><i>*</i>填写验证码：</dt>
                    <dd>
                        <input type="text" name="yanzhNum" id="iyanzhNum" value="" maxlength="10" autocomplete="off">
                    </dd>
                    <dd></dd>
                </dl>
                <dl class="clearfix">
                    <dt></dt>
                    <dd>
                        <button class="greenOK-btn" type="submit">确认</button></dd>
                </dl>
            </div>
        </form>

        <div class="SuccessfulPrivilege">
            <p class="title">如果您没有收到验证码短信：</p>
            <ul>
                <li><span>·短信到达需要1-2分钟，若您长时间未收到确认短信，建议您 <a href="javascript:DropReSend();" style="font-weight: bold; color: #FF0000;">重发验证码</a></span></li>
            </ul>
        </div>
        <br>
        <br>
        <br>
        <br>
        <br>
        <br>
        <br>
    </div>
</asp:Content>
