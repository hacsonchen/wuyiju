
function UserReg() {

	Iframe({
    	Url:"ecregist.html",
    	Width:630,
		Height:420,
		scrolling:'no',
		isIframeAutoHeight:false,
		isShowIframeTitle:false,
    	call:function(data) {
        }
   });
}

function CheckKsRegForm() {
	
	var iumobile = document.getElementById("iumobile");
	var umb = trim(iumobile.value);
	if(umb == "") {
		alert("请填写手机号！");
		iumobile.focus();
		return ;
	}
	if(checkMob(umb) == false) {
		alert("请正确填写手机号！");
		iumobile.focus();
		return ;
	}
	
	var idxmsg = document.getElementById("idxmsg");
	var dxmsg = trim(idxmsg.value);
	if(dxmsg == "") {
		alert("请填写短信验证码！");
		idxmsg.focus();
		return ;
	}
	if(dxmsg.length != 6) {
		alert("请正确填写短信验证码！");
		idxmsg.focus();
		return ;
	}
	
	var iloginPwd = document.getElementById("iloginPwd");
	var lgpwd = trim(iloginPwd.value);
	if(lgpwd == "") {
		alert("登录密码不能为空！");
		iloginPwd.focus();
		return ;
	}
	if(lgpwd.length < 6 || lgpwd.length > 20) {
		alert("密码长度为6-20位，由字母、数字或字符组成，字母区分大小写！");
		iloginPwd.focus();
		return ;
	}
	document.getElementById("iezform1").submit();
}

function RegOk() {
	parent.Close();
	parent.location.href = "http://u.5pao.com/ucenter/login?service=http://u.5pao.com/wucenter/ecbaoming.html";
}

//50525:
/*
function WantXx() {

	Iframe({
    	Url:"ecwant.html",
    	Width:292,
		Height:324,
		scrolling:'no',
		isIframeAutoHeight:false,
		isShowIframeTitle:false,
    	call:function(data) {
        }
   });
}

*/
function CheckXxForm() {
	//var iuid = document.getElementById("user_id");
	//var uid = trim(iuid.value);
	var idxnum = document.getElementById("idxnum");
	var dxnum = trim(idxnum.value);
	if(dxnum == "") {
		alert("提交内容不能为空！");
		idxnum.focus();
		return false;
	}
	if(dxnum.length > 200) {
		alert("提交内容限200字！");
		idxnum.focus();
		return false;
	}
	else{
		document.getElementById("iexform1").submit();
		alert("内容提交成功！");
	}
}

function Noright() {
	alert("温馨提示：您当前并无查看资格(仅限成功购买过网店的会员查看)！");
}
function Noyilog() {
	alert("温馨提示：请登录后查看(仅限成功购买过网店的会员查看)！");
}
function ectosee(i) {
	$('#tab_course li').removeClass('cur');
	$('#ecli' + i).addClass('cur');
    $('[id^=course_]').hide();
    $('#course_' + i).show();
}