/**
 * @file    GaussBlur.h
 * @brief   高斯模糊
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2011-1
 * @website www.xiangwangfeng.com
 */


#pragma once
#include "global/BitmapData.h"

namespace TinyImage{

void	BlurLine (float *lookupTable, float *matrix, int matrixLength, u8* srcLine, u8* dstLine, int width, int bpp);
int		GenConvolveMatrix (float radius, float** matrix);
float*	GenLookupTable(float *matrix, int matrixLength);
void	GaussianBlur(TiBitmapData& bitmap,float radius);	//高斯模糊

}