/**
 * @file    HueSaturation.h
 * @brief   色相/饱和度
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2011-1
 * @website www.xiangwangfeng.com
 */


#pragma once
#include "global/BitmapData.h"

namespace TinyImage{

struct HueSaturation
{
	double m_hue[7];
	double m_lightness[7];
	double m_saturation[7];

	int    m_hueTransfer[6][256];
	int    m_lightnessTransfer[6][256];
	int    m_saturationTransfer[6][256];

	TINYIMAGE_HUERANGE m_range;
};

struct HueSaturationParam
{
	explicit HueSaturationParam(int hue,int saturaton,int lightness,
								TINYIMAGE_HUERANGE range)
	{
		m_hue		= hue;
		m_lightness	= lightness;
		m_saturation= saturaton;
		m_range		= range;
	}
	int m_hue;
	int m_saturation;
	int m_lightness;
	TINYIMAGE_HUERANGE m_range;
};


void	AdjustHueSaturation(TiBitmapData& bitmap,int hue,int saturation,int lightness,
							TINYIMAGE_HUERANGE hueRange);

//私有方法
void	CalculateTransfer(HueSaturation& hs,const HueSaturationParam& param);
void	AdjustHueSaturation(TiBitmapData& bitmap,const HueSaturation& hs);
}