$(document).ready(function()
{
	$('.child').click(function()
	{
		$('span.child').not($(this)).attr('data', 'off');
		$('span.child').not($(this)).next('dl').slideUp();
		$('span.child').not($(this)).prev('b.tit').html('+');
		if($(this).attr('data') == 'on')
		{
			$(this).next('dl').slideUp();
			$(this).attr('data', 'off');
			$(this).parent('li').find('b.tit').html('+');
		}
		else
		{
			$(this).next('dl').slideDown();
			$(this).attr('data', 'on');
			$(this).parent('li').find('b.tit').html('-');
		}
	});
	$('ul li a').click(function()
	{
		$('a.lefton').removeClass('lefton');
		$(this).addClass('lefton');
	});
});

function hideFrameLeft(){
	window.top.document.getElementById('FrameLeftMain').cols='9,*';
	window.top.FrameLeft.document.getElementById('btnlefthide').style.display = 'none';
	window.top.FrameLeft.document.getElementById('btnleftshow').style.display = 'block';
}

function showFrameLeft(){
	window.top.document.getElementById('FrameLeftMain').cols='248,*';
	window.top.FrameLeft.document.getElementById('btnlefthide').style.display = 'block';
	window.top.FrameLeft.document.getElementById('btnleftshow').style.display = 'none';
}