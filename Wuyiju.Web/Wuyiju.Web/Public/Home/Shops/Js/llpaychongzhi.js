
//JS 中删除字符串左右的空格:
function trim(str)
{
	return str.replace(/(^\s*)|(\s*$)/g, "");
}

function checkPayForm()
{
	if(document.getElementById("iczfs5").checked == false && document.getElementById("iczfs3").checked == false) { 
		alert("请选择支付方式！");
		document.getElementById("iczfs5").focus();
		return false;
	}

	var sbmhtml = "";
	// if(document.getElementById("iczfs1").checked == true) { //网银充值:
	
	// 	var iczamount = document.getElementById("iczmoney");
	// 	var czje = trim(iczamount.value);
	// 	if(czje == "") {
	// 		alert("请输入充值金额！");
	// 		iczamount.focus();
	// 		return false;
	// 	}		
	// 	if(isAllDigits(czje) == false) {
	// 		alert("请正确填写充值金额！");
	// 		iczamount.focus();
	// 		return false;
	// 	}		
	// 	if(czje.indexOf('0') == 0) {
	// 		alert("请正确填写充值金额！");
	// 		iczamount.focus();
	// 		return false;
	// 	}		
	// 	var cje = parseInt(czje);
	// 	if(cje <= 0) {
	// 		alert("请正确填写充值金额！");
	// 		iczamount.focus();
	// 		return false;
	// 	}
	 	
	//  	//进行充值提示:
	//  	var chmon = parseFloat(czje);
	//  	var sxf = chmon*0.005;
	//  	if(sxf > 50) {
	//  		sxf = 50;
	//  	}
	//  	var skmon = (parseFloat(chmon - sxf)).toFixed(2);
	//  	if(confirm("温馨提示：您输入的充值金额为："+czje+"元，扣除0.5%的银行手续费后，实际到账将为："+skmon+"元，请确认！")) {
	 	
	//  		document.getElementById("iform1").action = sbmhtml;
	// 		document.getElementById("iform1").submit();
	// 		document.getElementById("ibut1").disabled = true;
	// 		document.getElementById("ibut1").className="blueSub-btnNew subBtnGray-zf";
	//  	}
	 	
	//  	if(confirm("温馨提示：您输入的充值金额为："+czje+"元，实际到账为："+czje+"元，请确认！")) {
		 	
	//  		document.getElementById("iform1").action = sbmhtml;
	// 		document.getElementById("iform1").submit();
	// 		document.getElementById("ibut1").disabled = true;
	// 		document.getElementById("ibut1").className="blueSub-btnNew subBtnGray-zf";
	//  	}
	 	
	// }else 
	if(document.getElementById("iczfs3").checked == true) { //线下:
	
		var ishoukCard = document.getElementById("ishoukCard");
		if(trim(ishoukCard.value) == "") {
			alert("请选择收款账户！");
			ishoukCard.focus();
			return false;
		}
		
		var ihuiBank = document.getElementById("ihuiBank");
		if(trim(ihuiBank.value) == "") {
			alert("请填写汇款银行！");
			ihuiBank.focus();
			return false;
		}
		
		var ihuiMoney = document.getElementById("ihuiMoney");
		if(trim(ihuiMoney.value) == "") {
			alert("请填写汇款金额！");
			ihuiMoney.focus();
			return false;
		}
		
		// var ihuiTime = document.getElementById("ihuiTime");
		// if(trim(ihuiTime.value) == "") {
		// 	alert("请填写汇款日期！");
		// 	ihuiTime.focus();
		// 	return false;
		// }
		
		var ihuiUser = document.getElementById("ihuiUser");
		if(trim(ihuiUser.value) == "") {
			alert("请填写汇款人姓名！");
			ihuiUser.focus();
			return false;
		}
		
		// var ihuiRemark = document.getElementById("ihuiRemark");
		// if(trim(ihuiRemark.value).length > 500) {
		// 	alert("汇款备注限500字！");
		// 	ihuiRemark.focus();
		// 	return false;
		// }

		document.getElementById("iform1").action = sbmhtml;
		document.getElementById("iform1").submit();
		document.getElementById("ibut1").disabled = true;
		document.getElementById("ibut1").className="blueSub-btnNew subBtnGray-zf";
		
	}
	// else if(document.getElementById("iczfs4").checked == true) { //网银充值(支持信用卡):
	
	// 	var iczamount = document.getElementById("iczamount");
	// 	var czje = trim(iczamount.value);
	// 	if(czje == "") {
	// 		alert("请输入充值金额！");
	// 		iczamount.focus();
	// 		return false;
	// 	}		
	// 	if(isAllDigits(czje) == false) {
	// 		alert("请正确填写充值金额！");
	// 		iczamount.focus();
	// 		return false;
	// 	}		
	// 	if(czje.indexOf('0') == 0) {
	// 		alert("请正确填写充值金额！");
	// 		iczamount.focus();
	// 		return false;
	// 	}		
	// 	var cje = parseInt(czje);
	// 	if(cje <= 0) {
	// 		alert("请正确填写充值金额！");
	// 		iczamount.focus();
	// 		return false;
	// 	}
		
	// 	var xnum = 0;
	//  	var c = document.getElementsByName("bankname");
	//  	for(var i=0;i<c.length;i++) {
	//  		if(c[i].checked == true) {
	//  			xnum = 1;
	//  		}
	//  	}
	//  	if(xnum == 0) {
	//  		alert("请选择充值银行！");
	//  		return false;
	//  	}
	 	
	//  	//进行充值提示:
	//  	var chmon = parseFloat(czje);
	//  	var sxf = chmon*0.0025;
	//  	var skmon = (parseFloat(chmon - sxf)).toFixed(2);
	//  	if(confirm("温馨提示：您输入的充值金额为："+czje+"元，扣除0.25%的银行手续费后，实际到账将为："+skmon+"元，请确认！")) {

	//  		document.getElementById("iform1").action = sbmhtml;
	// 		document.getElementById("iform1").submit();
	// 		document.getElementById("ibut1").disabled = true;
	// 		document.getElementById("ibut1").className="blueSub-btnNew subBtnGray-zf";
	//  	}
	// }
	else if(document.getElementById("iczfs5").checked == true){
		var iczamount;
		var itradeNum;

		if(document.getElementById("icztype1").checked == true)
		{
			iczamount = document.getElementById("ipayMoney");
			itradeNum = document.getElementById("itradeNum1");
		}

		if(document.getElementById("icztype2").checked == true)
		{
			iczamount = document.getElementById("isaoMoney");
			itradeNum = document.getElementById("itradeNum2");
		}


		var czje = trim(iczamount.value);
		var account = trim(itradeNum.value);
		if(czje == "") {
			alert("请输入充值金额！");
			iczamount.focus();
			return false;
		}		
		if(isAllDigits(czje) == false) {
			alert("请正确填写充值金额！");
			iczamount.focus();
			return false;
		}		
		if(czje.indexOf('0') == 0) {
			alert("请正确填写充值金额！");
			iczamount.focus();
			return false;
		}		
		var cje = parseInt(czje);
		if(cje <= 0) {
			alert("请正确填写充值金额！");
			iczamount.focus();
			return false;
		}

		if(account == '')
		{
			alert("请输入转帐帐号！");
			itradeNum.focus();
			return false;
		}



		document.getElementById("iform1").action = sbmhtml;
		document.getElementById("iform1").submit();
		document.getElementById("ibut1").disabled = true;
		document.getElementById("ibut1").className="blueSub-btnNew subBtnGray-zf";

	}
}

function cztypeShow(sg) {
    
    if(sg != null && sg == "2") {
        document.getElementById("olPay").style.display = "none";
        document.getElementById("scanPay").style.display = "";
    }else {
        document.getElementById("olPay").style.display = "";
        document.getElementById("scanPay").style.display = "none";
    }
}

//判断是否都是纯数字:
function isAllDigits(argvalue)
{
	argvalue = argvalue.toString();
	var validChars = "0123456789";
	for (var n = 0; n < argvalue.length; n++) {
		if (validChars.indexOf(argvalue.substring(n, n+1)) == -1) return false;
	}
	return true;
}

//单选:
function radiomo(mval)
{
	document.getElementById("isztype"+mval).checked = true;
}

function resumeBtn() {
	//document.getElementById("ibut1").disabled = false;
	//document.getElementById("ibut1").className="blueSub-btn";
	//2013-04-10;
}
