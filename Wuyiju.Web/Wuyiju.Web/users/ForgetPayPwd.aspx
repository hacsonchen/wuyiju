<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgetPayPwd.aspx.cs" Inherits="Wuyiju.Web.users.ForgetPayPwd" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>找回密码</title>


    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/register.css" media="all" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->

    <script type="text/javascript" src="/Public/Home/Shops/Js/jquery.min.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/Js/common.js"></script>

    <script language="javascript" type="text/javascript" src="/Public/Home/Shops/Js/forget_pwd.js"></script>
</head>
<body>
    <div class="register-wrap">
        <div class="navigate">
            <a href="/" class="home">首页</a>
            -
            <a href="#">找回密码</a>
        </div>
        <div class="register-form">
            <div class="register-logo">
                <a href="/">
                    <h1>选猫网</h1>
                </a>
                
            </div>
            <div class="register-title">
                <h2>选猫网，全国最大网络店铺转让平台</h2>
            </div>
            <form id="iform1" name="regform1" action="ForgetPayPwd.aspx" method="post">
                <div class="valid-msg">
                    <p id="err-msg">请输入用户名</p>
                </div>
  
                <div class="control mobile">
                    <label for="name">手机号：</label>
                    <div class="input-wrap">
                        <i class="icon-mobile"></i>
                        <input type="text" class="mobile txt-style2" id="mobile" name="mobile" value="" maxlength="11" onblur="checkumobile(this.value,'msg-mobile');" />
                    </div>
                    <div id="msg-mobile" class="tips">
                        请填写常用的手机号码！
                    </div>
                </div>


                <div class="control password">
                    <label for="password">新的密码：</label>
                    <div class="input-wrap">
                        <i class="icon-lock"></i>
                        <input type="password" class="txt-style2" name="pwd" id="pwd" maxlength="20" onblur="checkupwd(this.value,'msg-pwd');" />
                    </div>
                    <div id="msg-pwd" class="tips">
                        密码为6-20位，由字母、数字或字符组成，字母区分大小写！
                    </div>
                </div>

                <div id="iaqlev" style="" class="control placeholder pwd-level">
                    <label></label>
                    <div class="input-wrap">
                        <ul>
                            <li class="AQ">安全强度：</li>
                            <li id="ian1" >弱</li>
                            <li id="ian2" >中</li>
                            <li id="ian3" >强</li>
                        </ul>
                    </div>
                </div>

                <div class="control password">
                    <label for="name">确认密码：</label>
                    <div class="input-wrap">
                        <i class="icon-lock"></i>
                        <input type="password" class="txt-style2" name="pwd2" id="pwd2" maxlength="20" onblur="checkuRpwd(this.value,'msg-pwd2');" />
                    </div>
                    <div id="msg-pwd2" class="tips">
                    </div>
                </div>

                <div class="control validcode">
                    <label for="sms_code">验证码：</label>
                    <div class="input-wrap">
                        <input type="text" class="" name="sms_code" id="sms_code" value="" />
                    </div>
                    <div class="tips">
                        <a id="idxnum" href="javascript:;" onclick="SendDxNum()">获取短信验证码</a>
                    </div>
                    
                </div>

                <div class="control placeholder">
                    <label></label>
                    <div class="input-wrap">
                        <button type="submit" class="btn-submit">找回密码</button>
                    </div>
                </div>


            </form>
            <div class="footer"></div>
        </div>

    </div>
     <script type="text/javascript" src="/Public/Home/Shops/layer/layer.js"></script>
    <% if (!ViewState["Message"].TryParseToString().IsNullOrWhiteSpace()) { %>
    <script>
        layer.alert('<%=ViewState["Message"]%>');
    </script>
    <%} %>

</body>
</html>
