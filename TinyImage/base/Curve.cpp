#include "base/Curve.h"
#include "global/ColorType.h"
#include "global/ColorSpace.h"

namespace TinyImage{



//指定通道曲线调整
void	AdjustCurve(TiBitmapData& bitmap,u8 (&lookup)[256],TINYIMAGE_CHANNEL channel)
{
	int width	= bitmap.GetWidth();
	int height	= bitmap.GetHeight();
	int stride	= bitmap.GetStride();
	int bpp		= bitmap.GetBpp();
	u8* bmpData	= bitmap.GetBmpData();
	int offset	= stride - width * bpp;

	switch (channel)
	{
	case TINYIMAGE_CHANEL_R:
		{
			for (int i = 0; i < height; i ++)
			{
				for (int j = 0; j < width; j++)
				{
					bmpData[TiRed] = lookup[bmpData[TiRed]];
					bmpData += bpp;
				}
				bmpData += offset;
			}
			break;
		}
	case TINYIMAGE_CHANEL_G:
		{
			for (int i = 0; i < height; i ++)
			{
				for (int j = 0; j < width; j++)
				{
					bmpData[TiGreen] = lookup[bmpData[TiGreen]];
					bmpData += bpp;
				}
				bmpData += offset;
			}
			break;
		}
	case TINYIMAGE_CHANEL_B:
		{
			for (int i = 0; i < height; i ++)
			{
				for (int j = 0; j < width; j++)
				{
					bmpData[TiBlue] = lookup[bmpData[TiBlue]];
					bmpData += bpp;
				}
				bmpData += offset;
			}
			break;
		}
	case TINYIMAGE_CHANEL_RGB:
		{
			for (int i = 0; i < height; i ++)
			{
				for (int j = 0; j < width; j++)
				{
					bmpData[TiRed] = lookup[bmpData[TiRed]];
					bmpData[TiGreen] = lookup[bmpData[TiGreen]];
					bmpData[TiBlue] = lookup[bmpData[TiBlue]];
					bmpData += bpp;
				}
				bmpData += offset;
			}
			break;
		}
	default:
		{
			assert(false);
			break;
		}
	}

}

//RGB通道曲线调整
void	AdjustCurve(TiBitmapData& bitmap,u8 (&r_lookup)[256],u8 (&g_lookup)[256],u8 (&b_lookup)[256])
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
			bmpData[TiRed] = r_lookup[bmpData[TiRed]];
			bmpData[TiGreen] = g_lookup[bmpData[TiGreen]];
			bmpData[TiBlue] = b_lookup[bmpData[TiBlue]];
			bmpData += bpp;
		}
		bmpData += offset;

	}
}


void PreserveLuminosityAdjustCurve(TiBitmapData& bitmap,u8 (&r_lookup)[256],u8 (&g_lookup)[256],u8 (&b_lookup)[256])
{
	int width	= bitmap.GetWidth();
	int height	= bitmap.GetHeight();
	int stride	= bitmap.GetStride();
	int bpp		= bitmap.GetBpp();
	u8* bmpData	= bitmap.GetBmpData();
	int offset	= stride - width * bpp;
	int r,g,b;
	int rlookup,glookup,blookup;


	for (int i = 0; i < height; i ++)
	{
		for (int j = 0; j < width; j++)
		{
			r = (int)bmpData[TiRed];
			g = (int)bmpData[TiGreen];
			b = (int)bmpData[TiBlue];

			rlookup = (int)r_lookup[r];
			glookup = (int)g_lookup[g];
			blookup = (int)b_lookup[b];

			Rgb2Hsl_Int(rlookup,glookup,blookup);
			blookup = Rgb2Hsl_L(r,g,b);
			Hsl2Rgb_Int(rlookup,glookup,blookup);


			bmpData[TiRed] = (u8)rlookup;
			bmpData[TiGreen] = (u8)glookup;
			bmpData[TiBlue] = (u8)blookup;
			bmpData += bpp;
		}
		bmpData += offset;
	}
}





}