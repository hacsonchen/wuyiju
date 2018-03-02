
function view(id) {
	if(id > 0) {
		$.ajax({url:'/ShopView.aspx?id='+parseInt(id), async:false}).responseText;
	}
}

//收藏:
function saveCollection(type) {
	
 var product_id=$('#product_id').val();
	$.post(
		"/Malls/AddFavorite.aspx",
		{
            "product_id":product_id,
            "type":type
        },
		function(data){
			data = eval('('+data+')');
			if(data.result > 0)
			{
				layer.alert("收藏成功可以会员中心查看！");
			}
            else
            {
                layer.alert(data.message);
            }
		}
	)
	
}

//添加到对比单:
function AddToSesList()
{
	var product_id=$('#product_id').val();
	$.post(
		"/Malls/AddSesList.aspx",
		{"product_id":product_id},
		function(data){
			data = eval('('+data+')');
		 if(data.result > 0)
			{
				layer.alert('添加成功');
			}
		}
	)

}

/**
 * 前端窗口类
 */
function ForeWindow(foreWinId)
{
    var self = this;
    var m_isIE = (document.all ? true : false);
    var m_foreWin = $(foreWinId); //前端窗口对象
    var m_boardWin = null;        //遮罩窗口对象
    var m_screenWidth = 0;
    var m_screenHeight = 0;
    var m_left = 0;
    var m_top = 0;
    var m_isShow = false;
    var m_Overflow = '';
    
    /**
     * 遮罩窗口的颜色
     */
    this.backColor = '#333333';
    
    /**
     * 遮罩窗口的不透明度
     */
    this.opacity = 55;
    
    /**
     * 自适应浏览器窗口大小
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
     * 显示窗口
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
     * 隐藏窗口
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
     * 获取DOM对象实例句柄
     */
    function $(id){return document.getElementById(id);}
    
    /**
     * 创建遮罩窗口
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


//网店详情新增页面控制js方法
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
 	var msg = "您确定要 "+ path +"吗？\n\n请确认！";
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

function fenqiSave() {
	
	var fenqi = document.getElementById("ixnfnqi").value;
	if(fenqi == null || fenqi == "") {
		alert("温馨提示：请选择分期数！");
		return ;
	}
	window.location.href = wushop+"/markorder.html?shopId="+shopId+"&fenqi="+fenqi;
}

//发送到手机:
function sendMsg() {
	window.open(wushop+"/tosendmsg.html?shopid="+shopId+"&sg=1",'',"");
}


//举报:
function reportMessage(op) {
	window.open(wushop+"/displayError.html?param="+op+"&spid="+shopId,'',"");
}



function copyToClipBoard() {
    var clipBoardContent = shopSId+"";
    var s = window.clipboardData.setData("Text",clipBoardContent);
    if(s == true) {
		alert("复制成功！");
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
	alert("温馨提示：请联系业务员开通查看店铺首页图的功能！");
}

//举报模块:
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
		//拒绝,不再弹出;
	}else {
	
		//$.cookie('spaskshow', 'ok', { expires: 0, path: '/' });
		
		//允许弹出,再次检测是否已弹出过(多页面打开):
		var sonemo = $.cookie('spaskonemo');
		if(sonemo != null && sonemo == "yh") {
			//不再弹出;
		}else {
			
			//记录同一浏览器中已弹出过:
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

    $('#btn-tm-view,#btn-contract-view,#btn-url-view,#btn-shop-view').click(function(){
    	$.ajax({
    		url:'/Malls/KanDian.aspx',
    		data:{ id:$('#product_id').val()},
    		type:'GET',
    		success:function(data){
    			data = eval( "(" + data + ")" );
    			if(data.result == 'success'){
    				$('#btn-tm-view').text(data.TM);
    				$('#btn-contract-view').text(data.Contact)
    				$('#btn-url-view').text(data.Url);
    				$('#btn-shop-view').text(data.ShopDesc);
    			}else if(data.result == 'error'){
    				layer.alert(data.msg);
    			}else{
    				layer.alert('未知异常！');
    			}
    		}
    	});
    });
});


function infoTabNew(n) {
    $('.tab-XiangQing a').removeClass('cur').eq(n-1).addClass('cur');
    switch(n) {
        case 1: $('.tabOne').css('display','block');
                $('.tabTwo').css('display','block');
                $('.tabThree').css('display','block');
                $('.tabFour').css('display','block');
            break;
        case 2: $('.tabOne').css('display','none');
                $('.tabTwo').css('display','block');
                $('.tabThree').css('display','none');
                $('.tabFour').css('display','none');
            break;
        case 3: $('.tabOne').css('display','none');
                $('.tabTwo').css('display','none');
                $('.tabThree').css('display','block');
                $('.tabFour').css('display','none');
            break;
        case 4: $('.tabOne').css('display','none');
                $('.tabTwo').css('display','none');
                $('.tabThree').css('display','none');
                $('.tabFour').css('display','block');
            break;
    }
}

//评价:
function pingJsale(logu,saleId,shopId) {
	//var obj = window.frames["fancybox-frame"];
	//var saleId = document.getElementById('saleId').value;
	//var shopId = document.getElementById('shopId').value;
	
	if(logu != null && logu != "") {
		Iframe({
	    	Url:"/mall/topjsale.html?saleId="+saleId+"&shopId="+shopId,
	    	Width:606,
			Height:356,
			scrolling:'no',
			isIframeAutoHeight:false,
			isShowIframeTitle:false,
	    	call:function(data) {
	        }
	    });
		
	}else {
		  window.location.href = "/user/login.html?fromurl=http://www.5pao.com/mall/shopsGet-"+shopId+".html";
		//window.location.href = "/user/login.html?fromurl=http://www.5pao.com/shopmm/shopsGet-"+shopId+".html";
	}
}


$(document).ready(function(){

	// 图片上下滚动

	var count = $("#imageMenu li").length - 5; /* 显示 6 个 li标签内容 */

	var interval = $("#imageMenu li:first").width();

	var curIndex = 0;

	

	$('.scrollbutton').click(function(){

		if( $(this).hasClass('disabled') ) return false;

		

		if ($(this).hasClass('smallImgUp')) --curIndex;

		else ++curIndex;

		

		$('.scrollbutton').removeClass('disabled');

		if (curIndex == 0) $('.smallImgUp').addClass('disabled');

		if (curIndex == count-1) $('.smallImgDown').addClass('disabled');

		

		$("#imageMenu ul").stop(false, true).animate({"marginLeft" : -curIndex*interval + "px"}, 600);

	});	

	// 解决 ie6 select框 问题

	$.fn.decorateIframe = function(options) {

	    if ('undefined' == typeof(document.body.style.maxHeight)) {

            var opts = $.extend({}, $.fn.decorateIframe.defaults, options);

            $(this).each(function() {

                var $myThis = $(this);

                //创建一个IFRAME

                var divIframe = $("<iframe />");

                divIframe.attr("id", opts.iframeId);

                divIframe.css("position", "absolute");

                divIframe.css("display", "none");

                divIframe.css("display", "block");

                divIframe.css("z-index", opts.iframeZIndex);

                divIframe.css("border");

                divIframe.css("top", "0");

                divIframe.css("left", "0");

                if (opts.width == 0) {

                    divIframe.css("width", $myThis.width() + parseInt($myThis.css("padding")) * 2 + "px");

                }

                if (opts.height == 0) {

                    divIframe.css("height", $myThis.height() + parseInt($myThis.css("padding")) * 2 + "px");

                }

                divIframe.css("filter", "mask(color=#fff)");

                $myThis.append(divIframe);

            });

        }

    }

    $.fn.decorateIframe.defaults = {

        iframeId: "decorateIframe1",

        iframeZIndex: -1,

        width: 0,

        height: 0

    }

    //放大镜视窗

    //$("#bigView").decorateIframe();

    //点击到中图

    var midChangeHandler = null;

	

    $("#imageMenu li img").bind("click", function(){

		if ($(this).attr("id") != "onlickImg") {

			midChange($(this).attr("src"));

			$("#imageMenu li").removeAttr("id");

			$(this).parent().attr("id", "onlickImg");

		}

	}).bind("mouseover", function(){

		if ($(this).attr("id") != "onlickImg") {

			window.clearTimeout(midChangeHandler);

			midChange($(this).attr("src"));

			$(this).css({ "border": "3px solid #959595" });

			$("#vertical").show();

		}

	}).bind("mouseout", function(){

		if($(this).attr("id") != "onlickImg"){

			$(this).removeAttr("style");

			midChangeHandler = window.setTimeout(function(){

				midChange($("#onlickImg img").attr("src"));

			}, 1000);

			$("#vertical").show();

		}

	});

    function midChange(src) {

        $("#midimg").attr("src", src).load(function() {

            changeViewImg();

        });

    }

    //大视窗看图

    function mouseover(e) {

        if ($("#winSelector").css("display") == "none") {

            $("#winSelector,#bigView").show();

        }

        $("#winSelector").css(fixedPosition(e));

        e.stopPropagation();

    }

    function mouseOut(e) {

        if ($("#winSelector").css("display") != "none") {

            $("#winSelector,#bigView").hide();
           

        }

        e.stopPropagation();

    }

    $("#midimg").mouseover(mouseover); //中图事件

    $("#midimg,#winSelector").mousemove(mouseover).mouseout(mouseOut); //选择器事件

    $("#winSelector").click(function(){
    	$("#vertical").hide();
    });

    $("#vertical","#winSelector").mouseout(function(e){
    	e.stopPropagation();
    	$("#vertical").hide();
    });

    var $divWidth = $("#winSelector").width(); //选择器宽度

    var $divHeight = $("#winSelector").height(); //选择器高度

    var $imgWidth = $("#midimg").width(); //中图宽度

    var $imgHeight = $("#midimg").height(); //中图高度

    var $viewImgWidth = $viewImgHeight = $height = null; //IE加载后才能得到 大图宽度 大图高度 大图视窗高度



    function changeViewImg() {

        $("#bigView img").attr("src", $("#midimg").attr("src"));

    }

    changeViewImg();

    $("#bigView").scrollLeft(0).scrollTop(0);

    function fixedPosition(e) {

        if (e == null) {

            return;

        }

        var $imgLeft = $("#midimg").offset().left; //中图左边距

        var $imgTop = $("#midimg").offset().top; //中图上边距

        X = e.pageX - $imgLeft - $divWidth / 2; //selector顶点坐标 X

        Y = e.pageY - $imgTop - $divHeight / 2; //selector顶点坐标 Y

        X = X < 0 ? 0 : X;

        Y = Y < 0 ? 0 : Y;

        X = X + $divWidth > $imgWidth ? $imgWidth - $divWidth : X;

        Y = Y + $divHeight > $imgHeight ? $imgHeight - $divHeight : Y;



        if ($viewImgWidth == null) {

            $viewImgWidth = $("#bigView img").outerWidth();

            $viewImgHeight = $("#bigView img").height();

            if ($viewImgWidth < 200 || $viewImgHeight < 200) {

                $viewImgWidth = $viewImgHeight = 800;

            }

            $height = $divHeight * $viewImgHeight / $imgHeight;

            $("#bigView").width($divWidth * $viewImgWidth / $imgWidth);

            $("#bigView").height($height);

        }

        var scrollX = X * $viewImgWidth / $imgWidth;

        var scrollY = Y * $viewImgHeight / $imgHeight;

        $("#bigView img").css({ "left": scrollX * -1, "top": scrollY * -1 });

        $("#bigView").css({ "top": 75, "left": $(".preview").offset().left + $(".preview").width() + 15 });



        return { left: X, top: Y };

    }

});

