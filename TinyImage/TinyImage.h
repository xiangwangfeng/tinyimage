/**
 * @file    TinyImage.h
 * @brief   导出方法集
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2010-12
 * @website www.xiangwangfeng.com
 */


#pragma once
#include "GlobalData.h"


#define TINY_IMAGE_API extern "C" __declspec(dllexport)

namespace TinyImage{

struct TiHistogram;

TINY_IMAGE_API TiHistogram*	GetImageHistogram(void* buf,int width,int height,int stride,int bpp);

/****************************颜色相关调整**************************/
TINY_IMAGE_API void	AdjustBrightness(void* buf,int width,int height,int stride,int bpp,double level);
TINY_IMAGE_API void	AdjustContrast(void* buf,int width,int height,int stride,int bpp,double level);
TINY_IMAGE_API void	AdjustHueSaturation(void* buf,int width,int height,int stride,int bpp,int hue,int saturation,int lightness,TINYIMAGE_HUERANGE hueRange);
TINY_IMAGE_API void	AdjustLevels(void* buf,int width,int height,int stride,int bpp,int blackThreshold,int whiteThreshold,double gamma,TINYIMAGE_CHANNEL channel);
TINY_IMAGE_API void BalanceColor(void* buf,int width,int height,int stride,int bpp,int cyan, int magenta, int yellow,TINYIMAGE_TRANSFERMODE mode,bool preserveLuminosity);

/****************************图片混合**************************/
TINY_IMAGE_API void BlendMode(void* buf,int width,int height,int stride,int bpp,TINYIMAGE_CHANNEL srcChannel,
							  void* blendBuf,int blendWidth,int blendHeight,int blendStride,int blendBpp,TINYIMAGE_CHANNEL blendChannel,
							  TINYIMAGE_BLENDMODE mode,double opacity);


/****************************滤镜(一键效果)**************************/
TINY_IMAGE_API void GrayScale(void* buf,int width,int height,int stride,int bpp);	//灰度化
TINY_IMAGE_API void OldPhoto(void* buf,int width,int height,int stride,int bpp);	//老照片
TINY_IMAGE_API void Lomo(void* buf,int width,int height,int stride,int bpp);		//Lomo
TINY_IMAGE_API void Sketch(void* buf,int width,int height,int stride,int bpp);		//素描
TINY_IMAGE_API void Invert(void* buf,int width,int height,int stride,int bpp);		//反相
TINY_IMAGE_API void NegativeFilm(void* buf,int width,int height,int stride,int bpp);//反转负冲
TINY_IMAGE_API void SoftGlow(void* buf,int width,int height,int stride,int bpp);	//柔光


}