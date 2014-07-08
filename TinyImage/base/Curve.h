/**
 * @file    Curve.h
 * @brief   曲线调整
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2010-12
 * @website www.xiangwangfeng.com
 */

#pragma once
#include "GlobalData.h"
#include "global/BitmapData.h"

namespace TinyImage{


void	AdjustCurve(TiBitmapData& bitmap,u8 (&lookup)[256],TINYIMAGE_CHANNEL channel);						//单LookupTable曲线调整
void	AdjustCurve(TiBitmapData& bitmap,u8 (&r_lookup)[256],u8 (&g_lookup)[256],u8 (&b_lookup)[256]);//三通道曲线调整
void	PreserveLuminosityAdjustCurve(TiBitmapData& bitmap,u8 (&r_lookup)[256],u8 (&g_lookup)[256],u8 (&b_lookup)[256]);//保证像素点亮度不变的曲线调整

}