
function AddRes() {
	parent.Close();
	parent.location.reload();
}

function Showgo(uid,unm) {
	parent.Close();
	parent.location.href = "http://www.5pao.com/theuser/regreset.html?regid="+uid+"&regmobile="+unm;
}

//点击'添加银行卡':
function ToAddBank() {
     
     Iframe({
	    	Url:"/user/bankadd.html",
	    	Width:604,
			Height:510,
			scrolling:'no',
			isIframeAutoHeight:false,
			isShowIframeTitle:false,
	    	call:function(data){
	        }
     });
}

//编辑银行卡:
function ToEditBank(bid) {
     
     Iframe({
	    	Url:"bankedit.html?bid="+bid,
	    	Width:604,
			Height:510,
			scrolling:'no',
			isIframeAutoHeight:false,
			isShowIframeTitle:false,
	    	call:function(data){
	        }
     });
}

//标记银行卡:
function ToMarkBank(bid,oflag) {

	Iframe({
    	Url:"tomarkbank.html?bid="+bid+"&oflag="+oflag,
    	Width:400,
		Height:180,
		scrolling:'no',
		isIframeAutoHeight:false,
		isShowIframeTitle:false,
    	call:function(data){
        }
	});
}

//添加or编辑银行卡:
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
	
	var izhaddr = document.getElementById("izhaddr");
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

//索引查询:
$.fn.selectval = function(inputId, ulId, defaultValue) {
	//change keyup
	$(inputId).on("keyup", function() {
		$(ulId).css("display","block");
		getData($(inputId).val());
		document.getElementById("izhaddr").value = ""; //清空原赋值;
	});	
	$(inputId).on("focus", function() {
		if($(inputId).val() == defaultValue) {
			$(inputId).val("");
			getData("");
		}else {
			getData($(inputId).val());
		}
	});	
	$(ulId + ">li").bind("click", function() {
		var xzh = $(this).html();
		$(inputId).val(xzh); //文本框显示内容;
		$('#izhaddr').val($(this).attr("id")); //真正的隐藏域'支行'赋值;
		$(ulId + ">li").css("display", "none");
		$(ulId).css("display", "none");
		
		if(xzh != null && xzh == "其它支行") {
			document.getElementById("ibranchtr").style.display = "";
		}else {
			document.getElementById("ibranchtr").style.display = "none";
		}
	});
	function getData() {
		$(ulId + ">li").css("display","none");
		$.each($(ulId + ">li"), function(index, obj) {
			if($(obj).html().indexOf($(inputId).val()) >= 0) {
				$(ulId).css("display","block");
				$(obj).css("display","block");
			}
			if($(ulId + ">li:visible").size() * 1 > 6) {
				$(ulId).css({"height":"175","overflow":"auto","overflow-x":" hidden"});
			}else {
				$(ulId).css({"height":$(ulId + ">li:visible").size() * 16, "overflow":"inherit"});	
			}
		});
	}
}

//获取银行支行信息,2015-01-16:
function ShowBranch(yixuan) {
	
	var prov = trim(document.getElementById("provinceList").value);
	var city = trim(document.getElementById("cityList").value);
	var bank = trim(document.getElementById("ikhbank").value);
	if(prov == null || prov == "") {
		alert("请选择开户银行所在省份！");
		document.getElementById("ikhbank").selectedIndex = 0;
		return false;
	}
	if(city == null || city == "") {
		alert("请选择开户银行所在城市！");
		document.getElementById("ikhbank").selectedIndex = 0;
		return false;
	}
	if(bank == null || bank == "") {
		//开户银行置空时,清空分行信息:
		$('#iselectInput').html("");
		document.getElementById("izhshow").value = "";
		document.getElementById("izhaddr").value = "";
		$('#iselectInput').css("display","none");
		return false;
	}
	
	//支行清空赋初始值:
	$('#iselectInput').html("");
	$('#iselectInput').css("display","none");	
	if(yixuan == null || yixuan == "") {
		document.getElementById("izhshow").value = "";
		document.getElementById("izhaddr").value = "";
	}
	
	/*DWREngine.setMethod(DWREngine.ScriptTag);
	BankDwr.GetBankBranch(prov,city,bank,
	{
	      callback:function(datalist) {

	    	  var szstr = "";
	    	  if(datalist != null && datalist.length > 0) {
	    		  
	    		  for(var i=0;i<datalist.length;i++) {
	    			  szstr = szstr+"<li id='"+datalist[i].bankcode+"'>"+datalist[i].bankname+"</li>";		  
	    		  }
	    	  }
	    	  szstr = szstr+"<li id='其它支行'>其它支行</li>"; //附加其它;
	    	  
	    	  $('#iselectInput').html(szstr);
	    	  $().selectval("#izhshow", "#iselectInput", "");
	      }
	});*/
}

function OtherBranch() {
	
	var branch = trim(document.getElementById("izhaddr").value);
	if(branch != null && branch == "其它支行") {
		document.getElementById("ibranchtr").style.display = "";
	}else {
		document.getElementById("ibranchtr").style.display = "none";
	}
}

function OtherBranchByEdit(branch) {
	
	if(branch != null && branch == "其它支行") {
		document.getElementById("ibranchtr").style.display = "";
	}else {
		document.getElementById("ibranchtr").style.display = "none";
	}
}

//城市变动清空开户银行及支行:
function ClearBankByCity() {
	
	var bank = trim(document.getElementById("ikhbank").value);
	if(bank != null && bank != "") {
		
		document.getElementById("ikhbank").selectedIndex = 0;	
		//开户银行置空时,清空分行信息:
		$('#iselectInput').html("");
		document.getElementById("izhshow").value = "";
		document.getElementById("izhaddr").value = "";
	    document.getElementById("ibranchtr").style.display = "none";
	    $('#iselectInput').css("display","none");
	}
}