/**
 * @file    ColorType.h
 * @brief   颜色类型
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2010-12
 * @website www.xiangwangfeng.com
 */


#pragma once
#include "GlobalData.h"

namespace TinyImage{

//灰度转换因子
const double RGB_LUMINANCE_RED = 0.2126;
const double RGB_LUMINANCE_GREEN = 0.7152;
const double RGB_LUMINANCE_BLUE = 0.0722;

#define RGB_LUMINANCE(r,g,b) ((r) * RGB_LUMINANCE_RED   + \
	(g) * RGB_LUMINANCE_GREEN + \
	(b) * RGB_LUMINANCE_BLUE)





//RGBA
struct TinyRGBA {
public:
	TinyRGBA()
	{
		
	}
	//得到灰度值
	u8 getLuminance() const {
		u8 luminance = (u8)ROUND(RGB_LUMINANCE(m_red, m_green, m_blue));
		return CLAMP0255(luminance);
	}

	u8 m_blue;	//蓝色
	u8 m_green;	//绿色
	u8 m_red;	//红色
	u8 m_alpha;	//Alpha通道
};

//RGB
struct TinyRGB 
{
	public:
		TinyRGB(u8 red,u8 green,u8 blue)
		{
			m_blue = blue;
			m_green= green;
			m_red = red;
		}
		//得到灰度值	
		u8 getLuminance() const {
			u8 luminance = (u8)ROUND(RGB_LUMINANCE(m_red, m_green, m_blue));
			return CLAMP0255(luminance);
		}

		u8 m_blue;	/** 蓝 */
		u8 m_green;	/** 绿 */
		u8 m_red;	/** 红 */
};


//HSL
struct TinyHSL 
{
	int m_hue;				//色相   [0,360]
	double m_saturation;	//饱和度 [0,1]
	double m_lightness;		//亮度   [0,1]
};

}