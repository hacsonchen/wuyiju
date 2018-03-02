
function CheckTjForm_2()
{
	var igetbank = document.getElementById("igetbank").value;
	if(trim(igetbank) == "") {
		alert("温馨提示：您还没有设置收款账户，请先添加银行账户！");
		return false;
	}
	
	var cnum = 0;
	var c = document.getElementsByName("bankxz");
	for(var i=0;i<c.length;i++) {
		if(c[i].checked == true) {
			cnum = 1;
		}
	}
	if(cnum == 0) {
		alert("温馨提示：请选择一个收款银行账户！");
		return false;
	}
	
	var ippwdFlag = document.getElementById("ippwdFlag").value;
	if(trim(ippwdFlag) != "1") {
		alert("温馨提示：您还没有设置支付密码，请点击页面链接进行设置！");
		return false;
	}
	
	var itxmoney = document.getElementById("itxmoney");
	var v_itxmoney = trim(itxmoney.value);
	if(v_itxmoney == "") {
		alert("温馨提示：请填写提现金额！");
		itxmoney.focus();
		return false;
	}
	if(isAllDigits(v_itxmoney) == false) {
		alert("温馨提示：请正确填写提现金额！");
		itxmoney.focus();
		return false;
	}
	var i_money = parseInt(v_itxmoney);
	if(i_money <= 0) {
		alert("温馨提示：请正确填写提现金额！");
		itxmoney.focus();
		return false;
	}
	if(i_money < 50) {
		alert("温馨提示：申请提现金额至少为50元！");
		itxmoney.focus();
		return false;
	}
	
	//验证可用余额:
	var txmon = parseFloat(v_itxmoney);
	var kymoney = document.getElementById("ikymoney").value;
	var kymon = parseFloat(kymoney);
	if(txmon > kymon) {
		alert("温馨提示：提现金额过大，当前可提现金额不足！");
		itxmoney.focus();
		return false;
	}
	
	var ipaypwd = document.getElementById("ipaypwd");
	if(trim(ipaypwd.value) == "") {
		alert("温馨提示：请填写支付密码！");
		ipaypwd.focus();
		return false;
	}
	
	//进行提现提示,取消手续费:
 	/*var txfee = parseFloat(txmon*0.005);
 	if(txfee < 3) {
 		txfee = 3;
 	}else if(txfee > 30) {
 		txfee = 30;
 	}
 	var skmon = (parseFloat(txmon - txfee)).toFixed(2);*/
 	
 	Ask({Msg:"温馨提示：您输入的提现金额为："+v_itxmoney+"元，手续费为 0 元，将实际到账："+v_itxmoney+"元！",callback:"txformsbt()"});
}

function txformsbt() {
	
	document.getElementById("iformss").submit();
}