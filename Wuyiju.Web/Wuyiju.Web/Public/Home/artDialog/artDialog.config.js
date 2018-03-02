function showLogin() {
	var title   = '欢迎登录';
	var content = $.ajax({url:'/Public/Home/showlogin.html', async:false}).responseText;
	win = art.dialog({
		lock	: true,
		fixed	: true,
		border	: false,
		title	: title,
		content : content
	});
}


function showLoginCheck() {
	with(document.getElementById('showLogin')) {
		if(username.value == '') {
			alert('请输入您的用户名！');
			username.focus();
			return false;
		}

		if(password.value == '') {
			alert('请输入您的密码！');
			password.focus();
			return false;
		}
	}
	return true;
}

function showLoginSubmit() {
	var data = $.ajax({url:'/user/ajaxLogin.html', data:{username:$('#username').val(), password:$('#password').val()}, async:false}).responseText;
	if(data > 0) {
		win.close();
	} else if(data == -1) {
		alert('用户或密码不正确！');
	} else {
		alert('提交有误！');
	}
}

$(function(){
	$('#showLogin').live('submit', function(){
		if(showLoginCheck()) {
			showLoginSubmit();
		}
		return false;
	});
});

/* 星期一新增 * 开始 */
function checkLogin() {
	var data = $.ajax({url:'/user/ajaxCheckLogin.html', async:false}).responseText;
	if(data > 0) {
		return true;
	} else {
		return false;
	}
}
/* 星期一新增 * 结束 */

function ajaxPage(url) {
	return $.ajax({url:url, async:false}).responseText;
}


/* 上传图片 * 开始 */
function showProjectImageUploadForm(id) {
	if(!checkLogin()) {
		showLogin();
		return false;
	}
	w = art.dialog.open('/Public/Home/Shops/showProjectImageUploadForm.html', {
		title	: '上传图片',
		ok		: function () {
			var iframe = this.iframe.contentWindow;
			if(!iframe.document.body) {
				alert('内容加载中，请稍候......')
				return false;
			};

			var submit = iframe.document.getElementById('submit');
			var image  = iframe.document.getElementById('image')
			if(image.value == '') {
				alert('请选择封面图片');
				image.focus();
			}else{
				submit.click();
				art.dialog.data('upload', '');
				t = setInterval("showProjectImageUploadFormData('"+id+"')", 500);
			}
			return false;
		},
		cancel	: true
	});
}
function showProjectImageUploadFormData(id) {
	if(art.dialog.data('upload')){
		w.close();
		clearInterval(t);
		var v = art.dialog.data('upload');
		if(v == 0) {
			alert('对不起，图片上传失败！');
		} else {
			document.getElementById(id).value = v;
			$('#'+id+'img').html('<img src="'+v+'" width="100%" height="100%" />')
		}
	}
}
/* 上传图片 * 结束 */