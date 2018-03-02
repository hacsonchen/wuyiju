<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Wuyiju.Web.users.ChangePassword" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter glzx">

        <form name="myform" id="myform" action="/user/change_pwd.html" method="post" onsubmit="return check();">
            <div class="revise">
                <span>修改密码</span>
            </div>
            <div class="shop-news">

                <dl class="clearfix" style="margin-top: 10px;">
                    <dt>旧登录密码：</dt>
                    <dd>
                        <input type="password" name="passwd" id="passwd" maxlength="20" class="jbxx">
                        <span class="red" id="passwd_tip"></span>
                    </dd>
                </dl>
                <dl class="clearfix">
                    <dt>新登录密码：</dt>
                    <dd>
                        <input type="password" name="new_pwd" id="new_pwd" maxlength="20" class="jbxx">
                        <span class="red" id="new_pwd_tip"></span>
                    </dd>
                </dl>
                <dl class="clearfix">
                    <dt>确认新密码：</dt>
                    <dd>
                        <input type="password" name="confirm_pwd" id="confirm_pwd" maxlength="20" class="jbxx">
                        <span class="red" id="confirm_pwd_tip"></span>
                    </dd>
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

                if (passwd.length < 6) {
                    $('#passwd_tip').html('请输入长度不小于六位的原始密码');
                    return false;
                }
                else {
                    $('#passwd_tip').html('');
                }

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
