<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ask.aspx.cs" Inherits="Wuyiju.Web.Ask" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>问一问</title>

    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/base.css" media="all" />
    <link type="text/css" rel="stylesheet" href="/Public/Home/Shops/Css/wenyiwen.css" media="all" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <script type="text/javascript" src="/Public/Home/Jq/jquery-1.6.4.min.js"></script>
    <script type="text/javascript" src="/Public/Home/Shops/Js/common.js"></script>
</head>
<body>
    <div id="wenyiwen-header">
        <div class="wyw-header wrap">
            <div class="wyw-title">
                <h3>问一问</h3>
                <p>选猫客户互肋平台</p>
            </div>
            <div class="wyw-search">
                <form action="/Article/Search.aspx" method="get">
                    <input type="text" name="q" class="keyword" placeholder="输入问题关键词" />
                    <button type="submit">找答案</button>
                    <i class="icon wenyiwen-icon"></i>
                </form>
            </div>
            <div class="clear"></div>
            <div class="wyw-questions">
                <ul>
                    <li>选猫客户 问了一个问题：<a href="#">店铺转让存在什么法律言问题？</a></li>
                    <li>您可能想知道：<a href="#">电商店铺转让流程大概要多少天时间？</a></li>
                    <li>其它问题：<a href="#">比起其它平台你们的优势体现在什么地方？</a></li>
                </ul>
            </div>
        </div>
    </div>
    <div id="wenyiwen-notice">
        <div class="wrap">
            <h4>公告</h4>
            <ul>
                <asp:Loop LoopType="Article" CatId="43" Limit="3" runat="server" ID="Loop7">
                    <ItemTemplate>
                        <li>
                            <a href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>">
                                <b></b>
                                <%# Eval("Title") %>
                            </a>
                        </li>
                    </ItemTemplate>
                </asp:Loop>
            </ul>
        </div>
    </div>
    <div id="wenyiwen-banner">
        <div class="wenyiwen-banner-body wrap">
            <div class="about-us">
                <h4>您应该了解的-选猫网</h4>
                <p><strong>公司愿景：</strong>打造国内第一电商服务平台；保持网店交易创导地位，提供更专业的资源整合服务；</p>
                <p><strong>价值观：</strong>客户的利益大于一切，顾客的满意是我们的最终目标；</p>
                <p><strong>使命感：</strong>让网店交易变得更简单，以更快的速度帮助电商人成功；</p>
                <p><strong>我们的团队：</strong>有理想、有干劲、有方法、有效率的热血团队。</p>
            </div>
            <div class="wyw-protect">
                <div class="arrow-left"></div>
                <div class="arrow-right"></div>
                <div class="protect-body">
                    <ul>
                        <li class="dbjy"><a href="#">担保交易</a></li>
                        <li class="flbz"><a href="#">法律保障</a></li>
                        <li class="shfw"><a href="#">售后服务</a></li>
                        <li class="mzgk"><a href="#">名字公开</a></li>
                    </ul>
                </div>
            </div>
            <div class="banner-bg-left"></div>
            <div class="banner-bg-right"></div>
        </div>
    </div>
    <div id="wenyiwen-question">
        <div class="question-raw wrap">

            <div class="question-title">
                <h3>热门问题</h3>
            </div>

            <div class="col-50">
                <div class="question-area cjwt">
                    <div class="question-title">
                        <h4>常见问题</h4>
                        <a href="/Article/List.aspx?id=54">查看全部</a>
                    </div>
                    <div class="question-list">
                        <ul>
                            <asp:Loop LoopType="Article" CatId="54" Limit="6" runat="server" ID="Zoujunjudian">
                                <ItemTemplate>
                                    <li>
                                        <a class="Awidth1" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>">
                                            <b></b>
                                            <%# Eval("Title") %>
                                        </a>
                                    </li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col-50">
                <div class="question-area flwt col-50">
                    <div class="question-title">
                        <h4>法律问题</h4>
                        <a href="/Article/List.aspx?id=48">查看全部</a>
                    </div>
                    <div class="question-list">
                        <ul>
                            <asp:Loop LoopType="Article" CatId="48" Limit="2" runat="server" ID="Loop1">
                                <ItemTemplate>
                                    <li>
                                        <a class="Awidth1" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>">
                                            <b></b>
                                            <%# Eval("Title") %>
                                        </a>
                                    </li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
                <div class="question-area zrwt col-50">
                    <div class="question-title">
                        <h4>转让问题</h4>
                        <a href="/Article/List.aspx?id=49">查看全部</a>
                    </div>
                    <div class="question-list">
                        <ul>
                            <asp:Loop LoopType="Article" CatId="49" Limit="2" runat="server" ID="Loop2">
                                <ItemTemplate>
                                    <li>
                                        <a class="Awidth1" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>">
                                            <b></b>
                                            <%# Eval("Title") %>
                                        </a>
                                    </li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
                <div class="question-area lcwt col-50">
                    <div class="question-title">
                        <h4>流程问题</h4>
                        <a href="/Article/List.aspx?id=52">查看全部</a>
                    </div>
                    <div class="question-list">
                        <ul>
                            <asp:Loop LoopType="Article" CatId="52" Limit="2" runat="server" ID="Loop3">
                                <ItemTemplate>
                                    <li>
                                        <a class="Awidth1" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>">
                                            <b></b>
                                            <%# Eval("Title") %>
                                        </a>
                                    </li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
                <div class="question-area shwt col-50">
                    <div class="question-title">
                        <h4>售后问题</h4>
                        <a href="/Article/List.aspx?id=53">查看全部</a>
                    </div>
                    <div class="question-list">
                        <ul>
                            <asp:Loop LoopType="Article" CatId="53" Limit="2" runat="server" ID="Loop4">
                                <ItemTemplate>
                                    <li>
                                        <a class="Awidth1" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>">
                                            <b></b>
                                            <%# Eval("Title") %>
                                        </a>
                                    </li>
                                </ItemTemplate>
                            </asp:Loop>
                        </ul>
                    </div>
                </div>
            </div>


        </div>
        <div class="clear"></div>
        <div class="question-raw wrap">
            <div class="others-area question-area col-50">
                <div class="question-title">
                    <h3>最新问题</h3>
                    <a href="/Article/List.aspx?id=47">查看全部</a>
                </div>
                <div class="question-list">
                    <ul>
                        <asp:Loop LoopType="Article" CatId="47" Limit="6" runat="server" ID="Loop5">
                            <ItemTemplate>
                                <li>
                                    <a class="Awidth1" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>">
                                        <b></b>
                                        <%# Eval("Title") %>
                                    </a>
                                </li>
                            </ItemTemplate>
                        </asp:Loop>
                    </ul>
                </div>
            </div>
            <div class="others-area question-area col-50">
                <div class="question-title">
                    <h3>最新问题</h3>
                    <a href="/Article/List.aspx?id=47">查看全部</a>
                </div>
                <div class="question-list">
                    <ul>
                        <asp:Loop LoopType="Article" CatId="47" Limit="6" runat="server" ID="Loop6">
                            <ItemTemplate>
                                <li>
                                    <a class="Awidth1" href="<%# string.Format("detail.aspx?id={0}",Eval("Id")) %>">
                                        <b></b>
                                        <%# Eval("Title") %>
                                    </a>
                                </li>
                            </ItemTemplate>
                        </asp:Loop>
                    </ul>
                </div>
            </div>
        </div>
        <div class="clear"></div>
    </div>
</body>
</html>
