
function showMenuDownList() {
	var timer = null;
	var isNum;
	$('.WP-nav .N-WP ul li').hover(function() {
		clearInterval(timer);
		$('.navDownList').hide();
		$('.WP-nav .N-WP ul li a').removeClass('hover');
		$(this).children('a').addClass('hover');
		$(this).children('.navDownList').show();
	}, function(){
		timer = setInterval(function(){
			$('.WP-nav .N-WP ul li a').removeClass('hover');
			$('.navDownList').hide();
		},100);
	});
	$('.navDownList').hover(function(){
		clearInterval(timer);
		$(this).children('.navDownList').show();
	}, function() {
		$('.WP-nav .N-WP ul li a').removeClass('hover');
		$('.navDownList').hide();
	});
}

/////////////////////////搜索////////////////////////////////
function hidesoxla() {
	if(document.getElementById("isoutflag").value == "") {
		soxialahide();
	}
}

function ShowAskWin(aurl) {
    window.open(aurl, '', "width=644,height=544,toolbar=no,scrollbars=no,menubar=no,status=no");
}

function hrefsout() {
	document.getElementById("isoutflag").value = "";
	setTimeout("hidesoxla()",200);
}
function soxialashow() {
	document.getElementById("isoutflag").value = "1";
	document.getElementById("isodl").style.display="";
}
function soxialahide() {
	document.getElementById("isodl").style.display="none";
	document.getElementById("isoutflag").value = "";
}

function MouseClk() {
	var spn = document.getElementById("ishopName").value;
	if(spn == "填写旺旺名或网店编号" || spn == "填写关键词或网店编号" || spn == "填写关键词") {
		document.getElementById("ishopName").value = "";
	}
}

function MouseOut() {
	var spn = document.getElementById("ishopName").value;
	if(spn == "") {
		var sg = document.getElementById("isosoflag").value;
		if(sg == "1") {
			document.getElementById("ishopName").value = "填写旺旺名或网店编号";
		}else if(sg == "2") {
			document.getElementById("ishopName").value = "填写关键词或网店编号";
		}else if(sg == "3") {
			document.getElementById("ishopName").value = "填写关键词";
		}
	}
}

function sosoShow(sg)
{
	document.getElementById("isosoflag").value = sg;
	//if(sg == "1") {
	//	document.getElementById("isoshow1").innerHTML="淘宝";
	//	document.getElementById("ishopName").value = "填写旺旺名或网店编号";
	//	document.getElementById("isobtn").value = "淘宝网店";
	//}else if(sg == "2") {
	//	document.getElementById("isoshow1").innerHTML="天猫";
	//	document.getElementById("ishopName").value = "填写关键词或网店编号";
	//	document.getElementById("isobtn").value = "天猫商城";
	//}else if(sg == "3") {
	//	document.getElementById("isoshow1").innerHTML="其它";
	//	document.getElementById("ishopName").value = "填写关键词";
	//	document.getElementById("isobtn").value = "其它网店";
	//}
	document.getElementById("isodl").style.display="none";
}

function srhformSbt() {
	var spn = document.getElementById("ishopName").value;
	if(spn == "填写旺旺名或网店编号" || spn == "填写关键词或网店编号" || spn == "填写关键词" || spn == "") {
		spn = "";
		document.getElementById("ishopName").value = "";
		return false;
	}
	
	//var sg = document.getElementById("isosoflag").value;
	//if(sg == "1") {
	//	//document.getElementById("iformfind").method = "post";
	//	//document.getElementById("iformfind").action = "";
	//	//document.getElementById("iformfind").submit();
	//	window.open("/Taobao.aspx?q="+spn,'','');
	//}else if(sg == "2") {
	//	window.open("/Tmall.aspx?q="+spn,'','');
	//}else if(sg == "3") {
	//	window.open("/Others.aspx?q="+spn,'','');
	//}

	window.open("/Tmall.aspx?q=" + spn, '', '');
}

