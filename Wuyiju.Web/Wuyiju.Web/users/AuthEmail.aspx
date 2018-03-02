<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuthEmail.aspx.cs" Inherits="Wuyiju.Web.users.AuthEmail" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter sjrz">

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

        <div class="step step1 yxrz"></div>

        <form id="iform1" name="form1" onsubmit="return EmailCheck();" action="/Users/AuthEmail.aspx" method="post">

            <% if (LoggedUser.Is_Email_Validated == 1)
                { %>
            <div class="fillNum">

                <div class="fillNum">

                    <div class="phoneCommon" style="color: #008000;">温馨提示：您的邮箱已通过认证！</div>
                    <div class="phoneCommon">
                        <span style="color: #008000;">您可以：</span>
                        <a href="/Users/EditInfo.aspx" style="color: #FF6600; font-weight: bold;">点击修改</a>
                    </div>

                    <div class="phoneCommon3" style="margin-top: 15px;"><a href="/Users/">返回我的选猫网</a></div>
                </div>

            </div>
            <%}
                else { %>

            <div class="fillNum">
                <dl class="clearfix">
                    <dt><i>*</i>填写邮箱地址</dt>
                    <dd>
                        <input type="text" class="txt-style1" name="renzemail" id="irenzemail" value="" maxlength="40" style="color: #868686; font-size: 12px;">
                    </dd>
                </dl>
                <!--
                      <dl class="clearfix">
                          <dt><i>*</i>填写验证码</dt>
                          <dd><input type="text" class="txt-style1" style="width:80px;"/></dd>
                          <dd><img src="/wucenter/images/DongTai/YanZhengMa.png" /></dd>
                          <dd style="font-size:12px; color:#666";>看不清？<a href="#" style="text-decoration:none;"><font color="#08baf4">换一张</font></a></dd>
                      </dl>
                      -->
                <dl class="clearfix">
                    <dt></dt>
                    <dd>
                        <button class="greenOK-btn" type="submit">确认</button></dd>
                </dl>
            </div>
            <%} %>
        </form>

        <div class="SuccessfulPrivilege">
            <p class="title">邮箱认证成功以后，您可以享有以下特权：</p>
            <ul>
                <li><span>·优先显示：</span>认证用户可优先显示上架店铺。</li>
                <li><span>·邮箱地址登录：</span>可直接使用"邮件账号"登录到选猫网。</li>
                <li><span>·重要事件提醒：</span>进行时，可及时收到邮件提醒。</li>
                <li><span>·找回账号密码：</span>忘记密码时，可使用邮件找回密码。</li>
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
