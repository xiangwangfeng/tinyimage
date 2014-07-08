#include "base/Brightness.h"
#include "base/Curve.h"
#include <cmath>


namespace TinyImage{

void	AdjustBrightness(TiBitmapData& bitmap,double level)
{
	TINYIMAGE_ASSERT_VOID(level >= -1.0 && level <= 1.0);

	double delta = level + 1;
	u8 lookup[256] = {0};
	for (int i = 0; i < 256; i ++)
	{
		lookup[i] = (u8)CLAMP0255(i * delta);
	}
	AdjustCurve(bitmap,lookup,TINYIMAGE_CHANEL_RGB);
}

}