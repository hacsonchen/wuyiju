$(document).ready(function()
{
	$('#lang').change(function()
	{
		$.get('/control.php/Index/lang',{'lang':$(this).val()},function(data)
		{
			if(data)
			{
				window.location.href = '/control.php/Index/head';
			}
		});
	});
});