//提问
function selName() {
   var d = document.getElementById("icname").value;
   var id = d.replace(/(^\s*)|(\s*$)/g, ""); //去除空格;
   document.getElementById("default1").length = 0;
   if(id != "") {
		OperCategory.getCategoryByid(id,function(datalist) {
			if(datalist != null && datalist.length > 0) {
				for(var i=0;i<datalist.length;i++) {
					document.getElementById("default1").options[document.getElementById("default1").length] = new Option(datalist[i].name, datalist[i].id);
				}
			}
	    /*if(typeof window['DWRUtil'] == 'undefined') {
				 window.DWRUtil = dwr.util; 
	    }*/
	 
//	    DWRUtil.removeAllOptions("default1");
//	    //DWRUtil.removeAllOptions("default2");
//	    //DWRUtil.removeAllOptions("default3");
//	    DWRUtil.addOptions('default1',data,"id","name");
	
		});
   }
}

function fytj(pg) {
	document.getElementById("ipageid").value = pg;
	
	document.getElementById("iformss").submit();
}


//跳转到:
function fytz()
{
	var fy = trim(document.getElementById("itzfy").value);
	document.getElementById("ipageid").value = fy;
	document.getElementById("iformss").submit();
}


// 判断某个值是否被选中(针对下拉表)xuan(参数，document.getElementById("ipay_statu")):
function xuan(can,ses)
{
	
	//var ses = document.getElementById("ipay_statu");//定位id
	var c = ses;
	for(var i=0;i<c.length;i++) {
		if(c[i].value == can) {
			c[i].selected = true;
		}
	}
}

// 针对复选框，单选框等选中:
function xuanChecked(can,xkname)
{
	var c = xkname;
	for(var i=0;i<c.length;i++) {
		if(c[i].value == can) {
			c[i].checked = true;
		}
	}
}

// JS 中删除字符串左右的空格:
function trim(str)
{
	return str.replace(/(^\s*)|(\s*$)/g, "");
}

// 判断是否都是纯数字:
function isAllDigits(argvalue)
{
	argvalue = argvalue.toString();
	var validChars = "0123456789";

	for (var n = 0; n < argvalue.length; n++)
	{
		if (validChars.indexOf(argvalue.substring(n, n+1)) == -1) return false;
	}
	return true;
}

//充值记录处理结果
/*
function radiomo(mval)
{
	document.getElementById("isztype"+mval).checked == true;
}
*/

// 判断是否是EMAIL 的格式:
function IsMail(mail) 
{ 
	var patrn = /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/; 
	if (!patrn.test(mail))
	return false;
	else 
	return true;
}

//会员中心投诉与建议
function CheckYjForm()
{
	var ijycontent = document.getElementById("ijycontent");
	var jyct = trim(ijycontent.value);
	if(jyct == "" || jyct == "是否满意？有话您直说！") {
		alert("请填写建议内容！");
		ijycontent.focus();
		return false;
	}
	if(jyct.length > 200) {
		alert("建议内容限200字！");
		ijycontent.focus();
		return false;
	}
	
	return true;
}



//判断报名提交

function baomingcheck(){
	
	var array = document.getElementsByName("baoming");
	for(var i=0;i<array.length;i++)
	if(array[i].checked == false)
		{
			alert("请选择课程！");
			
			return false;
		}
	else if(array[i].checked == true)
		{
			if(confirm("确认选课完成，进行提交吗？") == true){
			return true;
			}
			else {
			return false;
			}
		}
	
	
	}


// 判断是否是正确的手机格式:
function checkMob(mob)
{
	var reg0=/^1\d{10}$/;
	var res=false;
	if (reg0.test(mob)) {
		res=true;
	}	
	return res;
}

//判断是否匿名
function lxdivshow() {
	
	if(document.getElementById("inim").checked == false) {
		
		document.getElementById("ilxdiv").style.display = "";
	}else {
		document.getElementById("ilxdiv").style.display = "none";
	}	
}

