/**
 * @file    ColorBalance.h
 * @brief   色彩平衡
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2011-1
 * @website www.xiangwangfeng.com
 */


#pragma once
#include "global/BitmapData.h"

namespace TinyImage{

//公共方法
void BalanceColor(TiBitmapData& bitmap,int cyan, int magenta, int yellow,
		TINYIMAGE_TRANSFERMODE mode,bool preserveLuminosity);

//私有方法
void InitTransferArray();//初始化转换用数组

}