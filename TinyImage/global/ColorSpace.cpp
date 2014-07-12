#include "ColorType.h"
#include "ColorSpace.h"

namespace TinyImage{

//HSL转RGB中间计算函数
static int hslValueInt(double n1, double n2, double hue) {
	double value;

	if (hue > 255) 
	{
		hue -= 255;
	} 
	else if (hue < 0) 
	{
		hue += 255;
	}

	if (hue < 42.5) 
	{
		value = n1 + (n2 - n1) * (hue / 42.5);
	} 
	else if (hue < 127.5) 
	{
		value = n2;
	}
	else if (hue < 170) 
	{
		value = n1 + (n2 - n1) * ((170 - hue) / 42.5);
	} 
	else 
	{
		value = n1;
	}

	return (int)ROUND(value * 255.0);
}



//RGB转HSL
void Rgb2Hsl(const TinyRGB *rgb, TinyHSL *hsl) 
{

	TINYIMAGE_ASSERT_VOID(rgb);
	TINYIMAGE_ASSERT_VOID(hsl);
	int r, g, b;
	double h, s, l; 
	int min, max;
	int delta;

	r = rgb->m_red;
	g = rgb->m_green;
	b = rgb->m_blue;

	if (r > g) 
	{
		max = MAX(r, b);
		min = MIN(g, b);
	} 
	else 
	{
		max = MAX(g, b);
		min = MIN(r, b);
	}

	l = (max + min) / 2.0;

	if (max == min) 
	{
		s = 0.0;
		h = 0.0;
	} 
	else 
	{
		delta = (max - min);

		if (l < 128) 
		{
			s = 255 * (double) delta / (double) (max + min);
		} 
		else 
		{
			s = 255 * (double) delta / (double) (511 - max - min);
		}

		if (r == max) 
		{
			h = (g - b) / (double) delta;
		} 
		else if (g == max) 
		{
			h = 2 + (b - r) / (double) delta;
		} 
		else 
		{
			h = 4 + (r - g) / (double) delta;
		}

		h = h * 42.5;

		if (h < 0) 
		{
			h += 255;
		} 
		else if (h > 255) 
		{
			h -= 255;
		}
	}

	hsl->m_hue = ROUND(h);
	hsl->m_lightness = l / 255.0;
	hsl->m_saturation = s / 255.0;
}

//RGB转HSL，只获取L
int Rgb2Hsl_L(u8 red,u8 green,u8 blue)
{
	int min, max;

	if (red > green) 
	{
		max = MAX(red, blue);
		min = MIN(green, blue);
	} 
	else 
	{
		max = MAX(green, blue);
		min = MIN(red, blue);
	}

	return(int)ROUND((max + min) / 2.0);
}


//RGB转HSL
void Hsl2Rgb(const TinyHSL *hsl, TinyRGB *rgb) 
{

	TINYIMAGE_ASSERT_VOID(rgb);
	TINYIMAGE_ASSERT_VOID(hsl);

	double h, s, l;
	double r, g, b;

	h = hsl->m_hue;
	s = hsl->m_saturation * 255;
	l = hsl->m_lightness * 255;

	if (s == 0) 
	{
		r  = l;
		g  = l;
		b = l;
	} 
	else 
	{
		double m1, m2;

		if (l < 128) 
		{
			m2 = (l * (255 + s)) / 65025.0;
		} 
		else 
		{
			m2 = (l + s - (l * s) / 255.0) / 255.0;
		}

		m1 = (l / 127.5) - m2;

		r = hslValueInt(m1, m2, h + 85);
		g = hslValueInt(m1, m2, h);
		b  = hslValueInt(m1, m2, h - 85);
	}
	rgb->m_red = (u8)ROUND(r);
	rgb->m_green = (u8)ROUND(g);
	rgb->m_blue = (u8)ROUND(b);
}


//RGB转HSL 参数都是[int,out]类型
//R返回Hue [0,360]，G返回Saturation[0,255]，B返回Lightness[0,255]
void Rgb2Hsl_Int (int& red,int& green, int& blue)
{
	int    r, g, b;
	double h, s, l;
	int    min, max;
	int    delta;

	r = red;
	g = green;
	b = blue;

	if (r > g)
	{
		max = MAX (r, b);
		min = MIN (g, b);
	}
	else
	{
		max = MAX (g, b);
		min = MIN (r, b);
	}

	l = (max + min) / 2.0;

	if (max == min)
	{
		s = 0.0;
		h = 0.0;
	}
	else
	{
		delta = (max - min);

		if (l < 128)
			s = 255 * (double) delta / (double) (max + min);
		else
			s = 255 * (double) delta / (double) (511 - max - min);

		if (r == max)
			h = (g - b) / (double) delta;
		else if (g == max)
			h = 2 + (b - r) / (double) delta;
		else
			h = 4 + (r - g) / (double) delta;

		h = h * 42.5;

		if (h < 0)
			h += 255;
		else if (h > 255)
			h -= 255;
	}

	red   = (int)ROUND (h);
	green = (int)ROUND (s);
	blue  = (int)ROUND (l);
}

//HSL转RGB 参数都是[int,out]类型
//hue返回R ，saturation返回G，lightness返回B
void Hsl2Rgb_Int (int& hue,int& saturation,int& lightness)
{
	double h, s, l;

	h = hue;
	s = saturation;
	l = lightness;

	if (s == 0)
	{
		hue        = lightness;
		lightness  = lightness;
		saturation = lightness;
	}
	else
	{
		double m1, m2;

		if (l < 128)
			m2 = (l * (255 + s)) / 65025.0;
		else
			m2 = (l + s - (l * s) / 255.0) / 255.0;

		m1 = (l / 127.5) - m2;

		hue        = hslValueInt (m1, m2, h + 85);
		saturation = hslValueInt (m1, m2, h);
		lightness  = hslValueInt (m1, m2, h - 85);
	}
}

}