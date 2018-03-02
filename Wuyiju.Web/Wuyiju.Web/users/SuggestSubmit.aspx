<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuggestSubmit.aspx.cs" Inherits="Wuyiju.Web.users.SuggestSubmit" %>

<%--<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter xggrzl">
         <% if(!ViewState["Message"].IsNull() && !ViewState["Message"].ToString().IsNullOrEmpty()) { %>
        <div class="err" style="width:250px;">
				<div class="icon_1"><%=ViewState["Message"] %></div>                
			</div>
        <% } %>

        <form id="iform1" name="form1" onsubmit="return CheckTjForm_4();" action="/Users/SuggestSubmit.aspx" method="post">
            <div class="revise">
                <span>我要建议</span>
            </div>
            <style type="text/css">
                .TipsStyle3 span {
                    width: auto;
                }
            </style>

            <div class="TouSuJianYi">
                <textarea class="txt-style1 JianYi-txt" name="jycontent" id="ijycontent" style="line-height: 20px;"></textarea>
                <p class="mt15">
                    <input type="submit" class="org-rtbtn fbjy-btn" value="发表建议" onclick="check_data()"><span>（限200字）
                    </span>
                </p>
            </div>
        </form>
    </div>
</asp:Content>--%>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>有奖建议征集</title>


    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/suggest.css" media="all" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <script type="text/javascript" src="/Public/Home/Shops/js/jquery.min.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/Js/common.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/Js/scroll.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/layer/layer.js"></script>
    <script>
        $(function () {
            $("div.fee-records-wrap").myScroll({
                speed: 40, //数值越大，速度越慢
                rowHeight: 19 //li的高度
            });

            $("#btn-submit").click(function () {
                if (document.form1.jycontent.value.length == 0) {
                    layer.alert('内容不能为空!');

                } else if ($("#txt-name").val() == '') {
                    layer.alert('姓名不能为空!');

                } else if ($("#txt-contact").val() == '') {
                    layer.alert('联系不能为空!');

                } else {
                    $("#iform1").submit();
                }
            });

        });


    </script>
</head>
<body>

    <div class="header-bar">
        <div class="suggest-wrap">
            <div class="bar-logo">
                <h1>选猫网</h1>
            </div>
            <div class="bar-title">
                <h2>建议征集</h2>
            </div>
            <div class="back-home">
                <a href="/">返回首页</a>
            </div>
        </div>
    </div>


    <div class="suggest-banner">
    </div>

    <div class="suggest-wrap">
        <div class="fee-records with-shadow">
            <div class="shadow-top"></div>
            <div class="shadow-left"></div>
            <div class="fee-records-wrap">
                <ul>
                    <li>王** 建议已采纳 获得奖金￥300元</li>
                    <li>王** 建议已采纳 获得奖金￥300元</li>
                    <li>王** 建议已采纳 获得奖金￥300元</li>
                    <li>王** 建议已采纳 获得奖金￥300元</li>
                    <li>王** 建议已采纳 获得奖金￥300元</li>
                    <li>王** 建议已采纳 获得奖金￥300元</li>
                </ul>
            </div>
        </div>
        <p class="fee-desc">凡建议采纳就奖励100-1000元人民币奖金，或纪念礼品一份!</p>
        <form id="iform1" name="form1" action="/Users/SuggestSubmit.aspx" method="post">
            <div class="suggest-form">
                <p>在这里提出您建议意见</p>
                <div class="suggest-text with-shadow">

                    <div class="shadow-top"></div>
                    <div class="shadow-left"></div>
                    <textarea name="jycontent" id="ijycontent"></textarea>
                </div>
                <div class="suggest-info">
                    <div class="suggest-name">
                        <p>您的姓名：</p>
                        <div class="suggest-input with-shadow">
                            <div class="shadow-top"></div>
                            <div class="shadow-left"></div>
                            <input id="txt-name" type="text" name="name" />
                        </div>
                    </div>
                    <div class="suggest-contact">
                        <p>您的联系方式：</p>
                        <div class="suggest-input with-shadow">
                            <div class="shadow-top"></div>
                            <div class="shadow-left"></div>
                            <input id="txt-contact" type="text" name="contact" />
                        </div>
                    </div>

                </div>

                <div class="clear"></div>
            </div>
            <p>你的建议提交后我们会认真仔细阅读，如符合采纳要求，我们将会联系您！</p>
            <div class="suggest-action">
                <button type="button" id="btn-submit" class="btn-submit">提交您的建议</button>
                <div class="suggest-footer-bg"></div>
            </div>
        </form>
    </div>
    <div class="clear"></div>

    <% if (!ViewState["Message"].IsNull())
        { %>
    <script type="text/javascript">
        layer.alert('<%=ViewState["Message"].ToString() %>');
    </script>
    <%} %>
</body>
</html>
