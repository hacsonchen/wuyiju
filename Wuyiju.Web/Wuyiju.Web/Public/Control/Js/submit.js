$(document).ready(function()
{
	$('#submit_btn').click(function()
	{
		/*if($('#modify').attr('f') == 'p')
		{
			var flag = 1;
			//alert($('#modify').attr('f'));
			$('table td span').each(function()
			{
				if($(this).attr('d') == '0')
				{
					flag = 0;
				}
			});
			if(flag == 1)
			{
				//$('#modify').submit();
			}
		}
		else
		{*/
			$('#modify').submit();
		//}
	});
	$('#seach').click(function()
	{
		$('#modify').submit();
	
	});
	$('#submit_btn1').click(function()
	{
		$('#modify1').submit();
	});
	$('#submit_btn2').click(function()
	{
		$('#modify2').submit();
	});
	$('#submit_btn3').click(function()
	{
		$('#modify3').submit();
	});
	$('#submit_btn4').click(function()
	{
		$('#modify4').submit();
	});

    $(document).on('click', 'span.status', function()
    {
        var span = $(this);
        $.get(url, {'id':span.attr('data'), 'db':span.attr('db')}, function(data)
        {
            if(data == 1)
            {
                span.find('img').attr('src', '/Public/Control/Img/yes.gif').attr('title', yes).attr('alt', yes);
            }
            if(data == 2)
            {
                span.find('img').attr('src', '/Public/Control/Img/no.gif').attr('title', no).attr('alt', no);
            }
        });
    });
});