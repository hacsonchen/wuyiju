
function SendMind()
{
	var spTitle = document.getElementById("spTitle");
	if(trim(spTitle.value) == "") {
		alert("温馨提示：请填写信息标题！");
		spTitle.focus();
		return false;
	}
	var spBrief = document.getElementById("spBrief");
	if(trim(spBrief.value) == "") {
		alert("温馨提示：请填写网店描述！");
		spBrief.focus();
		return false;
	}
	var spUrl = document.getElementById("spUrl");
	if(trim(spUrl.value) == "") {
		alert("温馨提示：请填写网店网址！");
		spUrl.focus();
		return false;
	}
	var spAdmin = document.getElementById("spAdmin");
	if(trim(spAdmin.value) == "") {
		alert("温馨提示：请填写网店旺旺名！");
		spAdmin.focus();
		return false;
	}
	// var shopHours = document.getElementById("shopHours");
	// if(trim(shopHours.value) == "") {
	// 	alert("温馨提示：请填写开店时间！");
	// 	shopHours.focus();
	// 	return false;
	// }
	var shopsPrice = document.getElementById("shopsPrice");
	if(trim(shopsPrice.value) == "") {
		alert("温馨提示：请填写网店价格！");
		shopsPrice.focus();
		return false;
	}
	
/*	var cnum = 0;
	var c = document.getElementsByName("xbBack");
	for(var i=0;i<c.length;i++) {
		if(c[i].checked == true) {
			cnum = 1;
		}
	}
	if(cnum == 0) {
		alert("温馨提示：请选择一个消保保证金！");
		return false;
	}*/
	
	// var utruename = document.getElementById("utruename");
	// if(trim(utruename.value) == "") {
	// 	alert("温馨提示：请填写您的真实姓名！");
	// 	utruename.focus();
	// 	return false;
	// }
	
	// var umobile = document.getElementById("umobile");
	// if(trim(umobile.value) == "") {
	// 	alert("温馨提示：请填写您的手机号码！");
	// 	umobile.focus();
	// 	return false;
	// }
	
	// var uqq = document.getElementById("uqq");
	// if(trim(uqq.value) == "") {
	// 	alert("温馨提示：请填写联系QQ！");
	// 	uqq.focus();
	// 	return false;
	// }

	$('#ifbform').submit();
}
