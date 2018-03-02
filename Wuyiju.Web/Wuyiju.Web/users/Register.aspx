<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Wuyiju.Web.users.Register" %>

<%--<asp:Content runat="server" ContentPlaceHolderID="HeadHolder">
    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/user.css" media="all" />
    <script language="javascript" type="text/javascript" src="/Public/Home/Shops/Js/register.js"></script>
    <script language="javascript" type="text/javascript" src="/Public/Home/Shops/Js/reg_check.js"></script>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">

    <form id="iform1" name="regform1" action="RegisterHandle.aspx" method="post">
        <input type="hidden" id="back_url" name="back_url" value="" />
        <div class="AnQuanSheZhi ZhuCe" style="position: relative;">
            <div class="title">
                <h1>用户注册</h1>
                <span class="OutSp">我已注册，现在就<a href="/User/Login.aspx">[登录]</a></span>
            </div>
            <div class="AQ-XinXi">
                <dl>
                    <dt>
                        <font color="#FF0000">*</font> 账户名：</dt>
                    <dd id="ishow1">
                        <input type="text" class="txt-style2" name="name" id="name" value="" maxlength="20" onblur="checkuname(this.value,'txtname');" />
                    </dd>
                    <dd class="Wen much" id="txtname">&middot;账户名为2-20位，由汉字、字母(不分大小
      
                        <br />
                        &nbsp;&nbsp;写)、数字或下划线组成！</dd>
                </dl>
                <dl>
                    <dt>
                        <font color="#FF0000">*</font> 请设置密码：</dt>
                    <dd id="ishow2">
                        <input type="password" class="txt-style2" name="pwd" id="pwd" maxlength="20" onblur="checkupwd(this.value,'txtpwd');" />
                    </dd>
                    <dd class="Wen much" id="txtpwd">&middot;密码为6-20位，由字母、数字或字符组成，
      
                        <br />
                        &nbsp;&nbsp;字母区分大小写！</dd>
                </dl>
                <dl class="QiangDu" id="iaqlev" style="display: none">
                    <dt></dt>
                    <dd>
                        <ul>
                            <li class="AQ">安全强度：</li>
                            <li id="ian1" class="">弱</li>
                            <li id="ian2" class="">中</li>
                            <li id="ian3" class="">强</li>
                        </ul>
                    </dd>
                </dl>
                <dl>
                    <dt>
                        <font color="#FF0000">*</font> 请确认密码：</dt>
                    <dd id="ishow3">
                        <input type="password" class="txt-style2" name="pwd2" id="pwd2" maxlength="20" onblur="checkuRpwd(this.value,'txtpwd2');" />
                    </dd>
                    <dd class="Wen" id="txtpwd2">&nbsp;</dd>
                </dl>
                <dl>
                    <dt>
                        <font color="#FF0000">*</font> 手机号：</dt>
                    <dd id="ishow4">
                        <input type="text" class="txt-style2" id="mobile" name="mobile" value="" maxlength="11" onblur="checkumobile(this.value,'txtmobile');" />
                    </dd>
                    <dd class="Wen" id="txtmobile">&middot;请填写常用的手机号码！</dd>
                </dl>
                <dl>
                    <dt>
                        <font color="#FF0000">*</font> 短信验证码：</dt>
                    <dd>
                        <input type="text" class="txt-style2 txt-style4" name="sms_code" id="sms_code" value="" />
                        <input type="button" id="idxnum" class="submit-style1" value="获取短信验证码" onclick="SendDxNum()" />
                    </dd>
                </dl>
                <dl>
                    <dt>推荐人：</dt>
                    <dd>
                        <input type="text" class="txt-style2" name="recode" id="recode" value="" maxlength="20" />
                    </dd>
                </dl>
                <dl style="padding-bottom: 0;">
                    <dt></dt>
                    <dd>
                        <label style="cursor: pointer;">
                            <input type="checkbox" name="yxcheckbox" id="iyxcheckbox" checked="" style="vertical-align: middle; margin-top: -2px; margin-bottom: 1px;" />
                            我同意《 <a  href="../about/agreement/id/2.html">选猫网服务使用协议</a> 》
                        </label>
                    </dd>
                </dl>
                <dl>
                    <dt></dt>
                    <dd>
                        <a href="javascript:void(0)" onclick="return checkRegistForm().html">
                            <img src="../Public/Home/Shops/Images/reg/ZhuCe-Zhu.jpg" style="padding-left: 0;" /></a>
                    </dd>
                    <!--<dd class="Wen"><a href="other_register.html">其它方式注册</a></dd>-->
                </dl>
            </div>
            <!--

        <div class="Photo">

        	<img src="images/reg/ZhuCe-ShouJi.png" />

        </div>-->
            <span style="position: absolute; top: 138px; right: 55px; text-align: center;">
                <img src="../Public/Home/Shops/Images/user/weixin.jpg" width="150" />
                <div class="describeTDC">
                    <p>关注选猫网官方微信</p>
                    <p class="org">最实用的电商情报</p>
                    <p class="org">了解才能做好电商</p>
                </div>
            </span>
        </div>
    </form>
    <div class="clear mb10"></div>

