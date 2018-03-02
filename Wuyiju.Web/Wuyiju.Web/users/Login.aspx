<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Wuyiju.Web.users.Login" %>

<%--<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/user.css" media="all" />

    <script type="text/javascript">

        $(function () {

            $(".login_btn").click(function () {

                $("#login_form").submit();
            });

            $("#user_name").focus(function () {
                $("#divErrorMssage").html("");
            });

            $("#user_pwd").focus(function () {
                $("#divErrorMssage").html("");
            });

        })

    </script>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="logSection" id="login">

        <form id="login_form" method="post">

            <div id="logSection1">
                <div class="log_user">
                    <div class="log_user1">
                        <input id="name" name="name" class="required txt" tabindex="1" accesskey="n" type="text" value="" maxlength="20" autocomplete="false" />
                    </div>
                </div>
                <div class="log_user">
                    <div class="log_user2">
                        <input id="password" name="password" tabindex="2" type="password" value="" maxlength="20" autocomplete="off" />
                    </div>

                    <div class="log_user3">
                        <a href="forgot_password.html">忘记密码</a>
                    </div>

                </div>



                <!--<div class="log_user">

                <div class="log_usercode">

                   <input id="vcode" name="vcode" class="required txt" tabindex="3" style="width:90px;" type="text" value="" maxlength="5" autocomplete="off"/>		

                </div>

                <div class="log_user3">

                    <img src="captcha.htm" onclick="this.src=_captcha.htm_d=_+new Date()_1"/>

                </div>

            </div>-->



                <div id="divErrorMssage" class="log_mem">
                    <label style="cursor: pointer;">
                        <strong><%=ErrorMessage %></strong>
                    </label>
                </div>

                <div class="log_mem">
                    <input type="hidden" id="back_url" name="back_url" value="" />
                    <!--登录-->
                    <input type="submit" accesskey="l" value="" style="width: 79px; height: 30px; float: left; border: 0; background: url(/Public/Home/Shops/Images/lang-button.jpg) no-repeat; cursor: pointer;" />
                    <div style="float: left; display: inline; height: 25px; margin-top: 2px; margin-left: 3px;"><span style="display: inline-block; vertical-align: middle; line-height: 25px;">还没有选猫网账号？</span><a href="register.html" class="registerLink" target="_self">30秒注册</a></div>
                </div>

            </div>

        </form>

        <div id="logSection2" style="position: relative;">

            <table cellpadding="0" cellspacing="0" border="0" width="150" height="65" style="position: absolute; top: 25px; left: 85px;">
                <tbody>
                    <tr>
                        <td>
                            <img src="../Public/Home/Shops/Images/user/weixin.jpg" width="150" />
                            <div class="describeTDC">
                                <p>关注选猫网官方微信</p>
                                <p class="org">最实用的电商情报</p>
                                <p class="org">了解才能做好电商</p>
                            </div>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>

    </div>
</asp:Content>--%>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>登陆</title>


    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/login.css" media="all" />

   
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <style>
         
      </style>
</head>
<body>

    <script src="js/bootstrap.min.js"></script>

    <div class="login-header">
        <div class="login-logo">
            <a href="/">
            <h1>选猫网</h1></a>
        </div>
        <div class="login-title">
            <h2>选猫网，全国最大网络店铺转让平台</h2>
        </div>
        <p class="description">淘宝  天猫  京东  拍拍  蘑菇街  阿里巴巴等都能交易哦</p>
    </div>

    <div class="login-body">
        <form id="login_form" method="post">
            <div class="control">
                <input id="name" name="name" class="username required txt" tabindex="1" accesskey="n" type="text" value="" maxlength="20" autocomplete="false" />
            </div>
            <div class="control">
                <input id="password" class="password" name="password" tabindex="2" type="password" value="" maxlength="20" autocomplete="off" />
            </div>

            <div class="control">
                <button type="submit" class="btn-submit">立即登陆</button>
            </div>

            <div class="control">
                <a href="/Users/Register.aspx" class="btn-register">注册帐号</a>
                <a href="/Users/ForgetPwd.aspx" class="btn-forget">忘记密码</a>
            </div>

        </form>
    </div>
    <div class="clear"></div>
    <div class="login-footer">
        <p class="about-us">
            <a href="#">帮助中心</a>
            <a href="#">安全保障</a>
            <a href="#">客服资询</a>
            <a href="#">关于我们</a>
        </p>
        <p class="copyright">
            Copyright 2011-2020 选猫网 版权所有 粤ICP备13011205号
        </p>
    </div>

    <script type="text/javascript" src="/Public/Home/Shops/Js/jquery.min.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/Js/common.js"></script>
     <script type="text/javascript" src="/Public/Home/Shops/layer/layer.js"></script>
    <% if (!Request.QueryString["error"].IsNullOrWhiteSpace()) { %>
    <script>
        layer.alert('<%=Request.QueryString["error"]%>');
    </script>
    <%} %>
</body>
</html>
