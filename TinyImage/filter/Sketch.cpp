#include "filter/Sketch.h"
#include "filter/Grayscale.h"
#include "filter/GaussBlur.h"
#include "filter/Invert.h"
#include "base/BlendMode.h"



namespace TinyImage{

void	Sketch(TiBitmapData& bitmap)
{
	//灰度化原图
	GrayScale(bitmap);

	//拷贝灰度化后的原图并反向
	TiBitmapData* clone = bitmap.Clone();
	Invert(*clone);

	//对拷贝图做高斯模糊
	GaussianBlur(*clone,22);



	//颜色减淡
	BlendMode(bitmap,TINYIMAGE_CHANEL_RGB,*clone,TINYIMAGE_CHANEL_RGB,
			  TINYIMAGE_BLENDMODE_COLORDODGE,1.0);

	delete clone;
}

}