//判断投诉表单提交
function tousuCheck() {
	
	if(document.getElementById("inim").checked == false) {
		
		var tszname = trim(document.getElementById("tszname").value);
		if(tszname == "") {
			alert("温馨提示：(若不是匿名提交)请填写您的姓名！");
			document.getElementById("tszname").focus();
			return false;
		}
		
		var tszmobile = trim(document.getElementById("tszmobile").value);
		if(tszmobile == "") {
			alert("温馨提示：(若不是匿名提交)请填写您的手机号！");
			document.getElementById("tszmobile").focus();
			return false;
		}
		if(tszmobile.length != 11) {
			alert("温馨提示：请正确填写您的手机号！");
			document.getElementById("tszmobile").focus();
			return false;
		}
		if(isAllDigits(tszmobile) == false) {
			alert("温馨提示：请正确填写您的手机号！");
			document.getElementById("tszmobile").focus();
			return false;
		}
		
		var custmqq = trim(document.getElementById("tszqq").value);
		if(custmqq != "") {
			if(custmqq.length < 4 || custmqq.length > 13) {
				alert("温馨提示：请正确填写您的QQ号码！");
				document.getElementById("tszqq").focus();
				return false;
			}
			if(isAllDigits(custmqq) == false) {
				alert("温馨提示：请正确填写您的QQ号码！");
				document.getElementById("tszqq").focus();
				return false;
			}
		}	
	}
	
	var ywname = trim(document.getElementById("ywname").value);
	if(ywname == "") {
		alert("温馨提示：请填写要举报的业务员姓名！");
		document.getElementById("ywname").focus();
		return false;
	}
	if(ywname.length > 10) {
		alert("温馨提示：请正确填写业务员姓名！");
		document.getElementById("ywname").focus();
		return false;
	}
	
	var ibody = trim(document.getElementById("ibody").value);
	if(ibody == "") {
		alert("温馨提示：请填写举报内容(事情真相)！");
		document.getElementById("ibody").focus();
		return false;
	}
	if(ibody.length > 200) {
		alert("温馨提示：举报内容过长(限200字)！");
		document.getElementById("ibody").focus();
		return false;
	}

	var tspic1 = trim(document.getElementById("tspic1").value);
	if(tspic1 == "") {
		alert("温馨提示：请上传一张图片作为证据！");
		document.getElementById("tspic1").focus();
		return false;
	
	}
	
	if(confirm("确认填写完成，进行提交吗？") == true) {
		return true;
	}else {
		return false;
	}	
	
}

//问题分类
function showcategory(mkid)
{
	if(mkid != "") {
		OperCategory.GetCategoryInfoByid(mkid,
		{
	      callback:function(datalist) {
	      
	         if(datalist != null) {
				var lishow1 = "";
				var tnum = 0;
				for(var i=0;i<datalist.length;i++) {
					tnum = tnum + datalist[i].inum;
					lishow1 = lishow1 + "<li>·<a onclick='fentj("+datalist[i].id+");' style='cursor:hand;' class='ahover'>"+datalist[i].name+"</a>&nbsp;("+datalist[i].inum+")</li>";
				}
				var lishow = "<li>·<a onclick='fentj();' style='cursor:hand;' class='ahover'>全部问题</a>&nbsp;("+tnum+")</li>";
				lishow = lishow + lishow1;
				document.getElementById("iulshow").innerHTML=lishow;
			 }
		  }
		});
		if(mkid != 0){
			document.getElementById("is0").className = '';
			for(var j=8;j<=12;j++) {
				document.getElementById("is"+j).className = '';
			}
		}
		document.getElementById("is"+mkid).className = 'select';
	}
}


function showzidy(varVal)
{	
	if(varVal == "自定义问题") {
		document.getElementById("ioqstshow").style.display="";
	}else {
		document.getElementById("ioqstshow").style.display="none";
	}
}

function hidexla() {
	if(document.getElementById("ioutflag").value == "") {
		xialahide();
	}
}
function hrefout()
{
	document.getElementById("ioutflag").value = "";
	setTimeout("hidexla()",200);
}
function xialashow()
{
	document.getElementById("ioutflag").value = "1";
	document.getElementById("imy5pao").style.display="";
	document.getElementById("iwupao").className="cur";
}
function xialahide()
{
	document.getElementById("imy5pao").style.display="none";
	document.getElementById("iwupao").className="";
	document.getElementById("ioutflag").value = "";
}

//菜单栏发布求购
function postWant() {
    var p = $('#postDemand');
    var e = $('#postEnter');
    var asrc = e.attr('src').split('.');

    if(p.css('display') == 'none') {
        p.show(500);
        asrc[asrc.length - 1] = 'png';
    } else{
        p.hide(500);
        asrc[asrc.length - 1] = 'gif';
    }
    var ssrc = asrc.join('.');
    e.attr('src',ssrc);
}




