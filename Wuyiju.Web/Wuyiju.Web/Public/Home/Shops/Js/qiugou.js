
function SendMind()
{
	var title = document.getElementById("title").value;
	if(trim(title) == "") {
		alert("温馨提示：请填写信息标题！");
		title.focus();
		return false;
	}
	
	var brief = document.getElementById("brief").value;
	if(trim(brief) == "") {
		alert("温馨提示：请填写网店描述！");
		brief.focus();
		return false;
	}
	
	var utruename = document.getElementById("user_name").value;
	if(trim(utruename) == "") {
		alert("温馨提示：请填写您的真实姓名！");
		utruename.focus();
		return false;
	}
	
	var umobile = document.getElementById("mobile").value;
	if(trim(umobile) == "") {
		alert("温馨提示：请填写您的手机号码！");
		umobile.focus();
		return false;
	}
	
	return true;
}
