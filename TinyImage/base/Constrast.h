/**
 * @file    Constrast.h
 * @brief   对比度调整
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2010-12
 * @website www.xiangwangfeng.com
 */

#pragma once
#include "global/BitmapData.h"
namespace TinyImage{

//对比度调整
void	AdjustContrast(TiBitmapData& bitmap,double level);	

//使用阈值进行调整
void	AdjustContrastUsingConstThreshold(TiBitmapData& bitmap,double level);

//使用平均值进行调整
void	AdjustContrastUsingAverageThreshold(TiBitmapData& bitmap,double level);

}