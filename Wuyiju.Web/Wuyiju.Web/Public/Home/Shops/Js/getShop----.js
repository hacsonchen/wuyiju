
/**
 * ǰ�˴�����
 */
function ForeWindow(foreWinId)
{
    var self = this;
    var m_isIE = (document.all ? true : false);
    var m_foreWin = $(foreWinId); //ǰ�˴��ڶ���
    var m_boardWin = null;        //���ִ��ڶ���
    var m_screenWidth = 0;
    var m_screenHeight = 0;
    var m_left = 0;
    var m_top = 0;
    var m_isShow = false;
    var m_Overflow = '';
    
    /**
     * ���ִ��ڵ���ɫ
     */
    this.backColor = '#333333';
    
    /**
     * ���ִ��ڵĲ�͸����
     */
    this.opacity = 55;
    
    /**
     * ����Ӧ��������ڴ�С
     */
    function autoResize()
    {
        try
        {
			if(!m_isShow) return;
            m_screenWidth = document.documentElement.clientWidth;
            m_screenHeight = document.documentElement.clientHeight;
            m_foreWin.style.position='absolute';
            m_foreWin.style.display = 'block';
            if(m_left != null && m_top != null){
                m_foreWin.style.top = document.documentElement.scrollTop + m_top + 'px';
                m_foreWin.style.left = document.documentElement.scrollLeft + m_left + 'px';
            }else{
                m_foreWin.style.top = document.documentElement.scrollTop + ((m_screenHeight - m_foreWin.offsetHeight)/2) + 'px';
                m_foreWin.style.left = document.documentElement.scrollLeft + ((m_screenWidth - m_foreWin.offsetWidth)/2) + 'px';
            }
            m_foreWin.style.zIndex = '' + (m_boardWin.style.zIndex + 1);			
            m_boardWin.style.width = m_screenWidth + 'px';
            m_boardWin.style.height = m_screenHeight + 'px';			
            m_boardWin.style.top = document.documentElement.scrollTop + 'px';
            m_boardWin.style.left = document.documentElement.scrollLeft + 'px';
            m_boardWin.style.display = 'block';
        }
        catch(ex){}
    }
        
    /**
     * ��ʾ����
     */
    this.show = function(left, top)
    {
        try
        {
            if(m_isShow) return;
            m_isShow = true;
            m_left = left;
            m_top = top;
            m_Overflow = document.body.parentNode.style.overflow;
            document.body.parentNode.style.overflow="hidden";
            createBoardWindow();
            autoResize();
            if(m_isIE) {
                window.attachEvent('onresize',autoResize);
            }else {
                window.addEventListener('resize',autoResize,false);
            }
        }
        catch(ex){}
    };
    
    /**
     * ���ش���
     */
    this.hide = function()
    {
        try
        {
            m_isShow = false;
            m_foreWin.style.display = 'none';
            m_boardWin.style.display = 'none';
            document.body.parentNode.style.overflow = m_Overflow;
            if(m_isIE) {
                window.detachEvent('onresize',autoResize);
            }else {
                window.removeEventListener('resize',autoResize,true);
            }
            document.body.removeChild(m_boardWin);
            m_boardWin = null;
        }
        catch(ex){}
    };
    
    /**
     * ��ȡDOM����ʵ�����
     */
    function $(id){return document.getElementById(id);}
    
    /**
     * �������ִ���
     */
    function createBoardWindow()
    {
        try
        {
        	m_boardWin = document.createElement('IFRAME');
            m_boardWin.frameBorder=0;
            m_boardWin.allowTransparency=false;
            document.body.appendChild(m_boardWin);
            m_boardWin.style.cssText="position:absolute;left:0px;top:0px;display:none";
            m_boardWin.contentWindow.document.open();
            m_boardWin.contentWindow.document.write('<html><body style="background-color:'+self.backColor+'"></body></html>');
            m_boardWin.contentWindow.document.close();
            m_boardWin.style.filter='alpha(opacity='+self.opacity+')';
            m_boardWin.style.opacity=(self.opacity/100);
            m_boardWin.style.MozOpacity=(self.opacity/100);
			m_boardWin.style.zIndex = 999;
        }
        catch(ex){}
    }
}

//������������Ʒ(cookie)
function emBrowseIsShops()
{
 	var date = new Date();
 	date.setTime(date.getTime()-10000);
 	document.cookie="browseIsShops"+"=v; expires="+date.toGMTString();
 	document.getElementById('browseIsShopsList').innerHTML = "";		
}

