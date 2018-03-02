<?php
	$htmlData = '';
	if (!empty($_POST['txtsummary_en'])) {
		$htmlData = stripslashes($_POST['txtsummary_en']);
	}
?>
<!doctype html>
<html>
<head>
	<meta charset="utf-8" />
	<title>KindEditor PHP</title>
	<script type="text/javascript" src="jquery-1.8.3.min.js"></script>
	<link rel="stylesheet" href="themes/default/default.css" />
	<link rel="stylesheet" href="plugins/code/prettify.css" />
	<script charset="utf-8" src="kindeditor.js"></script>
	<script charset="utf-8" src="lang/zh_CN.js"></script>
	<script charset="utf-8" src="plugins/code/prettify.js"></script>
	<script>
		$(document).ready(function() {
			KindEditor.create('textarea[name="txtsummary_en"]');
			prettyPrint();
		});
	</script>
</head>
<body>
	<?php echo $htmlData;?>
	<form name="example" method="post" action="demo.php">
		<textarea name="txtsummary_en" style="width:700px;height:200px;visibility:hidden;"><?php echo htmlspecialchars($htmlData); ?></textarea>
		<br />
		<input type="submit" name="button" value="提交内容" />
	</form>
</body>
</html>

