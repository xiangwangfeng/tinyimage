/**
 * @file    GlobalData.h
 * @brief   公共定义
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2010-12
 * @website www.xiangwangfeng.com
 */


#pragma once
#include <cassert>


namespace TinyImage
{

typedef unsigned char u8;
typedef unsigned int   u32;

#ifndef MAX
#define MAX(a, b) ((a) > (b) ? (a) : (b))
#endif
#ifndef MIN
#define MIN(a, b) ((a) < (b) ? (a) : (b))
#endif

#define ROUND(x) ((int) ((x) + 0.5))

#ifndef CLAMP
#define CLAMP(x,l,u) ((x)<(l)?(l):((x)>(u)?(u):(x)))
#endif

#define CLAMP0255(x) ((x)<(0)?(0):((x)>(255)?(255):(x)))
#define TINYIMAGE_ASSERT_VOID(p)  {assert(p);if(!(p)) {return;}}
#define TINYIMAGE_ASSERT_NULL(p)  {assert(p);if(!(p)) {return 0;}}
#define SQR(x) ((x)*(x))
#define TINYIMAGE_PI 3.1415926535897932384626433832795
#define TINYIMAGE_2PI   (2.0*TINYIMAGE_PI)

//RGB通道
enum TINYIMAGE_CHANNEL
{
	TINYIMAGE_CHANEL_RGB,	
	TINYIMAGE_CHANEL_R,
	TINYIMAGE_CHANEL_G,
	TINYIMAGE_CHANEL_B,
};

//明暗调区域
enum TINYIMAGE_TRANSFERMODE
{
	TINYIMAGE_TRANSFERMODE_SHADOWS,		//阴影
	TINYIMAGE_TRANSFERMODE_MIDTONES,	//中间调
	TINYIMAGE_TRANSFERMODE_HIGHLIGHTS,	//高光
};

//色彩范围
enum TINYIMAGE_HUERANGE
{
	TINYIMAGE_HUERANGE_ALLHUES,		//全图
	TINYIMAGE_HUERANGE_RED,			//红
	TINYIMAGE_HUERANGE_YELLOW,		//黄
	TINYIMAGE_HUERANGE_GREEN,		//绿
	TINYIMAGE_HUERANGE_CYAN,		//青
	TINYIMAGE_HUERANGE_BLUE,		//蓝
	TINYIMAGE_HUERANGE_MAGENTA,		//洋红
};

enum TINYIMAGE_BLENDMODE
{
	TINYIMAGE_BLENDMODE_DARKEN,			//变暗
	TINYIMAGE_BLENDMODE_LIGHTEN,		//变亮
	TINYIMAGE_BLENDMODE_MULTIPLY,		//正片叠底
	TINYIMAGE_BLENDMODE_SCREEN,			//滤色
	TINYIMAGE_BLENDMODE_COLORDODGE,		//颜色减淡
	TINYIMAGE_BLENDMODE_COLORBURN,		//颜色加深
	TINYIMAGE_BLENDMODE_LINEARDODGE,	//线性减淡
	TINYIMAGE_BLENDMODE_LINEARBURN,		//线性加深
	TINYIMAGE_BLENDMODE_OVERLAY,		//叠加
	TINYIMAGE_BLENDMODE_SOFTLIGHT,		//柔光
	TINYIMAGE_BLENDMODE_HARDLIGHT,		//强光
	TINYIMAGE_BLENDMODE_VIVIDLIGHT,		//亮光
	TINYIMAGE_BLENDMODE_LINEARLIGHT,	//线性光
	TINYIMAGE_BLENDMODE_PINLIGHT,		//点光
	TINYIMAGE_BLENDMODE_HARDMIX,		//实色混合
	TINYIMAGE_BLENDMODE_ADD,			//相加
	TINYIMAGE_BLENDMODE_SUB,			//相减
	TINYIMAGE_BLENDMODE_DIFFERENCE,		//差值
	TINYIMAGE_BLENDMODE_EXCLUSION,		//排除
};

const int TiRGBBpp		= 3;
const int TiRGBABpp		= 4;
const int TiBlue		= 0;
const int TiGreen		= 1;
const int TiRed			= 2;
const int TiAlpha		= 3;
const double TIEPSILON	= 0.000001;

}

