<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProtectPassword.aspx.cs" Inherits="Wuyiju.Web.users.ProtectPassword" MasterPageFile="~/Users/UserCenter.Master" %>

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

        <form name="myform" id="myform" action="ProtectPassword.aspx" method="post" onsubmit="return check();">
            <div class="revise">
                <span>修改密码保护</span>
            </div>
            <div class="shop-news">
                <% if (HasQuestion)
                    { %>
                <dl class="clearfix" style="margin-top: 10px;">
                    <dt>原始问题：</dt>
                    <dd><%=Model.Pwd_Question %></dd>
                </dl>
                <dl class="clearfix" style="margin-top: 10px;">
                    <dt>您的答案：</dt>
                    <dd>
                        <input type="text" name="answer" id="answer" maxlength="20" class="jbxx" autocomplete="off">
                        <span class="red" id="answer_tip"></span>
                    </dd>
                </dl>
                <%} %>
                <dl class="mb10 clearfix">
                    <dt>新密保问题：</dt>
                    <dd>
                        <select style="margin-top: 14px; *margin-top: 6px;" name="pwd_question" id="pwd_question">
                            <option value="">-请选择-</option>
                            <option value="您的出生地是？">您的出生地是？</option>
                            <option value="您父亲的姓名是？">您父亲的姓名是？</option>
                            <option value="您父亲的生日是？">您父亲的生日是？</option>
                            <option value="您母亲的姓名是？">您母亲的姓名是？</option>
                            <option value="您母亲的生日是？">您母亲的生日是？</option>
                            <option value="您配偶的姓名是？">您配偶的姓名是？</option>
                            <option value="您配偶的生日是？">您配偶的生日是？</option>
                            <option value="您孩子的名字是？">您孩子的名字是？</option>
                            <option value="您小学的学校名称是？">您小学的学校名称是？</option>
                            <option value="您小学班主任的名字是？">您小学班主任的名字是？</option>
                            <option value="您中学的学校名称是？">您中学的学校名称是？</option>
                            <option value="您初中班主任的名字是？">您初中班主任的名字是？</option>
                            <option value="您高中班主任的名字是？">您高中班主任的名字是？</option>
                            <option value="您大学辅导员的名字是？">您大学辅导员的名字是？</option>
                            <option value="您的大学学号是？">您的大学学号是？</option>
                            <option value="您的工号是？">您的工号是？</option>
                        </select>
                        <span class="red" id="pwd_question_tip"></span>
                    </dd>
                </dl>




                <dl class="clearfix">
                    <dt>您的回答：</dt>
                    <dd>
                        <input type="text" name="pwd_answer" id="pwd_answer" value="" maxlength="20" class="jbxx">
                        <span class="red" id="pwd_answer_tip"></span>
                    </dd>
                </dl>

                <dl class="clearfix">
                    <dt>确认您的回答：</dt>
                    <dd>
                        <input type="text" name="con_answer" id="con_answer" value="" maxlength="20" class="jbxx">
                        <span class="red" id="con_answer_tip"></span>
                    </dd>
                </dl>

                <dl class="clearfix">
                    <dt></dt>
                    <dd>
                        <input class="qrtj" type="submit" value=""></dd>
                </dl>
            </div>
        </form>
        <script type="text/javascript">
            function check() {
                var answer = $.trim($('#answer').val());
                var pwd_question = $.trim($('#pwd_question').val());
                var pwd_answer = $.trim($('#pwd_answer').val());
                var con_answer = $.trim($('#con_answer').val());

                if (pwd_question.length < 1) {
                    $('#pwd_question_tip').html('请选择密保问题');
                    return false;
                }
                else {
                    $('#pwd_question_tip').html('');
                }
                if (pwd_answer.length < 1) {
                    $('#pwd_answer_tip').html('请输入密保答案');
                    return false;
                }
                else {
                    $('#pwd_answer_tip').html('');
                }
                if (con_answer.length < 1) {
                    $('#con_answer_tip').html('请再次确认密保答案');
                    return false;
                }
                if (pwd_answer != con_answer) {
                    $('#confirm_pwd_tip').html('两次输入的密保答案不相同');
                    return false;
                }
                return true;
            }

        </script>

    </div>
</asp:Content>


