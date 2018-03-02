
function copyToClipBoard(bianhao) {
    var s = window.clipboardData.setData("Text",bianhao);
    if(s == true) {
		alert("复制成功！");
	}
}

//立即出售:
function saleCheck() {
	document.getElementById("iformsj").action = wushop+"/markqgorder.html";
	document.getElementById("iformsj").submit();
}

//网店详情新增页面控制js方法
function infoTab_1(type) {
	
	if(type == "3") {		
		document.getElementById("tab_to_3").className = "cur";
		document.getElementById("tab_to_2").className = "";
		document.getElementById("tab_to_1").className = "";
		document.getElementById("XqMs-box ChuShouLC").style.display = "";
		document.getElementById("Safety clearfix").style.display = "";
		document.getElementById("XqMs-box MiaoShu").style.display = "none";
		document.getElementById("XqMs-box ChangJianWT").style.display = "none";
		
	}else if(type == "2") {
		document.getElementById("tab_to_2").className = "cur";
		document.getElementById("tab_to_3").className = "";		
		document.getElementById("tab_to_1").className = "";
		document.getElementById("XqMs-box ChangJianWT").style.display = "";
		document.getElementById("XqMs-box MiaoShu").style.display = "none";
		document.getElementById("XqMs-box ChuShouLC").style.display = "none";
		document.getElementById("Safety clearfix").style.display = "none";

	}else {
		document.getElementById("tab_to_1").className = "cur";
		document.getElementById("tab_to_2").className = "";
		document.getElementById("tab_to_3").className = "";
		document.getElementById("XqMs-box MiaoShu").style.display = "";
		document.getElementById("XqMs-box ChangJianWT").style.display = "";
		document.getElementById("XqMs-box ChuShouLC").style.display = "";
		document.getElementById("Safety clearfix").style.display = "";
	}
}

function InfoTab(type) 
{
	if(type == 1)
	{
		document.getElementById("tab_to_1").className = "action";
		document.getElementById("zongheQu").style.display = "block";
		document.getElementById("tab_to_2").className = "";
		document.getElementById("goumaiLc").style.display = "block";
		document.getElementById("changjianWt").style.display = "block";
		document.getElementById("doubleSafe").style.display = "block";
		document.getElementById("tab_to_3").className = "";
		document.getElementById("changjianWt_tit").style.display = "block";
		document.getElementById("goumaiLc_tit").style.display = "block";
		document.getElementById("mobanjiashao").style.display = "block";
	}else if(type == 2) {
		document.getElementById("tab_to_1").className = "";
		document.getElementById("changjianWt").style.display = "block";
		document.getElementById("tab_to_2").className = "action";
		document.getElementById("goumaiLc").style.display = "none";
		document.getElementById("doubleSafe").style.display = "none";
		document.getElementById("tab_to_3").className = "";
		document.getElementById("mobanjiashao").style.display = "none";
		document.getElementById("changjianWt_tit").style.display = "none";
		document.getElementById("goumaiLc_tit").style.display = "none";
	}else if(type == 3) {
		document.getElementById("tab_to_1").className = "";
		document.getElementById("changjianWt").style.display = "none";
		document.getElementById("tab_to_2").className = "";
		document.getElementById("goumaiLc").style.display = "block";
		document.getElementById("doubleSafe").style.display = "block";
		document.getElementById("tab_to_3").className = "action";
		document.getElementById("mobanjiashao").style.display = "none";
		document.getElementById("changjianWt_tit").style.display = "none";
		document.getElementById("goumaiLc_tit").style.display = "none";
	}
}

//看店单列表:
function ShowSesList()
{
	Iframe({
    	Url:"showkddlist.html",
    	Width:822,
		Height:528,
		scrolling:'no',
		isIframeAutoHeight:false,
		isShowIframeTitle:false,
    	call:function(data){
        }
     });
}

//发送到手机:
function sendMsg() {
	window.open(wushop+"/tosendmsg.html?shopid="+qiugoId+"&sg=2",'',"");
}

//收藏:
function saveCollection() {
	
 	if(confirm("确定将此求购添加到收藏夹吗？") == true) {
 		window.open(wushop+"/addqgscj.html?qigoID="+qiugoId,'',"");
	}
}

function tzWangdian() {
    window.open("transIndex.html",'',"");
}