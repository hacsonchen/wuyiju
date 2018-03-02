<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentPassword.aspx.cs" Inherits="Wuyiju.Web.users.PaymentPassword" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter glzx">

        <% if (!ErrorMessage.IsNullOrEmpty())
            {%>
        <div class="err" style="width: 250px;">
            <div class="icon_0"><%=ErrorMessage %></div>
        </div>
        <%} %>

        <% if (!Message.IsNullOrEmpty())
            {%>
        <div class="err" style="width: 250px;">
            <div class="icon_1"><%=Message %></div>
        </div>
        <%} %>

        <div class="revise">
            <span>设置支付密码</span>
        </div>

        <form action="PaymentPassword.aspx" name="myform" id="myform" method="post" onsubmit="return check();">

            <div class="shop-news">
                <% if (HasPaypwd)
                    { %>
                <dl class="clearfix" style="margin-top: 10px;">
                    <dt>旧支付密码：</dt>
                    <dd>
                        <input type="password" name="passwd" id="passwd" maxlength="20" class="jbxx">
                        <span class="red" id="passwd_tip"></span>
                    </dd>
                </dl>
                <%} %>
                <dl class="clearfix">
                    <dt>新支付密码：</dt>
                    <dd>
                        <input type="password" name="new_pwd" id="new_pwd" maxlength="20" class="jbxx">
                        <span class="red" id="new_pwd_tip"></span></dd>
                </dl>

                <dl class="clearfix">
                    <dt>确认新密码：</dt>
                    <dd>
                        <input type="password" name="confirm_pwd" id="confirm_pwd" maxlength="20" class="jbxx">
                        <span class="red" id="confirm_pwd_tip"></span></dd>
                </dl>

                <dl class="clearfix">
                    <dt></dt>
                    <dd>
                        <input class="qrtj" type="submit" value="" name="dosubmit"></dd>
                </dl>
            </div>
        </form>
        <script type="text/javascript">
            function check() {
                var passwd = $.trim($('#passwd').val());
                var new_pwd = $.trim($('#new_pwd').val());
                var confirm_pwd = $.trim($('#confirm_pwd').val());
                if (new_pwd.length < 6) {
                    $('#new_pwd_tip').html('请输入长度不小于六位的新密码');
                    return false;
                }
                else {
                    $('#new_pwd_tip').html('');
                }
                if (confirm_pwd.length < 6) {
                    $('#confirm_pwd_tip').html('请输入长度长度不小于六位的确认密码');
                    return false;
                }
                if (new_pwd != confirm_pwd) {
                    $('#confirm_pwd_tip').html('确认密码和原密码不相同');
                    return false;
                }
                return true;
            }
        </script>

    </div>
</asp:Content>
