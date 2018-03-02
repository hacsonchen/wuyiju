

$('#username').focus(function(){$('#usernameLabel').hide();}).blur(function(){if($('#username').val() == '')$('#usernameLabel').show();});
$('#password').focus(function(){$('#passwordLabel').hide();}).blur(function(){if($('#password').val() == '')$('#passwordLabel').show();});
$('#verify').focus(function(){$('#verifyLabel').hide();}).blur(function(){if($('#verify').val() == '')$('#verifyLabel').show();});
	

$(document).ready(function()
{
	$('#code').click(function()
	{
		var url = '/control.php/Login/verify/' + new Date().getTime();
		$('#code').attr('src', url);
	});

	$('.login_tab .tit li').click(function()
	{
		$('.login_tab').attr('class', 'login_tab tab_'+$(this).attr('class').substr(4, 1));
	});
	
});	


function checkLoginForm(form)
{
	with(form)
	{
		if(username.value == '')
		{
			alert(username.title);
			username.focus();
			return false;
		}
		if(password.value == '')
		{
			alert(password.title);
			password.focus();
			return false;
		}
		if(verify.value == '')
		{
			alert(verify.title);
			verify.focus();
			return false;
		}
	}
	return true;
}


function fEventListen(oElement, sName, fObserver, bUseCapture)
{
	bUseCapture = !!bUseCapture;
	if (oElement.addEventListener)
	{
		oElement.addEventListener(sName, fObserver, bUseCapture);
	}
	else if(oElement.attachEvent)
	{
		oElement.attachEvent('on' + sName, fObserver);
	}
}

//设置垂直居中
function fBodyVericalAlign()
{
	var nBodyHeight = 576;
	var nClientHeight = document.documentElement.clientHeight;
	if(nClientHeight >= nBodyHeight + 2)
	{
		var nDis = (nClientHeight - nBodyHeight)/2;
		document.body.style.paddingTop = nDis + 'px';
	}
	else
	{
		document.body.style.paddingTop = '0px';
	}
}
fBodyVericalAlign();
fEventListen(window,'resize',fBodyVericalAlign);