function searchSbt(cate_id) {
	
	var spn = document.getElementById("searid").value;
	if( spn == "") {
		spn = "";
		document.getElementById("searid").value = "";
		return false;
	}
	else
	{
		window.open("/mall/taobao/sort/" + cate_id +"-0-0-0-0-0-0-"+spn+".html",'','');
	}
	
}