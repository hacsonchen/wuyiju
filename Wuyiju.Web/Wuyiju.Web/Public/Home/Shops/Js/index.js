
function daover(bh,sg) {
    $("#div_"+bh+"_1").hide();
    $("#div_"+bh+"_2").hide();
    $("#dd_"+bh+"_"+sg).addClass("cur").siblings().removeClass("cur");
    $("#div_"+bh+"_"+sg).show();
}

function showDownMenu() {
    var timer = null;
    $('#allNav').click(function() {
        clearInterval(timer);
        $('#downMenuList').show();
    });
    $('#allNav').mouseleave(function() {
        clearInterval(timer);
        timer = setInterval("$('#downMenuList').hide()",30);
    });
    $('#downMenuList, .YinCang').hover(function() {
        clearInterval(timer);
    }, function(){
        timer = setInterval("$('#downMenuList').hide()",30);
    });
}



function zxshow(sg)
{
	if(sg == "2") {
		document.getElementById("izxli").className="cur";
		document.getElementById("iggli").className="";
		document.getElementById("ihyzxs").style.display="";
		document.getElementById("iwzggs").style.display="none";
	}else {
		document.getElementById("iggli").className="cur";
		document.getElementById("izxli").className="";
		document.getElementById("iwzggs").style.display="";
		document.getElementById("ihyzxs").style.display="none";
	}
}

//(拍卖)点击小图切换大图:
function pmEpt(mid,mimg) {

	$("div.picList ul li").removeClass("cur");
	document.getElementById("ipmli"+mid).className="cur";
    document.getElementById("ipmdatu").src = pmpicpath+mimg;
}

function tnumshow(sg)
{
	//今日,昨日,当月,当年,所有:
	var tndate = document.getElementById("itndate").value;

	if(tndate == "今日预计") {
		if(sg == "2") { //上:
			document.getElementById("itndate").value = "昨日预计";
			$("div.Today-YJ ul").hide();
			$("#itnul2").show();
		}else { //下:
			//no;
		}
	}else if(tndate == "昨日预计") {
		if(sg == "2") {
			document.getElementById("itndate").value = "当月预计";
			$("div.Today-YJ ul").hide();
			$("#itnul3").show();
		}else {
			document.getElementById("itndate").value = "今日预计";
			$("div.Today-YJ ul").hide();
			$("#itnul1").show();
		}
	}else if(tndate == "当月预计") {
		if(sg == "2") {
			document.getElementById("itndate").value = "当年预计";
			$("div.Today-YJ ul").hide();
			$("#itnul4").show();
		}else {
			document.getElementById("itndate").value = "昨日预计";
			$("div.Today-YJ ul").hide();
			$("#itnul2").show();
		}
	}else if(tndate == "当年预计") {
		if(sg == "2") {
			document.getElementById("itndate").value = "所有预计";
			$("div.Today-YJ ul").hide();
			$("#itnul5").show();
		}else {
			document.getElementById("itndate").value = "当月预计";
			$("div.Today-YJ ul").hide();
			$("#itnul3").show();
		}
	}else if(tndate == "所有预计") {
		if(sg == "2") {
			//no;
		}else {
			document.getElementById("itndate").value = "当年预计";
			$("div.Today-YJ ul").hide();
			$("#itnul4").show();
		}
	}
}


//菜单
function daover(bh,sg) {
	$("#div_"+bh+"_1").hide();
	$("#div_"+bh+"_2").hide();
	$("#dd_"+bh+"_"+sg).addClass("cur").siblings().removeClass("cur");
	$("#div_"+bh+"_"+sg).show();
}

function scrollBann2() {
    var iSpeed = 0;
    var timer = null;
    var imgList = $('#b2_in_list');
    //imgList.html(imgList.html() + imgList.html());
    var imgListLi = $('#b2_in_list li a');
    imgList.width((imgListLi.width()+5)*imgListLi.length);

    function doMove(){
        imgList.animate({"margin-left":iSpeed+'px'},600);
        iSpeed -= imgListLi.width()+5;
        if(iSpeed < -(imgListLi.width()+5)) {
            //iSpeed = -(imgListLi.width()+5);
            iSpeed = 0;
        };
    };
    function startMove(){
        doMove();
        timer = setInterval(doMove,5000);
    };
    function stopMove(){
        clearInterval(timer);   
    };
    imgList.parent().hover(function (){
        stopMove(); 
    }, function (){
        startMove();
    });
    startMove();
}


$(document).ready(function(){
	var $txt = $("#txt-valid-qq");
	$("#btn-valid-qq").click(function(){
		var qq = $.trim($txt.val());
		if( qq == '')
			layer.alert('请输入正确的QQ号');

		$.ajax({
			url:'/Malls/ValidQQ.aspx',
			type:'POST',
			data:{ qq:qq},
			success:function(data){
				if(data == 'true'){
					layer.alert('已验证QQ'+ qq +' 是本网站客服号码！');
				}
					else{
						layer.alert(data);
					}
				}
			
		});

	});

	$('#btn-like').click(function(){
		var $num = $('#like-count');
		$num.text(parseInt($num.text()) + 1);
		layer.alert('已赞，谢谢支持！');
		
	});

});