//������������ҳ�����js����
function infoTab_1(type) {
	
	if(type == "2") {
		document.getElementById("tab_to_2").className = "cur";
		document.getElementById("tab_to_1").className = "";
		document.getElementById("tab_to_3").className = "";
		document.getElementById("tab_to_4").className = "";
		
		document.getElementById("XqMs-box ChangJianWT").style.display = "block";
		document.getElementById("XqMs-box XinYu").style.display = "none";
		document.getElementById("XqMs-box MiaoShu").style.display = "none";
		document.getElementById("XqMs-box ChuShouLC").style.display = "none";
		document.getElementById("Safety clearfix").style.display = "none";
		document.getElementById("XqMs-box TongLeiDP").style.display = "none";
		
	}else if(type == "3") {
		document.getElementById("tab_to_3").className = "cur";
		document.getElementById("tab_to_1").className = "";
		document.getElementById("tab_to_2").className = "";
		document.getElementById("tab_to_4").className = "";
		
		document.getElementById("XqMs-box ChuShouLC").style.display = "block";
		document.getElementById("Safety clearfix").style.display = "block";
		document.getElementById("XqMs-box XinYu").style.display = "none";
		document.getElementById("XqMs-box MiaoShu").style.display = "none";		
		document.getElementById("XqMs-box ChangJianWT").style.display = "none";
		document.getElementById("XqMs-box TongLeiDP").style.display = "none";

	}else if(type == "4") {
		document.getElementById("tab_to_4").className = "cur";
		document.getElementById("tab_to_1").className = "";
		document.getElementById("tab_to_2").className = "";
		document.getElementById("tab_to_3").className = "";
		
		document.getElementById("XqMs-box TongLeiDP").style.display = "block";
		document.getElementById("XqMs-box ChuShouLC").style.display = "none";
		document.getElementById("Safety clearfix").style.display = "none";
		document.getElementById("XqMs-box XinYu").style.display = "none";
		document.getElementById("XqMs-box MiaoShu").style.display = "none";		
		document.getElementById("XqMs-box ChangJianWT").style.display = "none";

	}else {
		document.getElementById("tab_to_1").className = "cur";
		document.getElementById("tab_to_2").className = "";
		document.getElementById("tab_to_3").className = "";
		document.getElementById("tab_to_4").className = "";
		
		document.getElementById("XqMs-box XinYu").style.display = "block";
		document.getElementById("XqMs-box MiaoShu").style.display = "block";
		document.getElementById("XqMs-box ChangJianWT").style.display = "";
		document.getElementById("XqMs-box ChuShouLC").style.display = "";
		document.getElementById("Safety clearfix").style.display = "none";
		document.getElementById("XqMs-box TongLeiDP").style.display = "";
	}
}

