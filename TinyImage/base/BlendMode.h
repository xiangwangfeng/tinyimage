/**
 * @file    BlendMode.h
 * @brief   图层混合
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2011-02
 * @website www.xiangwangfeng.com
 */

#pragma once
#include "GlobalData.h"
#include "global/BitmapData.h"

namespace TinyImage{

//图层混合
void	BlendMode(TiBitmapData& srcBitmap,TINYIMAGE_CHANNEL srcChannel,
				  TiBitmapData& blendBitmap,TINYIMAGE_CHANNEL blendChannel,
				  TINYIMAGE_BLENDMODE mode,double opacity);

//生成LookupTable
void	GenerateLookupTable(u8 (&lookup)[256][256],TINYIMAGE_BLENDMODE mode,double opacity);

//混合曲线调整
void	AdjustBlendModeCurve(TiBitmapData& srcBitmap,TINYIMAGE_CHANNEL srcChannel,
							 TiBitmapData& blendBitmap,TINYIMAGE_CHANNEL blendChannel,
							 u8 (&lookup)[256][256]);
//int和Channel转换
int		ConvertRGBIndex(TINYIMAGE_CHANNEL channel);	

//GLT = Generate Lookup Table
//生成各自图层混合需要的Lookup Table
void	GLT_Darken(u8 (&lookup)[256][256],double opacity);			//变暗
void	GLT_Lighten(u8 (&lookup)[256][256],double opacity);			//变亮
void	GLT_Multiply(u8 (&lookup)[256][256],double opacity);		//正片叠底
void	GLT_Screen(u8 (&lookup)[256][256],double opacity);			//滤色
void	GLT_ColorDodge(u8 (&lookup)[256][256],double opacity);		//色彩减淡
void	GLT_ColorBurn(u8 (&lookup)[256][256],double opacity);		//色彩加深
void	GLT_LinearDodge(u8 (&lookup)[256][256],double opacity);		//线性减淡
void	GLT_LinearBurn(u8 (&lookup)[256][256],double opacity);		//线性加深
void	GLT_Overlay(u8 (&lookup)[256][256],double opacity);			//叠加
void	GLT_HardLight(u8 (&lookup)[256][256],double opacity);		//强光
void	GLT_SoftLight(u8 (&lookup)[256][256],double opacity);		//柔光
void	GLT_VividLight(u8 (&lookup)[256][256],double opacity);		//亮光
void	GLT_LinearLight(u8 (&lookup)[256][256],double opacity);		//线性光
void	GLT_PinLight(u8 (&lookup)[256][256],double opacity);		//点光
void	GLT_HardMix(u8 (&lookup)[256][256],double opacity);			//实色混合
void	GLT_Add(u8 (&lookup)[256][256],double opacity);				//相加
void	GLT_Sub(u8 (&lookup)[256][256],double opacity);				//相减
void	GLT_Difference(u8 (&lookup)[256][256],double opacity);		//差值
void	GLT_Exclusion(u8 (&lookup)[256][256],double opacity);		//排除

}