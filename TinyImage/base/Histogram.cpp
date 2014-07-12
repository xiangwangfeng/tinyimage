#include "global/ColorType.h"
#include "base/Histogram.h"
#include <cstring>
namespace TinyImage{


TiHistogram*	GetImageHistogram(TiBitmapData& bitmap)
{
	int width	= bitmap.GetWidth();
	int height	= bitmap.GetHeight();
	int stride	= bitmap.GetStride();
	int bpp		= bitmap.GetBpp();
	u8* bmpData	= bitmap.GetBmpData();
	int offset	= stride - width * bpp;
	TiHistogram* histogram = new TiHistogram();
	memset(histogram,0,sizeof(TiHistogram));

	for (int i = 0; i < height; i ++)
	{
		for (int j = 0; j < width; j++)
		{
			histogram->rValues[bmpData[TiRed]] ++;
			histogram->gValues[bmpData[TiGreen]] ++;
			histogram->bValues[bmpData[TiBlue]] ++;
			histogram->rgbValues[((TinyRGB*)bmpData)->getLuminance()] ++;
			bmpData += bpp;
		}
		bmpData += offset;
	}

	return histogram;
	
}

}