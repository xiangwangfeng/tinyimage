/**
 * @file    Lomo.h
 * @brief   Lomo效果
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2011-1
 * @website www.xiangwangfeng.com
 */

#pragma once
#include "global/BitmapData.h"
#include "GlobalData.h"
#include "global/ColorType.h"

namespace TinyImage{


	//Lomo
	void	Lomo(TiBitmapData& bitmap);		

	//暗角
	void DarkenCorner(TiBitmapData& bitmap, double brightRatio = 0.4, u8 maskAlpha = 200);
	

	
}