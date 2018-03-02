<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NotFound.aspx.cs" Inherits="Wuyiju.Web.NotFound" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>问一问</title>

    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/base.css" media="all" />
    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/notfound.css" media="all" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <script type="text/javascript" src="/Public/Home/Shops/Js/jquery.min.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/Js/common.js"></script>
</head>
<body>
    <div id="nf-header">
        <div class="header-contianer">
            <h1>暂未找到心仪网店</h1>
            <p>让300名专业服务顾问帮您搜寻 </p>
            <p>10分钟找到心仪网店</p>
            <a href="#" class="btn-fbxq">立即发布购店需求</a>
            <a href="#" class="btn-zxkf">咨询在线客服</a>
        </div>
    </div>
    <div id="nf-mall">

        <div class="nf-wrap">
            <h3>店铺类型</h3>
            <ul class="big-list dplx">
                <li><a href="javascript:;">天猫商城</a></li>
                <li><a href="javascript:;">淘宝网店</a></li>
            </ul>
            <div class="clear"></div>
            <ul class="small-list dplx">
                <li><a href="javascript:;">京东商城</a></li>
                <li><a href="javascript:;">蘑菇街</a></li>
                <li><a href="javascript:;">阿里巴巴</a></li>
                <li><a href="javascript:;">美丽说</a></li>
                <li><a href="javascript:;">一号店</a></li>
                <li><a href="javascript:;">国美在线</a></li>
                <li><a href="javascript:;">苏宁易购</a></li>
                <li><a href="javascript:;">当当网</a></li>
                <li><a href="javascript:;">楚楚街</a></li>
                <li><a href="javascript:;">贝贝网</a></li>
                <li><a href="javascript:;">独立商城</a></li>
            </ul>
            <div class="clear"></div>
        </div>
    </div>
    <div id="nf-name">
        <div class="nf-wrap">
            <h3>店铺名字</h3>
            <ul class="small-list dpmz">
                <li><a href="javascript:;">两个字</a></li>
                <li><a href="javascript:;">三个字</a></li>
                <li><a href="javascript:;">四个字</a></li>
                <li><a href="javascript:;">五个字</a></li>
                <li><a href="javascript:;">六个字</a></li>
                <li><a href="javascript:;">英文</a></li>
            </ul>
            <div class="clear"></div>
        </div>
    </div>
    <div id="nf-category">
        <div class="nf-wrap">
            <h3>所属行业</h3>
            <ul class="small-list sshy">
                <asp:Loop runat="server" LoopType="Category" Limit="9">
                    <ItemTemplate>
                        <li><a href="javascript:;"><%# Eval("Name") %></a></li>
                    </ItemTemplate>
                </asp:Loop>

            </ul>
            <div class="clear"></div>
        </div>
    </div>
    <div id="nf-submit">
        <div class="nf-wrap">
            <form id="form1" method="post" action="/NotFound.aspx">
                <input id="sContent" name="content" type="hidden" />
                <a href="javascript:;" id="btn-submit">提交</a>
            </form>
            
            <p>300名专业顾问在线回复</p>
        </div>
        
    </div>
    <script>
        $(function () {
            $('ul.big-list li,ul.small-list li').click(function () {
                if ($(this).hasClass('active')) {
                    $(this).removeClass('active');
                } else {
                    $(this).addClass('active');
                }
            });

            $('#btn-submit').click(function () {
                var dplxLst = $('ul.dplx>li.active>a');
                var dpmzLst = $('ul.dpmz>li.active>a');
                var sshyLst = $('ul.sshy>li.active>a');

                var dplxMap = dplxLst.map(function (item) {
                    return $(this).text();
                });

                var dpmzMap = dpmzLst.map(function (item) {
                    return $(this).text();
                });

                var sshyMap = sshyLst.map(function (item) {
                    return $(this).text();
                });

                $('#sContent').val('店铺类型:' + dplxMap + ' 店铺名字:' + dpmzMap + ' 所属行业:' + sshyMap )

                $('#form1').submit();

            });
        });
    </script>

      <script type="text/javascript" src="/Public/Home/Shops/layer/layer.js"></script>
    <% if (!ViewState["Message"].TryParseToString().IsNullOrWhiteSpace()) { %>
    <script>
        layer.alert('<%=ViewState["Message"]%>');
    </script>
    <%} %>
</body>
</html>
