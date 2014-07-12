#include "base/HueSaturation.h"
#include "GlobalData.h"
#include "global/ColorSpace.h"

namespace TinyImage{



void	AdjustHueSaturation(TiBitmapData& bitmap,int hue,
							int saturation,int lightness,TINYIMAGE_HUERANGE hueRange)
{
	TINYIMAGE_ASSERT_VOID(hue >= -180 && hue <= 180);
	TINYIMAGE_ASSERT_VOID(saturation >= -100 && saturation <= 100);
	TINYIMAGE_ASSERT_VOID(lightness >= -100 && lightness <= 100);
	TINYIMAGE_ASSERT_VOID(hueRange >= 0 && hueRange <= 6);
	
	//计算变化量
	HueSaturation hueSaturation;
	HueSaturationParam param(hue,saturation,lightness,hueRange);
	CalculateTransfer(hueSaturation,param);

	//进行HueSaturation的变化
	AdjustHueSaturation(bitmap,hueSaturation);
	
}


void	CalculateTransfer(HueSaturation& hs,const HueSaturationParam& param)
{
	for (int i = (int)TINYIMAGE_HUERANGE_ALLHUES;i <= (int)TINYIMAGE_HUERANGE_MAGENTA; i++)
	{
		hs.m_hue[i]			= 0.0;
		hs.m_lightness[i]	= 0.0;
		hs.m_saturation[i]	= 0.0;
	}
	TINYIMAGE_HUERANGE hueRange	= param.m_range;
	hs.m_hue[hueRange]			= param.m_hue;
	hs.m_lightness[hueRange]	= param.m_lightness;
	hs.m_saturation[hueRange]	= param.m_saturation;
	hs.m_range					= hueRange;
	
	int value;

	for (int hue = 0; hue < 6; hue ++)
	{
		for (int i = 0; i < 256; i++)
		{
			//计算Hue Transfer
			value = (int)((hs.m_hue[0] + hs.m_hue[hue+1]) * 255 / 360.0 + i);
			if (value < 0)
			{
				value += 255;
			}
			else if (value >255)
			{
				value -= 255;
			}
			hs.m_hueTransfer[hue][i] = value;

			//计算Lightness Transfer
			value = (int)((hs.m_lightness[0] + hs.m_lightness[hue+1])* 127 / 100.0);
			value = CLAMP(value,-255,255);
			if (value < 0)
			{
				hs.m_lightnessTransfer[hue][i] = i + value * i / 255;
			}
			else
			{
				hs.m_lightnessTransfer[hue][i] = i + (255 - i)* value / 255;
			}

			//计算Saturation Transfer
			value = (int)((hs.m_saturation[0] + hs.m_saturation[hue+1])* 255 / 100.0);
			value = CLAMP(value,-255,255);
			hs.m_saturationTransfer[hue][i] = CLAMP0255(i + value * i / 255);
		}	
	}

}

void	AdjustHueSaturation(TiBitmapData& bitmap,const HueSaturation& hs)
{
	int width	= bitmap.GetWidth();
	int height	= bitmap.GetHeight();
	int stride	= bitmap.GetStride();
	int bpp		= bitmap.GetBpp();
	u8* bmpData	= bitmap.GetBmpData();
	int offset	= stride - width * bpp;
	const int hueThresholds[] =  { 21, 64, 106, 149, 192, 234, 255 };

	int r,g,b;
	int hue;

	for (int i = 0; i < height; i ++)
	{
		for (int j = 0; j < width; j++)
		{
			r = (int)bmpData[TiRed];
			g = (int)bmpData[TiGreen];
			b = (int)bmpData[TiBlue];


			Rgb2Hsl_Int(r,g,b);

			// 128 / 6 = 21;
			hue = (r + 21) / 6;
			for (int i = 0; i < 7; i++)
			{
				if (r < hueThresholds[i])
				{
					hue = i;
					break;
				}
			}
			if (hue >= 6)
			{
				hue = 0;
			}
		
			r = hs.m_hueTransfer[hue][r];
			g = hs.m_saturationTransfer[hue][g];
			b = hs.m_lightnessTransfer[hue][b];


			Hsl2Rgb_Int(r,g,b);


			bmpData[TiRed] = (u8)r;
			bmpData[TiGreen] = (u8)g;
			bmpData[TiBlue] = (u8)b;

			bmpData += bpp;
		}
		bmpData += offset;
	}
	
}




}