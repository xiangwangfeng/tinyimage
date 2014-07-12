/**
 * @file    Histogram.h
 * @brief   直方图
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2011-1
 * @website www.xiangwangfeng.com
 */


#pragma once
#include "global/BitmapData.h"

namespace TinyImage{

struct TiHistogram
{
	int rValues[256];
	int gValues[256];
	int bValues[256];
	int rgbValues[256];
};

TiHistogram*	GetImageHistogram(TiBitmapData& bitmap);

}