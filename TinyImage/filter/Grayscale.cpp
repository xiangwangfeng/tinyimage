#include "filter/Grayscale.h"
#include "global/ColorType.h"

namespace TinyImage{

void	GrayScale(TiBitmapData& bitmap)
{
	int width	= bitmap.GetWidth();
	int height	= bitmap.GetHeight();
	int stride	= bitmap.GetStride();
	int bpp		= bitmap.GetBpp();
	u8* bmpData	= bitmap.GetBmpData();
	int offset	= stride - width * bpp;

	for (int i = 0; i < height; i ++)
	{
		for (int j = 0; j < width; j++)
		{
			bmpData[TiRed] = 
			bmpData[TiGreen] = 
			bmpData[TiBlue] = 
			((TinyRGB*)bmpData)->getLuminance();
			bmpData += bpp;
		}
		bmpData += offset;
	}
	
}

}