function checkXqMob(mob) {
	var reg0=/^1\d{10}$/;
	var res=false;
	if (reg0.test(mob)) {
		res=true;
	}
	return res;
}
function checksz(argvalue) {
	argvalue = argvalue.toString();
	var validChars = "0123456789";
	for (var n = 0; n < argvalue.length; n++) {
		if (validChars.indexOf(argvalue.substring(n, n+1)) == -1) return false;
	}
	return true;
}
function XqMouseClk(vtype,otype) {
	if(vtype == "1") { //姓名:
		var xqname = trim($('#xqname').val());
		if(otype == "2") { //鼠标离开:
			if(xqname == "") {
				$('#xqname').val("例如：何先生");
			}
		}else { //点击:
			if(xqname == "例如：何先生") {
				$('#xqname').val("");
			}
		}
	}else if(vtype == "2") {
		var xqmobile = trim($('#xqmobile').val());
		if(otype == "2") { //鼠标离开:
			if(xqmobile == "") {
				$('#xqmobile').val("例如：15688878886");
			}
		}else { //点击:
			if(xqmobile == "例如：15688878886") {
				$('#xqmobile').val("");
			}
		}
	}else if(vtype == "3") {
		var xqqq = trim($('#xqqq').val());
		if(otype == "2") { //鼠标离开:
			if(xqqq == "") {
				$('#xqqq').val("例如：826935668");
			}
		}else { //点击:
			if(xqqq == "例如：826935668") {
				$('#xqqq').val("");
			}
		}
	}else if(vtype == "4") {
		var yourWant = trim($('#yourWant').val());
		if(otype == "2") { //鼠标离开:
			if(yourWant == "") {
				$('#yourWant').val("例如：求购一个江浙沪地区女装类天猫店");
			}
		}else { //点击:
			if(yourWant == "例如：求购一个江浙沪地区女装类天猫店") {
				$('#yourWant').val("");
			}
		}
	}
}

//会员中心发布需求:
function SendXuqiu() {
	
	//获取填写信息:
	var xqname = trim($('#xqname').val());
	if(xqname == "" || xqname == "例如：何先生") {
		alert("温馨提示：请填写姓名！");
		$('#xqname').focus();
		return ;
	}
	if(xqname.length < 2 || xqname.length > 10) {
		alert("温馨提示：请正确填写姓名！");
		$('#xqname').focus();
		return ;
	}
	var xqmobile = trim($('#xqmobile').val());
	if(xqmobile == "" || xqmobile == "例如：15688878886") {
		alert("温馨提示：请填写手机号！");
		$('#xqmobile').focus();
		return ;
	}
	if(checkXqMob(xqmobile) == false) {
		alert("温馨提示：请正确填写手机号！");
		$('#xqmobile').focus();
		return ;
	}
	var xqqq = trim($('#xqqq').val());
	if(xqqq == "" || xqqq == "例如：826935668") {
		alert("温馨提示：请填写QQ号！");
		$('#xqqq').focus();
		return ;
	}
	if(xqqq.length < 4 || xqqq.length > 12) {
		alert("温馨提示：请正确填写QQ号！");
		$('#xqqq').focus();
		return ;
	}
	if(checksz(xqqq) == false) {
		alert("温馨提示：请正确填写QQ号！");
		$('#xqqq').focus();
		return ;
	}
	var yourWant = trim($('#yourWant').val());
	if(yourWant == "例如：求购一个江浙沪地区女装类天猫店") {
		yourWant = "";
	}
	if(yourWant != "") {
		if(yourWant.length > 200) {
			alert("温馨提示：需求内容限200字！");
			$('#yourWant').focus();
			return ;
		}
	}

	//信息提交
	$.post('/title/message.aspx', {'name':xqname, 'mobile':xqmobile, 'qq':xqqq, 'message':yourWant}, function(data)
	{
		if(data.status)
		{
			$('#ixqsdiv').css('display','none');
			$('#ixqediv').css('display','block');	
		}
		else
		{
			alert(data.msg);
		}
		
	}, 'json');
	return false;
	
}
function DelSesRec() {
	$.post("/mall/ajax_cart_clear",
        {},
		function(data){
			$('#table_cart_list').find('.list').remove();
			$('#table_cart_list').append(
                    '<tr>' +
                        '<td align="center" colspan="6">您暂时还没有看店单信息哦!</td>' +
                    '</tr>'
              );
		}
    )		
}
//店铺对比20150325:
function ShopShowBi() {

    $('#table_cart_list').find('.list').remove();

    $.post("/Malls/AjaxCart.aspx",
        {},
        function(data){
        	debugger;
            data = eval('('+data+')');
            if (data.count > 0)
            {
                for ($i = 0; $i < data.count; $i++)
                {
					
					if(data.cart[$i].name!=null){
						$('#table_cart_list').append(
							'<tr class="list">' +
							'<td align="center"></td>' +
							'<td align="left">' +
							'<p><a class="BiaoTi" href="' + data.cart[$i].url + '" target="_blank">' + data.cart[$i].name + '</a></p>' +
							'</td>' +
							'<td align="center"><strong class="price-wd">' + data.cart[$i].price + '</strong></td>' +
							'<td align="center"></td>' +
							'<td align="center">' + data.cart[$i].area + '</td>' +
							'<td align="center">' +
							'<input type="button" class="gray1-btn-2" value="查看" onclick="window.open(\'' + data.cart[$i].url + '\',\'\',\'\')">' +
							/*'<input type="button" class="gray1-btn-2 mt5" value="清空" onclick="DelSesRec(' + data.cart[$i].id + ')">' +*/
							'</td>' +
							'</tr>'
						);
					}
					else
					{
						
						 $('#table_cart_list').append(
							'<tr>' +
								'<td align="center" colspan="6">您暂时还没有看店单信息哦!</td>' +
							'</tr>'
						);
					}
                }
            }
           /* else
            {
                $('#table_cart_list').append(
                    '<tr>' +
                        '<td align="center" colspan="6">您暂时还没有看店单信息哦!</td>' +
                    '</tr>'
                );
            }*/
        }
    )

    $('#panel_cart_list').css('display','block');

	/*var dt = new Date().getTime();
	Iframe({
    	Url:"/mall/showkddlist.html?dt="+dt,
    	Width:822,
		Height:528,
		scrolling:'no',
		isIframeAutoHeight:false,
		isShowIframeTitle:false,
    	call:function(data){
        }
     });*/
}


