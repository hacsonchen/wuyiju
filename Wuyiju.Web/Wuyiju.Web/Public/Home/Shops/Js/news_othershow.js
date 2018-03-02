
function fytj(pg) {
	document.getElementById("ipageid").value = pg;
	document.getElementById("iformss").submit();
}

//跳转到:
function fytz() {
	var fy = trim(document.getElementById("itzfy").value);
	document.getElementById("ipageid").value = fy;
	document.getElementById("iformss").submit();
}

function tzfygo(turl) {
	var fy = trim(document.getElementById("itzfy").value);
	window.location.href = turl+"-"+fy+".html";
}

function ShowShops(sg,topnum)
{
	if(sg == "1") {
		document.getElementById("ishop1").className = "yixuan";
		document.getElementById("ishop2").className = "noxuan";
	}else {
		document.getElementById("ishop1").className = "noxuan";
		document.getElementById("ishop2").className = "yixuan";
	}
	
	DWREngine.setMethod(DWREngine.ScriptTag);
	spIndexDwr.queryShops(sg,topnum,'rec',
	{
	      callback:function(datalist) {

			var str = "";
			if(datalist != null && datalist.length > 0) {
				
				str ="<ul>";
				var classStr = "";
				for(var i=0;i<datalist.length;i++) {
					
					classStr = "";
					if((i+1) % 2 == 0) {
						classStr = "bluebg ";
					}
					
					str += "<li class=\""+classStr+"clearfix\"><span class=\"price\">￥"+datalist[i].csprice+"</span><a href=\""+sp_url+"/shopsGet-"+datalist[i].id+".html\" title=\""+datalist[i].spTitle+"\" target=\"_blank\">"+datalist[i].spTitle+"</a></li>";
				}
				str += "</ul>";

			 }else {

				 str ="<ul><li class=\"clearfix\">暂无相应信息!</li></ul>";
			 }
			
			 document.getElementById("ishopshow").innerHTML = str;			
		  }
	});
}

function ShowGoods()
{
	DWREngine.setMethod(DWREngine.ScriptTag);
	dxIndexDwr.queryGoods('10','sell',
	{
	      callback:function(datalist) {

			var str = "";
			if(datalist != null && datalist.length > 0) {

				var q3 = "";
				var c2 = "";
				var gname = "";
				for(var i=0;i<datalist.length;i++) {
					
					if(i < 3) {
						q3 = "orange";
					}else {
						q3 = "dark";
					}
					
					if((i+1) % 2 == 0) {
						c2 = "class=\"bluebg\"";
					}else {
						c2 = "";
					}
					
					gname = datalist[i].name;
					if(gname.length > 20) {
						gname = gname.substring(0, 18)+"...";
					}
					str = str + "<li "+c2+"><span class=\""+q3+"\">"+(i+1)+"</span>&nbsp;<a href=\""+dx_url+"/get_goods-"+datalist[i].id+".html\" target=\"_blank\" title=\""+datalist[i].name+"\">"+gname+"</a></li>";
				}

			 }else {

				 str ="<li>暂无相应信息!</li>";
			 }
			
			 document.getElementById("igoodshow").innerHTML = str;
		  }
	});
}

//每日推荐:
function DayTopShops()
{
	DWREngine.setMethod(DWREngine.ScriptTag);
	spIndexDwr.DayTopShops(
	{
	      callback:function(datalist) {

			var str = "";
			if(datalist != null && datalist.length > 0) {
				
				var shopxy = "";
				var sbliyou = "";
				var shopurl = "";
				var saletype = "";
				var sellLevImage = "";
				var listr = "";
				var titStr = "";
				
				str ="<ul class=\"clearfix\">";
				
				for(var i=0;i<datalist.length;i++) {
					
					saletype = datalist[i].saletype;
					listr = "";
					
					sellLevImage = datalist[i].sellLevImage;
					if(saletype != null && saletype == 2) { //天猫商城:
						
						listr = " class=\"tmall\"";
					}
					
					if(sellLevImage != null && sellLevImage != '') {
						titStr = "";
						if(datalist[i].sellerCredit != null && datalist[i].sellerCredit > 0) {
							titStr = "title=\""+datalist[i].sellerCredit+"\"";
						}
						shopxy = "<img src=\""+sp_url+"/images/"+sellLevImage+"\" align=\"absbottom\" border=\"0\" "+titStr+" />";
					}else {
						if(saletype == 9) {
							shopxy = "其它";
						}else if(saletype == 2) {
							shopxy = "商城";
						}else {
							shopxy = "网店";
						}
					}
					
					sbliyou = trim(datalist[i].jpremark);
					if(sbliyou.length > 45) {
						sbliyou = sbliyou.substring(0,42)+"...";
					}
					
					shopurl = sp_url+"/shopsGet-"+datalist[i].id+".html";
					if(datalist[i].status == 3 || datalist[i].status == 4) {
						shopurl = "javascript:void(0)";
					}
					
					str += "<li"+listr+">";
					str += "<a href=\""+shopurl+"\" target=\"_blank\" class=\"titleLink\" title=\""+datalist[i].spTitle+"\">"+datalist[i].spTitle+"</a>";
					str += "<p class=\"credit-rcdt\"><span>网店信用：</span><a href=\""+shopurl+"\" target=\"_blank\">"+shopxy+"</a></p>";
					str += "<div class=\"reasonRank\"><div class=\"mbody-rcdt\"><p class=\"t-org\">上榜理由：</p><p class=\"rBody\">"+sbliyou+"</p></div><i class=\"flag-rcdt\"></i></div>";
					str += "</li>";
				}
				
				str += "</ul>";

			 }else {
				 str ="<ul class=\"clearfix\"><li>暂无相应信息!</li></ul>";
			 }
			
			 document.getElementById("idaytopshow").innerHTML = str;
		  }
	});
}

function trim(str) {
	return str.replace(/(^\s*)|(\s*$)/g, "");
}

function zxcz()
{
	var ndesc = trim(document.getElementById("indesc").value);
	if(ndesc == "") {
		alert("温馨提示：请输入搜索内容！");
		return ;
	}
	document.getElementById("iformcz").submit();
}