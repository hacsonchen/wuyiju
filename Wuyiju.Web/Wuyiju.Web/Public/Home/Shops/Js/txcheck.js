
function CheckTjForm_2()
{
	var igetbank = document.getElementById("igetbank").value;
	if(trim(igetbank) == "") {
		alert("��ܰ��ʾ������û�������տ��˻���������������˻���");
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
		alert("��ܰ��ʾ����ѡ��һ���տ������˻���");
		return false;
	}
	
	var ippwdFlag = document.getElementById("ippwdFlag").value;
	if(trim(ippwdFlag) != "1") {
		alert("��ܰ��ʾ������û������֧�����룬����ҳ�����ӽ������ã�");
		return false;
	}
	
	var itxmoney = document.getElementById("itxmoney");
	var v_itxmoney = trim(itxmoney.value);
	if(v_itxmoney == "") {
		alert("��ܰ��ʾ������д���ֽ�");
		itxmoney.focus();
		return false;
	}
	if(isAllDigits(v_itxmoney) == false) {
		alert("��ܰ��ʾ������ȷ��д���ֽ�");
		itxmoney.focus();
		return false;
	}
	var i_money = parseInt(v_itxmoney);
	if(i_money <= 0) {
		alert("��ܰ��ʾ������ȷ��д���ֽ�");
		itxmoney.focus();
		return false;
	}
	if(i_money < 50) {
		alert("��ܰ��ʾ���������ֽ������Ϊ50Ԫ��");
		itxmoney.focus();
		return false;
	}
	
	//��֤�������:
	var txmon = parseFloat(v_itxmoney);
	var kymoney = document.getElementById("ikymoney").value;
	var kymon = parseFloat(kymoney);
	if(txmon > kymon) {
		alert("��ܰ��ʾ�����ֽ����󣬵�ǰ�����ֽ��㣡");
		itxmoney.focus();
		return false;
	}
	
	var ipaypwd = document.getElementById("ipaypwd");
	if(trim(ipaypwd.value) == "") {
		alert("��ܰ��ʾ������д֧�����룡");
		ipaypwd.focus();
		return false;
	}
	
	//����������ʾ,ȡ��������:
 	/*var txfee = parseFloat(txmon*0.005);
 	if(txfee < 3) {
 		txfee = 3;
 	}else if(txfee > 30) {
 		txfee = 30;
 	}
 	var skmon = (parseFloat(txmon - txfee)).toFixed(2);*/
 	
 	Ask({Msg:"��ܰ��ʾ������������ֽ��Ϊ��"+v_itxmoney+"Ԫ��������Ϊ 0 Ԫ����ʵ�ʵ��ˣ�"+v_itxmoney+"Ԫ��",callback:"txformsbt()"});
}

function txformsbt() {
	
	document.getElementById("iformss").submit();
}