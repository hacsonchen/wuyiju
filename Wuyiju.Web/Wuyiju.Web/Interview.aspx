<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Interview.aspx.cs" Inherits="Wuyiju.Web.Interview" %>

<%@ Import Namespace="Wuyiju.Domain.Model" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>售后采访</title>


    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/interview.css" media="all" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <script type="text/javascript" src="/Public/Home/Jq/jquery-1.6.4.min.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/Js/common.js"></script>
    <script>
        $(function () {

            $("#ddl-his").change(function () {
                var val = $(this).val();
                if (val) {
                    window.location.href = val;
                }
            });
        });
    </script>
</head>
<body>

    <div class="header-bar">
        <div class="interview-wrap">
            <div class="bar-logo">
                <h1>选猫网</h1>
            </div>
            <div class="bar-menu">
                <ul>
                    <li><a href="/">首页</a></li>
                    <li><a href="/Tmall.aspx">购买网店</a></li>
                    <li><a href="/Users/ShopsTransferType.aspx">出售网店</a></li>
                    <li><a href="/Users/QiugouSubmit.aspx">求购网店</a></li>
                    <li><a href="/Compared.aspx">网店估价</a></li>
                    <li><a href="#">淘宝知识</a></li>
                    <li><a href="/Question/">在线问答</a></li>
                    <li><a href="#">帮助中心</a></li>
                    <li><a href="#">客服中心</a></li>
                </ul>
            </div>
        </div>
    </div>


    <div class="interview-bg">

        <div class="interview-wrap">
            <div class="catgory-box">
                <div class="iv-his">
                    <select id="ddl-his">
                        <option>往期回顾</option>
                        <asp:Loop LoopType="Article" CatId="46" Limit="5" runat="server" ID="Zoujunjudian">
                            <ItemTemplate>
                                <option value="<%# string.Format("/Interview.aspx?id={0}",Eval("Id")) %>"><%# Eval("Title") %></option>
                            </ItemTemplate>
                        </asp:Loop>
                    </select>
                </div>

                <div class="share-box">
                    <!-- JiaThis Button BEGIN -->
                    <div class="jiathis_style">
                        <a class="jiathis_button_qzone"></a>
                        <a class="jiathis_button_tsina"></a>
                        <a class="jiathis_button_tqq"></a>
                        <a class="jiathis_button_weixin"></a>
                        <a class="jiathis_button_renren"></a>
                        <a href="http://www.jiathis.com/share" class="jiathis jiathis_txt jtico jtico_jiathis" target="_blank"></a>
                        <a class="jiathis_counter_style"></a>
                    </div>
                    <script type="text/javascript" src="http://v3.jiathis.com/code/jia.js" charset="utf-8"></script>
                    <!-- JiaThis Button END -->
                </div>
            </div>
            <div class="interview-box">
                <div class="interview-desc">
                    <h3>采访前言</h3>
                    <div class="desc-content">
                        <div class="remarks">
                            <%=Model.Brief %>
                        </div>
                    </div>
                </div>
                <div class="interview-desc">
                    <h3>本期主角介绍</h3>
                    <div class="desc-content">
                        <div class="interviewee">
                            <div class="interviewee-info">
                                <p><%=Model.GetValue("userInfo") %></p>
                                <p>平台关系：<%=Model.GetValue("relation") %></p>
                                <p>交易标题：<a href="#"><%=Model.GetValue("transTitle") %></a></p>
                                <p>平台关系：网店购买者</p>
                                <p>网店价格：<%=Model.GetValue("price") %>元</p>
                                <p>网店等级：</p>
                                <p>卖家描述：</p>
                            </div>
                            <div class="interviewee-score">
                                <p>半年动态评分：</p>
                                <p>宝贝与描述相符：</p>
                                <p><%=Model.GetArray("Score",0) %></p>
                                <p>卖家的服务态度：</p>
                                <p><%=Model.GetArray("Score",1) %></p>
                                <p>卖家的发货速度：</p>
                                <p><%=Model.GetArray("Score",2) %></p>
                                <p>主营类目：<%=Model.GetValue("category") %></p>
                                <p>创店时间：<%=Model.GetValue("createon") %></p>
                            </div>
                            <div class="clear"></div>
                        </div>
                    </div>
                </div>
                <div class="clear"></div>
            </div>
            <div class="interview-box" id="interview-main">
                <div class="interview-content">
                    <h3>采访现场</h3>
                    <div class="interview-body">
                        <%=Model.Info %>
                    </div>
                </div>
                <div class="interview-sidebar">
                    <div class="sidebar-desc" id="interview-image">
                        <h3>主角风采</h3>
                        <div class="desc-content">
                            <div class="image-box">
                                <img src="/<%=Model.Img %>" />
                            </div>
                        </div>
                    </div>
                    <div class="sidebar-desc" id="interview-history">
                        <h3>往期回顾</h3>
                        <div class="desc-content">
                            <ul>
                                <asp:Loop LoopType="Article" CatId="46" runat="server" ID="Loop1">
                                    <ItemTemplate>
                                        <li><a href="<%# string.Format("/Interview.aspx?id={0}",Eval("Id")) %>"><%# Eval("Title") %></a></li>
                                    </ItemTemplate>
                                </asp:Loop>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class="clear"></div>
            </div>

            <div class="interview-box" id="interview-footer-bg">
                <div class="footer-bg-left"></div>
                <div class="footer-bg-right"></div>
                <div class="interview-content">
                    <h3>结语</h3>
                    <div class="interview-body">
                        <%=Model.GetValue("remarks") %>
                    </div>
                </div>

            </div>
        </div>
    </div>
</body>
</html>
