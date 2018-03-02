
function NameClk() {
	var spn = document.getElementById("mobile").value;
	if(spn == "填写您的手机号") {
		document.getElementById("mobile").value = "";
	}
}

//user.loginName
function checkuname(varVal, objID) {
	varVal = trim(varVal);
	if(varVal != "") {
		
		/*if(checkMob(varVal) == false) {
			document.getElementById(objID).innerHTML="·账户名只能填写您的手机号！";
			document.getElementById("ishow1").className = "Cha";
			return ;
		}*/

		 $.get('/Users/CheckName.aspx',{ 'name': varVal},function(data){
                if (data==1){
                    document.getElementById(objID).innerHTML="·该账户名可以使用！";
					//document.getElementById("ishow1").className = "Dui";
					$('#' + objID).parent().removeClass('Cha').addClass('Dui');
                }else{
                    document.getElementById(objID).innerHTML="·该账户名已被注册！";
					//document.getElementById("ishow1").className = "Cha";
					$('#' + objID).parent().removeClass('Dui').addClass('Cha');
                }
            });

	}else {
		document.getElementById(objID).innerHTML="·请填写通行证用户名！";
		//document.getElementById("ishow1").className = "Cha";
		$('#' + objID).parent().removeClass('Dui').addClass('Cha');
	}
}

//user.loginPwd
function checkupwd(varVal, objID) {
	document.getElementById("iaqlev").style.display = "none"; //安全强度;
	varVal = trim(varVal);
	if(varVal != "") {
		
		if(varVal.length < 6) {
			document.getElementById(objID).innerHTML="·密码至少为6位！";
			//document.getElementById("ishow2").className = "Cha";
			$('#' + objID).parent().removeClass('Dui').addClass('Cha');
			return ;
		}else if(varVal.length > 20) {
			document.getElementById(objID).innerHTML="·密码最长为20位！";
			$('#' + objID).parent().removeClass('Dui').addClass('Cha');
			return ;
		}else{
				document.getElementById("iaqlev").style.display = "block";
				var sg = AuthPasswd(varVal);
				if(sg == "2") {
					document.getElementById("ian1").className = "cur30";
					document.getElementById("ian2").className = "cur30";
					document.getElementById("ian3").className = "cur3";
					document.getElementById(objID).innerHTML="·密码填写正确！";
				}else if(sg == "1") {
					document.getElementById("ian1").className = "cur20";
					document.getElementById("ian2").className = "cur2";
					document.getElementById("ian3").className = "";
					document.getElementById(objID).innerHTML="·密码填写正确！";
				}else {
					document.getElementById("ian1").className = "cur1";
					document.getElementById("ian2").className = "";
					document.getElementById("ian3").className = "";
					document.getElementById(objID).innerHTML="·该密码比较简单，有被盗风险，<br/>&nbsp;&nbsp;建议您更改为复杂密码，如字母+数字的组合";
				}
				//document.getElementById("ishow2").className = "Dui";
				$('#' + objID).parent().removeClass('Cha').addClass('Dui');
		}
		
	}else {
		document.getElementById(objID).innerHTML="·请填写密码(至少为6位)！";
		//document.getElementById("ishow2").className = "Cha";
		$('#' + objID).parent().removeClass('Dui').addClass('Cha');
	}
}

//user.rePwd
function checkuRpwd(varVal, objID)
{
	varVal = trim(varVal);
	if(varVal != "") {
		var lgval = trim(document.getElementById("pwd").value);
		if(varVal == lgval) {
			document.getElementById(objID).innerHTML="";
			//document.getElementById("ishow3").className = "Dui";
			$('#' + objID).parent().removeClass('Cha').addClass('Dui');
		}else {
			document.getElementById(objID).innerHTML="·两次输入的密码不一致！";
			//document.getElementById("ishow3").className = "Cha";
			$('#' + objID).parent().removeClass('Dui').addClass('Cha');
		}
	}else {
		document.getElementById(objID).innerHTML="·请确认密码！";
		//document.getElementById("ishow3").className = "Cha";
		$('#' + objID).parent().removeClass('Dui').addClass('Cha');
	}
}

//user.pwdquestion
function checkPwdQton(varVal, objID)
{
	varVal = trim(varVal);
	if(varVal != "") {
		document.getElementById(objID).innerHTML="<img src=\"Images/reg/rok.gif\" />";
		document.getElementById(objID).className = "input_warn";
	}else {
		document.getElementById(objID).innerHTML="请选择密码保护问题！";
		document.getElementById(objID).className = "input_warnw";
	}
}

//othpwdqstion
function checkOthPwdQton(varVal, objID)
{
	varVal = trim(varVal);
	if(varVal != "") {
		
		if(varVal.length < 2 || varVal.length > 20) {
			document.getElementById(objID).innerHTML="自定义问题长度为2-20位，请正确填写！";
			document.getElementById(objID).className = "input_warnw";
		}else{		
			document.getElementById(objID).innerHTML="<img src=\"Images/reg/rok.gif\" />";
			document.getElementById(objID).className = "input_warn";
		}
	}else {
		document.getElementById(objID).innerHTML="请填写自定义问题！";
		document.getElementById(objID).className = "input_warnw";
	}
}

