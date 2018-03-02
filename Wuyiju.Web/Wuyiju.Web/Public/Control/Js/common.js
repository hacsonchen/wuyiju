function redirect(url) {
	location.href = url;
}

/**
 * 全选checkbox,注意：标识checkbox id固定为为check_box
 * @param string name 列表check名称,如 uid[]
 */
function selectall(name) 
{

	var flag = $("#check_box").is(":checked"); 
	
	$("input[name='"+name+"']").each(function(i, e) 
	{
		$(e).prop('checked', flag);
	});
}

