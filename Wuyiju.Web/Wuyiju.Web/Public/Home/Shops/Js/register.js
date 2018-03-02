
//注册:
function checkRegistForm()
{
	var name = document.getElementById("name");
	
	var sjnum = trim(name.value);

	if(sjnum == "") {
		layer.alert("请填写账户名！");
		name.focus();
		return false;
	}
	if(sjnum.length < 2 || sjnum.length > 20) {
		layer.alert("账户名长度为2-20位，由汉字、字母(不分大小写)、数字或下划线组成！");
		name.focus();
		return false;
	}	
	var iloginPwd = document.getElementById("pwd");
	var lgpwd = trim(iloginPwd.value);
	if(lgpwd == "") {
		layer.alert("登录密码不能为空！");
		pwd.focus();
		return false;
	}
	if(lgpwd.length < 6 || lgpwd.length > 20) {
		layer.alert("密码长度为6-20位，由字母、数字或字符组成，字母区分大小写！");
		pwd.focus();
		return false;
	}
	
	var irePwd = document.getElementById("pwd2");
	var repwd = trim(irePwd.value);
	if(repwd == "") {
		layer.alert("请再次填写登录密码！");
		pwd2.focus();
		return false;
	}
	if(repwd != lgpwd) {
		layer.alert("两次输入的密码不一致！");
		pwd2.focus();
		return false;
	}
	
	var mobile = document.getElementById("mobile");
	var umb = trim(mobile.value);
	if(umb == "") {
		layer.alert("请填写手机号！");
		mobile.focus();
		return false;
	}
	if(checkMob(umb) == false) {
		layer.alert("请正确填写手机号！");
		mobile.focus();
		return false;
	}
	
	var idxmsg = document.getElementById("sms_code");
	var dxmsg = trim(idxmsg.value);
	if(dxmsg == "") {
		layer.alert("请填写短信验证码！");
		sms_code.focus();
		return false;
	}
	if(dxmsg.length != 4) {
		layer.alert("请正确填写短信验证码！");
		sms_code.focus();
		return false;
	}
	
	var iyxcheckbox = document.getElementById("iyxcheckbox");
	if(iyxcheckbox.checked == false) {
		layer.alert("请您在阅读完并且同意服务使用协议后，提交注册信息！");
		iyxcheckbox.focus();
		return false;
	}

	document.getElementById("iform1").submit();
}

//安全设置:
function checkRegsetForm()
{
	var ipwdquestion = document.getElementById("ipwdquestion");
	var vpwdqst = trim(ipwdquestion.value);
	if(vpwdqst == "") {
		layer.alert("请选择一个提示问题！");
		ipwdquestion.focus();
		return false;
	}
	
	if(vpwdqst == "自定义问题") {
		var iothpwdqstion = document.getElementById("iothpwdqstion");
		var vopwdqst = trim(iothpwdqstion.value);
		if(vopwdqst == "") {
			layer.alert("请填写自定义问题！");
			iothpwdqstion.focus();
			return false;
		}
		if(vopwdqst.length < 2 || vopwdqst.length > 20) {
			layer.alert("自定义问题长度为2-20位，请正确填写！");
			iothpwdqstion.focus();
			return false;
		}
	}
	
	var ipwdanswer = document.getElementById("ipwdanswer");
	var npwda = trim(ipwdanswer.value);
	if(npwda == "") {
		layer.alert("提示答案不能为空！");
		ipwdanswer.focus();
		return false;
	}
	if(npwda.length < 2 || npwda.length > 20) {
		layer.alert("提示答案长度为2-20位，字母区分大小写！");
		ipwdanswer.focus();
		return false;
	}
	
	var itrueName = document.getElementById("itrueName");
	var vtname = trim(itrueName.value);
	if(vtname == "") {
		layer.alert("真实姓名不能为空！");
		itrueName.focus();
		return false;
	}
	if(CheckChineseChar(vtname) == false) {
		layer.alert("请正确填写真实姓名(注册后不能修改)！");
		itrueName.focus();
		return false;
	}
	if(vtname.length < 2 || vtname.length > 8) {
		layer.alert("请正确填写真实姓名(注册后不能修改)！");
		itrueName.focus();
		return false;
	}
	
	var iuqq = document.getElementById("iuqq");
	var vuqq = trim(iuqq.value);
	if(vuqq == "") {
		layer.alert("QQ号码不能为空！");
		iuqq.focus();
		return false;
	}
	if(vuqq.length < 4 || vuqq.length > 13) {
		layer.alert("请正确填写QQ号码！");
		iuqq.focus();
		return false;
	}
	if(isAllDigits(vuqq) == false) {
		layer.alert("请正确填写QQ号码！");
		iuqq.focus();
		return false;
	}
	
	var iuemail = document.getElementById("iuemail");
	var vemail = trim(iuemail.value);
	if(vemail == "") {
		layer.alert("安全邮箱不能为空！");
		iuemail.focus();
		return false;
	}
	if(vemail.length < 6 || vemail.length > 40) {
		layer.alert("请正确填写邮箱地址(注册后不能修改)！");
		iuemail.focus();
		return false;
	}
	if(IsMail(vemail) == false) {
		layer.alert("请正确填写邮箱地址(注册后不能修改)！");
		iuemail.focus();
		return false;
	}
	
	document.getElementById("iform1").submit();
}

function checkBangForm()
{
	var name = document.getElementById("name");
	if(trim(name.value) == "") {
		layer.alert("用户名不能为空！");
		name.focus();
		return false;
	}
	if(trim(name.value).length < 2 || trim(name.value).length > 20) {
		layer.alert("用户名长度为2-20位，由汉字、字母(不分大小写)、数字或下划线组成！");
		name.focus();
		return false;
	}
	
	var iloginPwd = document.getElementById("iloginPwd");
	if(trim(iloginPwd.value) == "") {
		layer.alert("登录密码不能为空！");
		iloginPwd.focus();
		return false;
	}
	if(trim(iloginPwd.value).length < 6 || trim(iloginPwd.value).length > 20) {
		layer.alert("登录密码长度为6-20位，由字母、数字组成，字母区分大小写！");
		iloginPwd.focus();
		return false;
	}
	
	var irePwd = document.getElementById("irePwd");
	if(trim(irePwd.value) == "") {
		layer.alert("请再次填写登录密码！");
		irePwd.focus();
		return false;
	}
	if(trim(irePwd.value) != trim(iloginPwd.value)) {
		layer.alert("两次输入的登录密码不一致！");
		irePwd.focus();
		return false;
	}
	
	return true;
}

function changeValidateCode()
{
	// 每次请求需要一个不同的参数，否则可能会返回同样的验证码(和浏览器的缓存机制有关系),获取当前的时间作为参数:    
	var timenow = new Date().getTime();
	document.getElementById("iyzimg").src="rand.action?d="+timenow;
}

function mbxuan(can)
{
	if(can != '') {
		var c = document.getElementById("ipwdquestion");
		for(var i=0;i<c.length;i++) {
			if(c[i].value == can) {
				c[i].selected = true;
			}
		}
	}
}

// 判断纯中文:
function CheckChineseChar(s_char)
{
	var re1 = new RegExp("^[\u0391-\uFFE5]*$");
	return re1.test(s_char);
}

function showinfo(idn)
{
	var c = document.getElementById(idn).innerHTML;
	if(c == "") {
		document.getElementById(idn).innerHTML = "<img src='Images/rgt.png' border='0' />";
	}
}
