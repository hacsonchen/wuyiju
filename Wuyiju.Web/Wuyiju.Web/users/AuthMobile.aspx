<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuthMobile.aspx.cs" Inherits="Wuyiju.Web.users.AuthMobile" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter sjrz">
        <form id="iform1" name="form1" action="" method="post">
            <div class="step step1"></div>
            <div class="fillNum">

                <div class="fillNum">
                    <% if (LoggedUser.Is_Mobile_Validated == 0)
                        { %>
                    <div class="phoneCommon" style="color: #008000;">温馨提示：您的手机号[<%=LoggedUser.Mobile %>]未通过认证！</div>
                    <div class="phoneCommon">
                        <span style="color: #008000;">您可以：</span>
                        <a href="/Users/EditInfo.aspx" style="color: #FF6600; font-weight: bold;">点击修改</a>
                        <a href="/users/AuthMobileHandle.aspx" onclick="return DropRenz()" style="color: #FF6600; font-weight: bold;">点击认证</a>

                    </div>
                    <%}
                        else { %>
                    <div class="phoneCommon" style="color: #008000;">温馨提示：您的手机号[<%=LoggedUser.Mobile %>]已通过认证！</div>
                    <%} %>
                    <div class="phoneCommon3" style="margin-top: 15px;"><a href="/Users/">返回我的选猫网</a></div>
                </div>

            </div>
        </form>



        <div class="SuccessfulPrivilege">
            <p class="title">手机认证成功以后，您可以享有以下特权：</p>
            <ul>
                <li><span>·重要事件提醒：</span>进行时，可及时收到短信提醒。</li>
                <li><span>·找回账号密码：</span>忘记密码时，可使用手机短信找回密码。</li>
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