function InfoTab(type) 
{
	if(type == 1)
	{
		document.getElementById("photoInfo").style.display = "block";
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
		document.getElementById("photoInfo").style.display = "none";
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
		document.getElementById("photoInfo").style.display = "none";
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

function rentTimeOnLoad(type)
{
	$("#rentTimeSelect span").removeClass("rentTimeActived");
	
	$("#rentTimeR" + type).addClass("rentTimeActived");
	document.getElementById("rentTimeHi").value = type;
	priceSearch(type);
	
	$("#rentPriceSpan").html(onloadRentPrice.replace(",",""));
}

function DateDiff(sDate1, sDate2){ 
 	var aDate, oDate1, oDate2, iDays;
 	
 	aDate = sDate1.split("-");
 	oDate1 = new Date(aDate[1] + '-' + aDate[2] + '-' + aDate[0]); 
 	aDate = sDate2.split("-"); 
 	oDate2 = new Date(aDate[1] + '-' + aDate[2] + '-' + aDate[0]); 
 	iDays = parseInt(Math.abs(oDate1 - oDate2) / 1000 / 60 / 60 /24); 
 	return iDays;
} 

function selNewDrawAcct()
{
	myForeWindow= new ForeWindow("payWin");
	isMyForeWindowShow = true;
	myForeWindow.show();
}

function hide()
{
	isMyForeWindowShow = false;
	myForeWindow.hide();
}
function strDateTime(str)
{ 
   var r = str.match(/^(\d{1,4})(-|\/)(\d{1,2})\2(\d{1,2})$/); 
   if(r==null)return false; 
   var d= new Date(r[1], r[3]-1, r[4]); 
   return (d.getFullYear()==r[1]&&(d.getMonth()+1)==r[3]&&d.getDate()==r[4]); 
}
function doDelete(path)
{
 	var msg = "��ȷ��Ҫ "+ path +"��\n\n��ȷ�ϣ�";
 	var flag = true;
	if (confirm(msg) == flag)
	{	
		return true;	
	}else {
		return false;
	}
}

function addBookmark(title,url) { 
	if (window.sidebar) { 
		window.sidebar.addPanel(title,url,""); 
	} else if( document.all ) { 
		window.external.AddFavorite(url,title); 
	} else if( window.opera && window.print ) { 
		return true; 
	} 
}

function fenShow() {
	
	document.getElementById("ifenqishow").style.display="block";
}

function qiXuan(sg) {
	document.getElementById("ixnfnqi").value = sg;
	$("#ifenq"+sg).addClass("fenqishuXuanzhong").siblings().removeClass("fenqishuXuanzhong");
}

function orderSave() {
	
	//document.getElementById("iformsj").action = wushop+"/markorder.html";
	//document.getElementById("iformsj").submit();
	window.location.href = wushop+"/markorder.html?shopId="+shopId;
}

function fenqiSave() {
	
	var fenqi = document.getElementById("ixnfnqi").value;
	if(fenqi == null || fenqi == "") {
		alert("��ܰ��ʾ����ѡ���������");
		return ;
	}
	window.location.href = wushop+"/markorder.html?shopId="+shopId+"&fenqi="+fenqi;
}

//���͵��ֻ�:
function sendMsg() {
	window.open(wushop+"/tosendmsg.html?shopid="+shopId+"&sg=1",'',"");
}

//�ղ�:
function saveCollection() {
	
 	if(confirm("ȷ������������ӵ��ղؼ���") == true) {
 		window.open(wushop+"/toaddscj.html?shopId="+shopId,'',"");
	}
}

//�ٱ�:
function reportMessage(op) {
	window.open(wushop+"/displayError.html?param="+op+"&spid="+shopId,'',"");
}

//��ӵ����굥:
function AddToSesList()
{
	var dt = new Date().getTime();
	Iframe({
    	Url:"addtokdd.html?shopid="+shopId+"&dt="+dt,
    	Width:360,
		Height:150,
		scrolling:'no',
		isIframeAutoHeight:false,
		isShowIframeTitle:false,
    	call:function(data){
        }
     });
}

//���굥�б�:
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

function copyToClipBoard() {
    var clipBoardContent = shopSId+"";
    var s = window.clipboardData.setData("Text",clipBoardContent);
    if(s == true) {
		alert("���Ƴɹ���");
	}
}

function convert_Img(pimage,pindex,size)
{
	var sizeList = size.split('*');
	var imagesHTML = "";
	var t = 0;
	for(i = 1 ; i < Number(sizeList[1]) + 1;i++)
	{
		for(j = 1 ; j < Number(sizeList[0]) + 1;j++) {
			t++;
			imagesHTML = imagesHTML + "<div style=\"float:left;overflow:hidden;\"><img width=\"460\" src=\"" + picpath + pimage + "\" /></div>"
		}
	}
	$("#u"+pindex).html(imagesHTML);
	$(".tab_content").hide();
	$("#u"+pindex).show();
}

function IndexShow() {
	alert("��ܰ��ʾ������ϵҵ��Ա��ͨ�鿴������ҳͼ�Ĺ��ܣ�");
}

//�ٱ�ģ��:
function jbhidexla() {
	if(document.getElementById("ijboutflag").value == "") {
		jubaohide();
	}
}
function jbhrefout()
{
	document.getElementById("ijboutflag").value = "";
	setTimeout("jbhidexla()",200);
}
function jubaoshow() {
	document.getElementById("ijboutflag").value = "1";
	document.getElementById("ijua").className="jubao cur";
	document.getElementById("ijubao").style.display="block";
}
function jubaohide() {
	document.getElementById("ijua").className="jubao";
	document.getElementById("ijubao").style.display="none";
	document.getElementById("ijboutflag").value = "";
}

//���Сͼ�л���ͼ:
function mEpt(mimg,pid) {

	$("div.picList ul li").removeClass("cur");
	document.getElementById("ipicli"+pid).className="cur";
    document.getElementById("idatu").src = picpath+"/d_"+mimg;
    document.getElementById("idatuhref").href = picpath+"/tmp_"+mimg;
}
function mEpt0(mimg,pid) {

	$("div.picList ul li").removeClass("cur");
	document.getElementById("ipicli"+pid).className="cur";
    document.getElementById("idatu").src = "http://www.5pao.com/shopmm/images/0830/"+mimg+"-4.jpg";
    document.getElementById("idatuhref").href = "http://www.5pao.com/shopmm/images/0830/"+mimg+"-tmp.jpg";
}

function tzWangdian() {
    window.open("tmallIndexNew.html",'',"");
}

function startplay() {

	$str = '<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="750" height="500"'+
                   ' id="blog_index_flash">'+
                    '<param name="movie" value="http://www.5pao.com/shopmm/flash/gmjiaocheng.swf" />'+
                    '<param name="wmode" value="transparent" />'+
                    '<param name="menu" value="false">'+
                    '<param name="quality" value="high" />'+
                    '<param name="allowScriptAccess" value="sameDomain" />'+
                    '<param name="allowFullScreen" value="true" />'+
                    '<object type="application/x-shockwave-flash" data="http://www.5pao.com/shopmm/flash/gmjiaocheng.swf" width="750"'+
                        'height="500" id="blog_index_flash_ff">'+
                        '<param name="quality" value="high" />'+
                        '<param name="wmode" value="transparent" />'+
                        '<param name="menu" value="false">'+
                        '<param name="allowScriptAccess" value="sameDomain" />'+
                        '<param name="allowFullScreen" value="true" />'+
                    '</object>'+
            '</object>';
			
	$('#gmbz_video').html($str);
}

function helpVideo() {
	
	videoShow();
	
	$str = '<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="750" height="500"'+
                   ' id="blog_index_flash">'+
                    '<param name="movie" value="http://www.5pao.com/shopmm/flash/gmjiaocheng.swf" />'+
                    '<param name="wmode" value="transparent" />'+
                    '<param name="menu" value="false">'+
                    '<param name="quality" value="high" />'+
                    '<param name="allowScriptAccess" value="sameDomain" />'+
                    '<param name="allowFullScreen" value="true" />'+
                    '<object type="application/x-shockwave-flash" data="http://www.5pao.com/shopmm/flash/gmjiaocheng.swf" width="750"'+
                        'height="500" id="blog_index_flash_ff">'+
                        '<param name="quality" value="high" />'+
                        '<param name="wmode" value="transparent" />'+
                        '<param name="menu" value="false">'+
                        '<param name="allowScriptAccess" value="sameDomain" />'+
                        '<param name="allowFullScreen" value="true" />'+
                    '</object>'+
            '</object>';
			
	$('#gmbz_video').html($str);
}

function videoShow() {
    var htm="<div id='getPh' class='getPh'></div>";
    $("body").append(htm);
    $("#jianz").css("display","block");
    $("#getPh").css({"width":$(document).width(),"height":$(document).height()});
	$("#jianz").css({"left":($(document).width()-$("#jianz").width()-10)/2,"top":($(window).height()-$("#gmbz_video").height())/2});
    //�󶨹ر��¼�:
    $("#closePHoto").click(function() {
        $("#getPh").remove();
        $("#jianz").css("display","none");
    });
}

/***************************08-30**********************************/

function liscroll() {

var $slider = $('.slider ul');
var $slider_child_l = $('.slider ul li').length;
var $slider_width = $('.slider ul li').width()+3;
$slider.width($slider_child_l * ($slider_width+10));

var slider_count = 0;
if ($slider_child_l < 4) {
	$('#btn-right').css({cursor: 'auto'});
	$('#btn-right').removeClass("dasabled");
}
$('#btn-right').click(function() {
	if ($slider_child_l < 4 || slider_count >= $slider_child_l - 4) {
		return false;
	}
	slider_count++;
	$slider.animate({left: '-=' + $slider_width + 'px'}, 'slow');
	slider_pic();
});
$('#btn-left').click(function() {
	if (slider_count <= 0) {
		return false;
	}
	slider_count--;
	$slider.animate({left: '+=' + $slider_width + 'px'}, 'slow');
	slider_pic();
});

}

/***************************14-12-12**********************************/

function askshow(shis,ywqq) {

	if(typeof(shis) == "undefined") {
		shis = "err";
	}

	if(shis != null && shis == "no") {
		//�ܾ�,���ٵ���;
	}else {
	
		//$.cookie('spaskshow', 'ok', { expires: 0, path: '/' });
		
		//������,�ٴμ���Ƿ��ѵ�����(��ҳ���):
		var sonemo = $.cookie('spaskonemo');
		if(sonemo != null && sonemo == "yh") {
			//���ٵ���;
		}else {
			
			//��¼ͬһ��������ѵ�����:
			$.cookie('spaskonemo', 'yh', { expires: 0, path: '/' });
	
			//show:
			ywqq = ywqq.replace(/&/g,"@");
			Iframe({
		    	Url:"shop/zixun.jsp?ywqq="+ywqq,
		    	Width:600,
				Height:278,
				scrolling:'no',
				isIframeAutoHeight:false,
				isShowIframeTitle:false,
		    	call:function(data) {
		        }
		    });		
		}
	}
}

//2015-07-15:
function wanshow(ywqq) {

	ywqq = ywqq.replace(/&/g,"@");
	Iframe({
    	Url:"shop/yiwan.jsp?ywqq="+ywqq,
    	Width:555,
		Height:145,
		scrolling:'no',
		isIframeAutoHeight:false,
		isShowIframeTitle:false,
    	call:function(data) {
        }
    });	
}

function ShowAskWin(aurl) {
	window.open(aurl,'',"width=644,height=544,toolbar=no,scrollbars=no,menubar=no,status=no");
}

/*$(function() {
    var _top = $('#ljzx').offset().top;
    var oldST = 0;
    $(window).scroll(function() {
        if($(window).scrollTop() <= _top && oldST > _top){
            $('#ljzx img').attr('src',$('#ljzx img').attr('src'));
        };
        oldST = $(window).scrollTop();
    });
});*/

$(function() {
    $('#service30 .each').mouseover(function() {
        $('#J_current').stop().animate({'top':$(this).attr('flag')*33}, 100);
        $('#serviceItem30 .detail-con').eq($(this).index()).addClass('selected').siblings().removeClass('selected');
    });
});
function infoTabNew(n) {
    $('.tab-XiangQing a').removeClass('cur').eq(n-1).addClass('cur');
    switch(n) {
        case 1: $('.tabOne').css('display','block');
                $('.tabTwo').css('display','block');
                $('.tabThree').css('display','block');
            break;
        case 2: $('.tabOne').css('display','none');
                $('.tabTwo').css('display','block');
                $('.tabThree').css('display','none');
            break;
        case 3: $('.tabOne').css('display','none');
                $('.tabTwo').css('display','block');
                $('.tabThree').css('display','none');
            break;
        case 4: $('.tabOne').css('display','none');
                $('.tabTwo').css('display','none');
                $('.tabThree').css('display','block');
            break;
    }
}

/*DWREngine.setAsync = function(async) {
    DWREngine._async = async;
};*/

var pageNo = 0;
function ShowSameShops() {
	
	//DWREngine.setAsync(false);
	dwr.engine.setAsync(false);
	pageNo ++;
	spIndexDwr.querySameShops(shopStr,'4',pageNo,
	{
	      callback:function(datalist) {

			var str = "";
			if(datalist != null && datalist.length > 0) {
				
				var listr = "";
				var imgstr = "";
				var titStr = "";
				for(var i=0;i<datalist.length;i++) {

					listr = "";
					if((i+1) == datalist.length) {
						listr = "style=\"border:none;\"";
					}
					if(datalist[i].sellLevImage != null && datalist[i].sellLevImage != '') {		
						titStr = "";
						if(datalist[i].sellerCredit != null && datalist[i].sellerCredit > 0) {
							titStr = " title=\""+datalist[i].sellerCredit+"\"";
						}
						imgstr = "<img src=\"images/"+datalist[i].sellLevImage+"\""+titStr+" />";
					}else {
						if(datalist[i].saletype == "9") {
							imgstr = "����";
						}else if(datalist[i].saletype == "2") {
							imgstr = "�̳�";
						}else {
							imgstr = "����";
						}
					}
					if(datalist[i].zhuying != "") {
						imgstr += " | "+datalist[i].zhuying;
					}
					if(datalist[i].isyueru == "1") {
						imgstr += " | ������"+datalist[i].yuemon+"��";
					}
					
					str += "<li "+listr+">";
            		str += "<i class=\"tjIco\"></i>";
	                str += "<div class=\"price\">��<br/>"+datalist[i].csprice+"</div>";
	                str += "<div class=\"title\">";
	                str += "<p><a href=\"shopsGet-"+datalist[i].id+".html\" title=\""+datalist[i].spTitle+"\" target=\"_blank\">"+datalist[i].spTitle+"</a></p>";
	                //str += "<p>"+imgstr+"</p>";
	                str += "</div>";
	            	str += "</li>";
				}
				
				document.getElementById("ishopshow").innerHTML = str;

			 }else {
				 //str ="<div class=\"item\"><div>������Ӧͬ�������Ϣ!</div></div>";
				 document.getElementById("isameshopdiv").style.display = "none";
			 }
		  }
	});
}