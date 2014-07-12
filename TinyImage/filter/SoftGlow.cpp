#include "base/Brightness.h"
#include "base/BlendMode.h"
#include "filter/GaussBlur.h"
#include "filter/SoftGlow.h"

namespace TinyImage{

void	SoftGlow(TiBitmapData& bitmap)
{
	TiBitmapData* clone = bitmap.Clone();

	//高斯模糊
	GaussianBlur(*clone,5);
	
	//底层图层少许调整亮度
	AdjustBrightness(bitmap,0.05);

	//两个图层做滤色混合
	BlendMode(bitmap,TINYIMAGE_CHANEL_RGB,*clone,TINYIMAGE_CHANEL_RGB,
			   TINYIMAGE_BLENDMODE_SCREEN,1);

	delete clone;
}

}