//user.pwdanswer
function checkPwdAsw(varVal, objID)
{
	varVal = trim(varVal);
	if(varVal != "") {
		var lgval = document.getElementById("ipwdquestion").value;
		if(trim(lgval) == "") {
			document.getElementById(objID).innerHTML="请选择密码保护问题！";
			document.getElementById(objID).className = "input_warnw";
		}else if(varVal.length < 2 || varVal.length > 20) {
			document.getElementById(objID).innerHTML="问题答案长度为2-20位，字母区分大小写！";
			document.getElementById(objID).className = "input_warnw";
		}else {
			document.getElementById(objID).innerHTML="<img src=\"Images/reg/rok.gif\" />";
			document.getElementById(objID).className = "input_warn";
		}
	}else {
		document.getElementById(objID).innerHTML="请填写密码保护问题答案！";
		document.getElementById(objID).className = "input_warnw";
	}
}


//user.umobile
function checkumobile(varVal, objID)
{
	varVal = trim(varVal);
	if(varVal != "") {
		//执行ajax处
		$.get('/Users/CheckMobile.aspx',{'mobile': varVal},function(data){
			if (data==1){
				document.getElementById(objID).innerHTML="·该手机号可以使用！";
				//document.getElementById("ishow4").className = "Dui";
				$('#' + objID).parent().removeClass('Cha').addClass('Dui');
			}else{
				document.getElementById(objID).innerHTML="·该手机号已被使用！";
				//document.getElementById("ishow4").className = "Cha";
				$('#' + objID).parent().removeClass('Dui').addClass('Cha');
			}
		});
	
	}else {
		document.getElementById(objID).innerHTML="·请填写手机号！";
		//document.getElementById("ishow4").className = "Cha";
		$('#' + objID).parent().removeClass('Dui').addClass('Cha');
	}
}

//user.uqq
function checkuqq(varVal, objID)
{
	varVal = trim(varVal);
	if(varVal != "") {
		theDwr.CheckuQQ(varVal,
		{
	      callback:function(data) {
			if(data == "pattern error") {
				document.getElementById(objID).innerHTML="请正确填写QQ号码！";
				//document.getElementById(objID).className = "input_warnw";
				$('#' + objID).parent().removeClass('Dui').addClass('Cha');
			}else if(data == "qq ok") {
				document.getElementById(objID).innerHTML="<img src=\"Images/reg/rok.gif\" />";
				//document.getElementById(objID).className = "input_warn";
				$('#' + objID).parent().removeClass('Cha').addClass('Dui');
			}
		  }
		});
	}else {
		document.getElementById(objID).innerHTML="请填写QQ号码！";
		//document.getElementById(objID).className = "input_warnw";
		$('#' + objID).parent().removeClass('Dui').addClass('Cha');
	}
}

//user.uemail
function checkuemail(varVal, objID)
{
	varVal = trim(varVal);
	if(varVal != "") {
		theDwr.CheckEmail(varVal,
		{
	      callback:function(data) {
			if(data == "pattern error") {
				document.getElementById(objID).innerHTML="请正确填写邮箱地址！";
				document.getElementById(objID).className = "input_warnw";
			}else if(data == "email ok") {
				document.getElementById(objID).innerHTML="<img src=\"Images/reg/rok.gif\" />";
				document.getElementById(objID).className = "input_warn";
			}else if(data == "email registed") {
				document.getElementById(objID).innerHTML="此邮箱已被注册！";
				document.getElementById(objID).className = "input_warnw";
			}
		  }
		});
	}else {
		document.getElementById(objID).innerHTML="请填写邮箱地址！";
		document.getElementById(objID).className = "input_warnw";
	}
}

function AuthPasswd(string) {
	
	var getres = "0";
	if(string.length >=6) {
		
		if(/[a-zA-Z]+/.test(string) && /[0-9]+/.test(string) && /[-`=;',.\/~!@#$%^&*()_+|{}:\"<>?]+/.test(string)) {

			getres = "2";

	    }else if(/[a-zA-Z]+/.test(string) && /[0-9]+/.test(string)) {

    		getres = "1";

        }else if(/\[a-zA-Z]+/.test(string) && /[-`=;',.\/~!@#$%^&*()_+|{}:\"<>?]+/.test(string)) {

        	getres = "1";

        }else if(/[0-9]+/.test(string) && /[-`=;',.\/~!@#$%^&*()_+|{}:\"<>?]+/.test(string)) {

        	getres = "1";
        	
        }
	}
	return getres;
}

var sdtime = 60;
function TimeShow() {
	
	sdtime = sdtime - 1;
	if(sdtime >= 0) {
		document.getElementById("idxnum").innerHTML="重新发送("+sdtime+")";
		setTimeout("TimeShow()",1000);
	}else {
		document.getElementById("idxnum").innerHTML="获取短信验证码";
		sdtime = 60;
	}	
}

//发送短信:
function SendDxNum() {

	var mobile = document.getElementById("mobile");
	var sjnum = trim(mobile.value);
	if(sjnum == "") {
		alert("请填写手机号！");
		mobile.focus();
		return ;
	}
	if(checkMob(sjnum) == false) {
		alert("请正确填写手机号！");
		mobile.focus();
		return ;
	}
	
	$.get('/Users/CheckMobile.aspx',{'mobile': sjnum},function(data){
			if (data==1){
			if(sdtime == 60) {
		
				 $.post('/Users/GetRegSms.aspx',{'sms_code':sjnum},function(data){
						if(data == 'true'){
							layer.alert("温馨提示：短信验证码已发送,请注意查收,感谢您的使用!");
							TimeShow();
						}else{
							layer.alert("温馨提示：系统忙,请稍后重试,感谢您的使用!");
							TimeShow();
						}
					});
				}
			}else
			{
				layer.alert("温馨提示：此号码已经被使用!");
			}
		});

	
	
}