$(document).ready(function(){
    $('#btn_cart_list_close').click(function() {
        $('#panel_cart_list').css('display','none');
    })
})

//添加银行卡
function CheckTjForm_1()
{
	var provinceList = document.getElementById("provinceList");
	if(trim(provinceList.value) == "") {
		alert("请选择开户银行所在省份！");
		provinceList.focus();
		return false;
	}
	
	var cityList = document.getElementById("cityList");
	if(trim(cityList.value) == "") {
		alert("请选择开户银行所在城市！");
		cityList.focus();
		return false;
	}
	
	var ikhbank = document.getElementById("ikhbank");
	if(trim(ikhbank.value) == "") {
		alert("请选择开户银行！");
		ikhbank.focus();
		return false;
	}
	
	var izhaddr = document.getElementById("izhshow");
	var branch = trim(izhaddr.value);
	if(branch == "") {
		alert("请选择支行信息！");
		izhaddr.focus();
		return false;
	}
	if(branch == "其它支行") {
		var iobranch = document.getElementById("iobranch");
		if(trim(iobranch.value) == "") {
			alert("请填写其它支行信息！");
			iobranch.focus();
			return false;
		}
	}
	
	var icarcd = document.getElementById("icarcd");
	var v_icarcd = trim(icarcd.value);
	if(v_icarcd == "") {
		alert("请填写银行账号！");
		icarcd.focus();
		return false;
	}
	if(v_icarcd.length < 10) {
		alert("请正确填写银行账号！");
		icarcd.focus();
		return false;
	}
	
	var imcarcd = document.getElementById("imcarcd");
	var v_imcarcd = trim(imcarcd.value);
	if(v_imcarcd == "") {
		alert("请再次填写银行账号！");
		imcarcd.focus();
		return false;
	}
	if(v_imcarcd != v_icarcd) {
		alert("两次填写的银行账号不一致！");
		imcarcd.focus();
		return false;
	}
	
	return true;
}

function WpErwmShow(sg) {
	if(sg == "1") {
		document.getElementById("igwewm").style.display = "";
	}else {
		document.getElementById("igwewm").style.display = "none";
	}
}

(function ($) {

})(jQuery);




jQuery(document).ready(function () {

    if(jQuery.fn.timeago)
        jQuery("time.timeago").timeago();
    if (jQuery.fn.RestTime)
    $('.rest-time').RestTime();
});