</asp:Content>--%>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>会员注册</title>


    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/register.css" media="all" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->

    <script type="text/javascript" src="/Public/Home/Shops/Js/jquery.min.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/Js/common.js"></script>

    <script language="javascript" type="text/javascript" src="/Public/Home/Shops/Js/register.js"></script>
    <script language="javascript" type="text/javascript" src="/Public/Home/Shops/Js/reg_check.js"></script>
</head>
<body>
    <div class="register-wrap">
        <div class="navigate">
            <a href="/" class="home">首页</a>
            -
            <a href="#">免费注册</a>
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
            <form id="iform1" name="regform1" action="RegisterHandle.aspx" method="post">
                <div class="valid-msg">
                    <p id="err-msg">请输入用户名</p>
                </div>
                <div class="control username">
                    <label for="name">用户名：</label>
                    <div class="input-wrap">
                        <i class="icon-person"></i>
                        <input type="text" class="name txt-style2" name="name" id="name" value="" maxlength="20" onblur="checkuname(this.value,'msg-username');" />
                    </div>
                    <div id="msg-username" class="tips">
                        账户名为2-20位，由汉字、字母(不分大小写)、数字或下划线组成！
                    </div>
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

                <div class="control qq">
                    <label for="qq">QQ号码：</label>
                    <div class="input-wrap">
                        <i class="icon-mobile"></i>
                        <input type="text" class="mobile txt-style2" id="qq" name="qq" value="" maxlength="11" />
                    </div>
                    <div id="msg-qq" class="tips">
                    </div>
                </div>


                <div class="control password">
                    <label for="password">登陆密码：</label>
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
                            <li id="ian1">弱</li>
                            <li id="ian2">中</li>
                            <li id="ian3">强</li>
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

                <div class="control introduce">
                    <label for="introduce">推荐人：</label>
                    <div class="input-wrap">
                        <input type="text" class="mobile txt-style2" id="introduce" name="introduce" value="" maxlength="11" />
                    </div>
                    <div class="tips">
                        没有人推荐可留空
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
                        <input type="checkbox" name="yxcheckbox" id="iyxcheckbox" checked="" style="vertical-align: middle; margin-top: -2px; margin-bottom: 1px;" />
                        我已阅读并同意《选猫网网站服务协议》
                    </div>
                </div>

                <div class="control placeholder">
                    <label></label>
                    <div class="input-wrap">
                        <button type="button" class="btn-submit" onclick="checkRegistForm()">立即注册</button>
                    </div>
                </div>


            </form>
            <div class="footer"></div>
        </div>

    </div>
    <script type="text/javascript" src="/Public/Home/Shops/layer/layer.js"></script>
    <% if (!Request.QueryString["Message"].TryParseToString().IsNullOrWhiteSpace())
        { %>
    <script>
        layer.alert('<%=Request.QueryString["Message"]%>');
    </script>
    <%} %>
</body>
</html>
