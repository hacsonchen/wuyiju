
//JS��ɾ���ַ������ҵĿո�:
function trim(str)
{
	return str.replace(/(^\s*)|(\s*$)/g, "");
}

//�ж�ĳ��ֵ�Ƿ�ѡ��(���������):
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
		alert("����д����۸�");
		return ;
	}
	if(priceCheck(spPrice) == false) {
		alert("����ȷ��д����۸�");
		return ;
	}
	
	var zshow = "";
	var sxzk = document.getElementById("isxzk").value;
	var hyjb = document.getElementById("ihyj").value;
	var zhek = 0.1;
	var ishow = 1;
	if(sxzk != null && sxzk == "no") {
		//zshow = hyjb+"���������Ż�"; //���Ż�ʱ����ʾ,2014-10-20;
		ishow = 0;
	}else {
		zshow = hyjb+"����"+sxzk+"���������Ż�";
		zhek = sxzk / 100; //eg:0.085;
	}
	
	var youhui = parseFloat(spPrice * zhek);
	var daosho = (spPrice - youhui).toFixed(2);
	
	var msg = "<span style='font-size:14px;font-weight:bold;'>�װ������ݻ�Ա���ύ֮ǰ��ȷ�����ĵ��̿����������۲���֤�Ǽ���Ϣ��ʵ��</span><br>";
	msg = msg + "*�����ֻ�����˽�����ۼۿ���ѯ���ݹٷ��ͷ�������Ҹ���֮����Ϊ����ԭ������²����������ף������Ȩ����թ����������׷��������Σ�<br>";
	msg = msg + "<span style='font-size:14px;font-weight:bold;'>���׳ɹ�����������ȡ10%��������<br>";
	if(ishow == 1) {
		msg = msg + zshow+"<br>";
	}
	msg = msg + "��ĵ��ּ۲���������Ϊ(<span style='color:#FF6600'>"+daosho+"</span>)Ԫ</span>";
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

//������ֵ����Ĭ��:
function nozeromo(val,idstr) {
	if(val != null && val != "" && val != "0") {
		document.getElementById(idstr+""+val).checked = true;
	}
}

//���ťĬ��(���ܺ���ֵ):
function anyRadiomo(val,idstr) {
	if(val != null && val != "") {
		document.getElementById(idstr+""+val).checked = true;
	}
}

//���ťĬ��(����ʾ�ı���):
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

//�����ѡ(����ʾ�ı���):
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