#include "base/Curve.h"
#include "filter/Invert.h"
namespace TinyImage{

void	Invert(TiBitmapData& bitmap)
{
	u8 lookup[256];
	for (int i = 0; i < 256; i++)
	{
		lookup[i] = 255 - i;
	}

	AdjustCurve(bitmap,lookup,TINYIMAGE_CHANEL_RGB);
}

}