/*DWREngine.setAsync = function(async) {
    DWREngine._async = async;
};*/

/*var pageNo = 0;
function ShowSameShops() {
	
	DWREngine.setAsync(false);
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
							imgstr = "其它";
						}else if(datalist[i].saletype == "2") {
							imgstr = "商城";
						}else {
							imgstr = "网店";
						}
					}
					if(datalist[i].zhuying != "") {
						imgstr += " | "+datalist[i].zhuying;
					}
					if(datalist[i].isyueru == "1") {
						imgstr += " | 月利润（"+datalist[i].yuemon+"）";
					}
					
					str += "<li "+listr+">";
            		str += "<i class=\"tjIco\"></i>";
	                str += "<div class=\"price\">￥<br/>"+datalist[i].csprice+"</div>";
	                str += "<div class=\"title\">";
	                str += "<p><a href=\"shopsGet-"+datalist[i].id+".html\" title=\""+datalist[i].spTitle+"\" target=\"_blank\">"+datalist[i].spTitle+"</a></p>";
	                //str += "<p>"+imgstr+"</p>";
	                str += "</div>";
	            	str += "</li>";
				}
				
				document.getElementById("ishopshow").innerHTML = str;

			 }else {
				 //str ="<div class=\"item\"><div>暂无相应同类店铺信息!</div></div>";
				 document.getElementById("isameshopdiv").style.display = "none";
			 }
		  }
	});
}
*/