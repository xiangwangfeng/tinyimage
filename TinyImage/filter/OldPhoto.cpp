#include "filter/Grayscale.h"
#include "base/ColorBalance.h"


namespace TinyImage{

void	OldPhoto(TiBitmapData& bitmap)
{
	//灰度化
	GrayScale(bitmap);

	//添加红色通道 减少蓝色通道 使得图片泛黄
	BalanceColor(bitmap,34,0,-87,TINYIMAGE_TRANSFERMODE_MIDTONES,false);
	
}

}