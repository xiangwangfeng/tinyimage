#include "global/ColorType.h"
#include "base/NormalBlend.h"
namespace TinyImage{

u8	FastScaleByteByByte(u8 a, u8 b) 
{
	u32 r1 = a * b + 0x80;
	u32 r2 = ((r1 >> 8) + r1) >> 8;
	return (u8)r2;
}

void	Blend(const TinyRGB* bgColor,u8 bgColorAlpha, const TinyRGBA* fgColor, TinyRGB* dstColor, u8 coverAlpha) 
{
	assert(bgColor);
	assert(fgColor);
	assert(dstColor);

	u32 bgAlpha, fgAlpha, mixAlpha, r, g, b;

	bgAlpha = (u32)FastScaleByteByByte((u8)(255 - coverAlpha), 255);
	fgAlpha = (u32)FastScaleByteByByte(coverAlpha, fgColor->m_alpha);
	mixAlpha = bgAlpha + fgAlpha;

	if (0 == mixAlpha) 
	{
		r = 0;
		g = 0;
		b = 0;
	}
	else 
	{
		r = ((bgColor->m_red * bgAlpha) + (fgColor->m_red * fgAlpha)) / mixAlpha;
		g = ((bgColor->m_green * bgAlpha) + (fgColor->m_green * fgAlpha)) / mixAlpha;
		b = ((bgColor->m_blue * bgAlpha) + (fgColor->m_blue * fgAlpha)) / mixAlpha;
	}

	dstColor->m_blue = (u8)b;
	dstColor->m_green = (u8)g;
	dstColor->m_red = (u8)r;
}


void	BlendLayerMask(TiBitmapData& bitmap, TinyRGBA *mask,int maskX, int maskY, int maskWidth, int maskHeight, u8 maskAlpha) 
{
	u8* bmpData	= bitmap.GetBmpData();
	int bpp		= bitmap.GetBpp();
	int width	= bitmap.GetWidth();
	int height	= bitmap.GetHeight();
	int stride	= bitmap.GetStride();


	TINYIMAGE_ASSERT_VOID(mask);
	TINYIMAGE_ASSERT_VOID(maskX >= 0 && maskX + maskWidth <= width);
	TINYIMAGE_ASSERT_VOID(maskY >= 0 && maskY + maskHeight <= height);


	// ÃÉ°åÍ¼ÐèÒªÉ¨ÃèµÄ·¶Î§
	int maskStartX	= 0;
	int maskStartY	= 0;


	//BitmapÉ¨ÃèµÄ·¶Î§
	int startY	= maskY;
	int endY	= maskY + maskHeight;
	int startX	= maskX;
	int endX	= maskX + maskWidth;

	for (int j = startY; j < endY; j ++)
	{
		int maskj = j - startY;
		int i = startX;
		u8* bmpData = bitmap.GetPixel(i,j);
		for (; i < endX; i++)
		{
			int maski = i - startX;
			TinyRGBA* layerMaskColor = mask +(maski + maskStartX)
				+(maskj + maskStartY) * maskWidth;

			Blend((TinyRGB*)bmpData,255,layerMaskColor,(TinyRGB*)bmpData,maskAlpha);

			bmpData += bpp;
		}
	}

}



}