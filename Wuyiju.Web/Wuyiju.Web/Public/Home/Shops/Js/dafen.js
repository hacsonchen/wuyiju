
function trim(str) {
	return str.replace(/(^\s*)|(\s*$)/g, "");
}

function daFen(fval) {
	
	for(var i=1;i<=5;i++) {
		document.getElementById("ifen"+i).className = "empty";
	}

	var fen = parseInt(fval);	
	if(fen == 1) {
		document.getElementById("ifen1").className = "";
		document.getElementById("idaspan").innerHTML = "1分，还需努力！";
	}else {
		for(var i=1;i<=fen;i++) {
			document.getElementById("ifen"+i).className = "";
		}
		if(fen == 5) {
			document.getElementById("idaspan").innerHTML = "5分，非常满意！";
		}else if(fen == 4) {
			document.getElementById("idaspan").innerHTML = "4分，比较满意！";
		}else if(fen == 3) {
			document.getElementById("idaspan").innerHTML = "3分，基本满意！";
		}else if(fen == 2) {
			document.getElementById("idaspan").innerHTML = "2分，继续加油！";
		}
	}
	//
	document.getElementById("ipfen").value = fval;
}

function daFormCheck() {
	
	var fenVal = trim(document.getElementById("ipfen").value);
	if(fenVal == null || fenVal == "") {
		alert("温馨提示：请打分！");
		return false;
	}
	
	var strVal = trim(document.getElementById("ipstr").value);
	if(strVal.length > 100) {
		alert("温馨提示：评论内容不能超过100字哦！");
		return false;
	}
	
	return true;
}