/**
 * @file    Levels.h
 * @brief   色阶调整
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2010-12
 * @website www.xiangwangfeng.com
 */


#pragma once
#include "global/BitmapData.h"
#include "GlobalData.h"
namespace TinyImage{
													
void	AdjustLevels(TiBitmapData& bitmap,int blackThreshold,int whiteThreshold,double gamma,TINYIMAGE_CHANNEL channel);//色阶调整

}