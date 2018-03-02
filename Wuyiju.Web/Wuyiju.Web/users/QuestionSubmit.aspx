<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuestionSubmit.aspx.cs" Inherits="Wuyiju.Web.users.QuestionSubmit" MasterPageFile="~/Users/UserCenter.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="BodyHolder">
    <div class="con-manageCenter xggrzl">

        <% if(!ViewState["Message"].IsNull() && !ViewState["Message"].ToString().IsNullOrEmpty()) { %>
        <div class="err" style="width:250px;">
				<div class="icon_1"><%=ViewState["Message"] %></div>                
			</div>
        <% } %>

        <div class="revise">
            <span>我要提问</span>
        </div>


        <form id="iform1" name="form1" action="/Users/QuestionSubmit.aspx" method="post">
            <input type="hidden" name="struts.token.name" value="token">
            <input type="hidden" name="token" value="Q9FV07B1VO3F9XUSXQQHF5NB9C8CW19R">
            <div class="shop-news" style="margin-top: 10px; display: block;">
                <dl class="clearfix wytw">
                    <dt>问题标题</dt>
                    <dd>
                        <input class="jbxx txt-style1" style="width: 516px;" type="text" id="ititle" name="title" value="" maxlength="50">
                        <p style="height: auto; border: none; line-height: 30px; color: #747474;">(最多可输入<font color="90c813">50</font>个字符)</p>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix wytw">
                    <dt>问题描述</dt>
                    <dd>
                        <textarea class="txt-style1" name="content" id="icontent" style="line-height: 20px;"></textarea>
                        <p style="height: auto; border: none; line-height: 30px; color: #747474;">(最多可输入<font color="90c813">1000</font>个字符)</p>
                    </dd>
                </dl>
                <p></p>
                <dl class="clearfix wytw">
                    <!--<dt>问题分类</dt>
                 		<dd>
						<select style="width:140px; margin-top:10px;" name="cname" id="icname" onchange="selName();">
	                  	<option value="">-请选择-</option>
	                  	<option value="8">网店特卖</option>
	                  	<option value="9">精品网店 </option>
	                  	<!--<option value="10">拍卖频道 </option>-->
                    <!--<option value="11">求购信息 </option>
	                  	<option value="12">推广联盟</option>
	   					</select>
   						</dd>
   					</dl>-->
                    <dt>问题分类</dt>
                    <dd>
                        <select style="width: 140px; margin-top: 10px;" name="default1" id="default1" onchange="selName();">
                            <option value="">-请选择-</option>
                            <option value="103">交易前</option>
                            <option value="104">交易中 </option>
                            <option value="105">交易后 </option>
                            <option value="106">其他问题 </option>

                        </select>
                    </dd>
                </dl>
                <!--
					<dl class="clearfix wytw">
	                	<dt>问题分类</dt>  
	                    <dd style="height:150px;">      
	                        <div>
	                           <select style="width:140px; height:137px;" name="default1" id="default1" size="8">
							   <option value="103">交易前</option>
							   <option value="104">交易中</option>
							   <option value="105">交易后</option>
							   <option value="106">其它问题</option>
							   </select>
	                        </div>
	                    </dd>
                	</dl>
					-->
                <p></p>
                <p></p>
                <!--验证码<dl class="clearfix wytw">
                    	<dt>验证码</dt>
                        <dd>
                		<input type="text" name="tyzcode" id="yanzheng" maxlength="6" class="jbxx txt-style1" style="width:100px;vertical-align:middle;" />&nbsp;&nbsp;<img id="iyzimg" src="/wucenter/rand.html" style="vertical-align:middle;" />&nbsp;&nbsp;<a href="javascript:changeYzCode();">点击换一个！</a>
                        </dd>
                    </dl>
					-->
                <dl class="clearfix">
                    <dt></dt>
                    <dd>
                        <input class="fbtw" type="submit" value="" onclick="check_data()"></dd>
                </dl>
            </div>
        </form>
    </div>
</asp:Content>
