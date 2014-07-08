#include "base/Constrast.h"
#include "base/Curve.h"

#define CONSTTHRESHOLD 

namespace TinyImage{

void	AdjustContrast(TiBitmapData& bitmap,double level)
{

#ifdef CONSTTHRESHOLD
	AdjustContrastUsingConstThreshold(bitmap,level);
#else
	AdjustContrastUsingAverageThreshold(bitmap,level);
#endif
}

void	AdjustContrastUsingConstThreshold(TiBitmapData& bitmap,double level)
{

	TINYIMAGE_ASSERT_VOID(level >= -1.0 && level <= 1.0);
	
	u8 lookup[256];
	double delta		= 1 + level;
	const int threshold = 0x7F;//128 可以认为是平均亮度
	
	for (int i = 0; i < 256; i++)
	{
		lookup[i] = (u8)CLAMP0255(threshold + (i - threshold)* delta);
	}

	AdjustCurve(bitmap,lookup,TINYIMAGE_CHANEL_RGB);
}

void	AdjustContrastUsingAverageThreshold(TiBitmapData& bitmap,double level)
{

	TINYIMAGE_ASSERT_VOID(level >= -1.0 && level <= 1.0);

	double rThresholdSum = 0,gThresholdSum = 0,bThresholdSum = 0;
	double detal= level + 1;
	int width	= bitmap.GetWidth();
	int height	= bitmap.GetHeight();
	int stride	= bitmap.GetStride();
	int bpp		= bitmap.GetBpp();
	u8* bmpData	= bitmap.GetBmpData();
	int offset	= stride - width * bpp;
	long pixels = bitmap.GetTotalPixels();

	for (int i = 0; i < height; i ++)
	{
		for (int j = 0; j < width; j++)
		{
			rThresholdSum += bmpData[TiRed];
			gThresholdSum += bmpData[TiGreen];
			bThresholdSum += bmpData[TiBlue];
			bmpData += bpp;
		}
		bmpData += offset;
	}

	int rThreshold = (int)(rThresholdSum/pixels);
	int gThreshold = (int)(gThresholdSum/pixels);
	int bThreshold = (int)(bThresholdSum/pixels);

	u8 r_lookup[256],g_lookup[256],b_lookup[256];

	for (int i = 0; i < 256; i++)
	{
		r_lookup[i] = (u8)CLAMP0255(rThreshold + (i - rThreshold)* detal);
		g_lookup[i] = (u8)CLAMP0255(gThreshold + (i - gThreshold)* detal);
		b_lookup[i] = (u8)CLAMP0255(bThreshold + (i - bThreshold)* detal);
	}

	AdjustCurve(bitmap,r_lookup,g_lookup,b_lookup);
}

}