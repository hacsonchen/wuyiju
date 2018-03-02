
//JS中删除字符串左右的空格:
function trim(str)
{
	return str.replace(/(^\s*)|(\s*$)/g, "");
}

//判断某个值是否被选中(针对下拉表):
function xuan(can,ses)
{
	var c = ses;
	for(var i=0;i<c.length;i++) {
		if(c[i].value == can) {
			c[i].selected = true;
		}
	}
}

//sp_zrang:
function zrjs1(v1) {
	v1 = trim(v1);
	if(v1 != "") {
		if(v1 == "1") {
			document.getElementById("ilogtype1").checked=true;
		}else if(v1 == "2") {
			document.getElementById("ilogtype2").checked=true;
		}
	}
}

function zrjs2(v2) {
	v2 = trim(v2);
	if(v2 != "") {
		if(v2 == "1") {
			document.getElementById("isptype1").checked=true;
		}else if(v2 == "2") {
			document.getElementById("isptype2").checked=true;
		}else if(v2 == "3") {
			document.getElementById("isptype3").checked=true;
		}
	}
}

function SendMind() {
	
	var spPrice = trim(document.getElementById("ispPrice").value);
	if(spPrice == "" || spPrice == null) {
		alert("请填写网店价格！");
		return ;
	}
	if(priceCheck(spPrice) == false) {
		alert("请正确填写网店价格！");
		return ;
	}
	
	var zshow = "";
	var sxzk = document.getElementById("isxzk").value;
	var hyjb = document.getElementById("ihyj").value;
	var zhek = 0.1;
	var ishow = 1;
	if(sxzk != null && sxzk == "no") {
		//zshow = hyjb+"无手续费优惠"; //无优惠时不提示,2014-10-20;
		ishow = 0;
	}else {
		zshow = hyjb+"享受"+sxzk+"折手续费优惠";
		zhek = sxzk / 100; //eg:0.085;
	}
	
	var youhui = parseFloat(spPrice * zhek);
	var daosho = (spPrice - youhui).toFixed(2);
	
	var msg = "<span style='font-size:14px;font-weight:bold;'>亲爱的舞泡会员：提交之前请确认您的店铺可以正常销售并保证登记信息属实！</span><br>";
	msg = msg + "*如果您只是想了解店铺售价可咨询舞泡官方客服！在买家付款之后因为个人原因而导致不能正常交易，买家有权以欺诈消费者名义追究相关责任！<br>";
	msg = msg + "<span style='font-size:14px;font-weight:bold;'>交易成功舞泡网需收取10%的手续费<br>";
	if(ishow == 1) {
		msg = msg + zshow+"<br>";
	}
	msg = msg + "你的到手价不含消保费为(<span style='color:#FF6600'>"+daosho+"</span>)元</span>";
	Ask({Msg:msg,callback:"GetIt()"});
}

function GetIt() {
	document.getElementById("ifbform").submit();
}

function showGetStr(str) {
}

function koufenMo(x1) {
	if(x1 == "1") {
		document.getElementById("ikoufen1").checked=true;
	}else if(x1 == "2") {
		document.getElementById("ikoufen2").checked=true;
	}
}

function xuanChecked(can)
{
	can = trim(can);
	var c = document.getElementsByName("bean.ktgzj");
	for(var i=0;i<c.length;i++) {
		if(c[i].value == can) {
			c[i].checked = true;
		}
	}
}

function priceCheck(argvalue)
{
	argvalue = argvalue.toString();
	var validChars = "0123456789";
	for (var n = 0; n < argvalue.length; n++)
	{
		if (validChars.indexOf(argvalue.substring(n, n+1)) == -1) { return false; }
	}
	return true;
}

/********************************************************/

function xbmoren(x1) {
	if(x1 == "0") {
		document.getElementById("ixbBack0").checked=true;
	}else if(x1 == "2") {
		document.getElementById("ixbBack2").checked=true;
	}else {
		document.getElementById("ixbBack1").checked=true;
	}
}

function oneselfMo(x1) {
	if(x1 == "1") {
		document.getElementById("ioneself1").checked=true;
	}else if(x1 == "0") {
		document.getElementById("ioneself0").checked=true;
	}
}

//不含零值单项默认:
function nozeromo(val,idstr) {
	if(val != null && val != "" && val != "0") {
		document.getElementById(idstr+""+val).checked = true;
	}
}

//单项按钮默认(可能含零值):
function anyRadiomo(val,idstr) {
	if(val != null && val != "") {
		document.getElementById(idstr+""+val).checked = true;
	}
}

//单项按钮默认(并显示文本框):
function textRadiomo(val,idstr) {
	if(val != null && val != "") {
		document.getElementById(idstr+""+val).checked = true;
		if(val == "1") {
			document.getElementById(idstr+"div").style.display = "";
		}else {
			document.getElementById(idstr+"div").style.display = "none";
		}
	}
}

//点击单选(并显示文本框):
function clkRadiomo(val,idstr) {
	if(val != null && val != "") {
		if(val == "1") {
			document.getElementById(idstr+"div").style.display = "";
		}else {
			document.getElementById(idstr+"div").style.display = "none";
		}
	}
}

function ktgzjchk(argt) {
	if(argt != "") {
		var strs= new Array();
		strs=argt.split(",");

		for(var i=0;i<strs.length ;i++ ) {
			xuanChecked(strs[i]);
	    }
	}
}