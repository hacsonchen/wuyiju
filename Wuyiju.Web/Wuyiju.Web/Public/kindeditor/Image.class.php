<?php
/**
 * 图像处理类
*/
class Image
{
	/**
	 * 加盖图片水印
	 * @param  [String] $img   [图片路径]
	 * @param  [String] $water [水印图路径]
	 * @param  [String] $save  [保存路径|留空则替换原图]
	 * @return [Boolean]
	 */
	static public function water($img, $water = '', $pos = 9,$save = NULL)
	{
		//初始化参数(放进框架时把常量换成 读取配置文件项 )
		if(empty($water)) return false;
		
		$alpha = 100;
		$compression = 80;

		if (!file_exists($water)) return false;

		//原图宽、高与类型
		$imgInfo = getimagesize($img);
		$imgW = $imgInfo[0];
		$imgH = $imgInfo[1];
		$imgT = self::getImageType($imgInfo[2]);

		//水印图宽、高与类型
		$waterInfo = getimagesize($water);
		$waterW = $waterInfo[0];
		$waterH = $waterInfo[1];
		$waterT = self::getImageType($waterInfo[2]);

		//水印图大于原图时不作处理
		if ($imgW < $waterW || $imgH < $waterH) return false;

		//计算水印位置
		$pos = self::getPosition($imgW, $imgH, $waterW, $waterH, $pos);
		$x = $pos['x'];
		$y = $pos['y'];

		//打开原图资源
		$fn = 'imagecreatefrom' . $imgT;
		$image = $fn($img);

		//打开水印图资源
		$fn = 'imagecreatefrom' . $waterT;
		$water = $fn($water);

		//盖上水印图
		if ($waterT == 'png') {
			imagecopy($image, $water, $x, $y, 0, 0, $waterW, $waterH);
		} else {
			imagecopymerge($image, $water, $x, $y, 0, 0, $waterW, $waterH, $alpha);
		}

		//保存路径
		$save = self::savePath($save, $img);
		$fn = 'image' . $imgT;
		if ($imgT == 'jpeg') {
			$fn($image, $save, $compression);
		} else {
			$fn($image, $save);
		}

		//释放资源
		imagedestroy($image);
		imagedestroy($water);
		return true;
	}





	/**
	 * 图片保存路径
	 * @param  [String] $save [保存路径]
	 * @param  [String] $img  [原图路径]
	 * @return [String]
	 */
	Static Private function savePath ($save, $img) {
		if (!$save) return $img;

		$pathInfo = pathinfo($img);
		$path = rtrim($save, '/') . '/';
		is_dir($path) || mkdir($path, 0777, true);
		return $path . time() . mt_rand(1000, 9999) . '.' . $pathInfo['extension'];
	}

	/**
	 * 计算水印图位置
	 * @param  [Integer] $IW  [原图宽]
	 * @param  [Integer] $IH  [原图高]
	 * @param  [Integer] $WW  [水印宽]
	 * @param  [Integer] $WH  [水印高]
	 * @param  [Integer] $pos [九宫格位置]
	 * @return [Array]      [x, y]
	 */
	Static Private function getPosition ($IW, $IH, $WW, $WH, $pos) {
		$x = 20;
		$y = 20;
		switch ($pos) {
			case 1 :
				break;

			case 2 :
				$x = ($IW - $WW) / 2;
				break;

			case 3 :
				$x = $IW - $WW - 20;
				break;

			case 4 :
				$y = ($IH - $WH) / 2;
				break;

			case 5 :
				$x = ($IW - $WW) / 2;
				$y = ($IH - $WH) / 2;
				break;

			case 6 :
				$x = $IW - $WW - 20;
				$y = ($IH - $WH) / 2;
				break;

			case 7 :
				$y = $IH - $WH - 20;
				break;

			case 8 :
				$x = ($IW - $WW) / 2;
				$y = $IH - $WH - 20;
				break;

			case 9 :
				$x = $IW - $WW - 20;
				$y = $IH - $WH - 20;
				break;

			default :
				$x = mt_rand(0, $IW - $WW);
				$y = mt_rand(0, $IH - $WH);
		}

		return array('x' => $x, 'y' => $y);
	}

	/**
	 * 图片类型
	 * @param  [Integer] $typeNum [类型识别号]
	 * @return [String]
	 */
	Static Private function getImageType ($typeNum) {
		switch($typeNum) {
			case 1 :
				return 'gif';
			case 2 :
				return 'jpeg';
			case 3 :
				return 'png';
		}
	}

	/**
	 * 16进制色值转换为RGB
	 * @param  [Sting] $color [16进制色值]
	 * @return [Array]        [red, green, blue]
	 */
	Static Private function colorTrans($color) {
		$color = ltrim($color, '#');
		return array(
			'red' => hexdec($color[0] . $color[1]),
			'green' => hexdec($color[2] . $color[3]),
			'blue' => hexdec($color[4] . $color[5])
			);
	}
}
?>