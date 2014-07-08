#include "TinyImage.h"
#include "base/Histogram.h"
#include "base/ColorBalance.h"
#include "base/Levels.h"
#include "base/Brightness.h"
#include "base/Constrast.h"
#include "base/HueSaturation.h"
#include "base/BlendMode.h"
#include "filter/Invert.h"
#include "filter/Grayscale.h"
#include "filter/Lomo.h"
#include "filter/Sketch.h"
#include "filter/OldPhoto.h"
#include "filter/NegativeFilm.h"
#include "filter/SoftGlow.h"

namespace TinyImage{

TiHistogram* GetImageHistogram(void* buf,int width,int height,int stride,int bpp)
{
	TINYIMAGE_ASSERT_NULL(buf);
	TINYIMAGE_ASSERT_NULL(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	return GetImageHistogram(bitmap);
}


void	AdjustBrightness(void* buf,int width,int height,int stride,int bpp,
						 double level)
{
	TINYIMAGE_ASSERT_VOID(buf);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TINYIMAGE_ASSERT_VOID(level >= -1.0 && level <= 1.0);
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	AdjustBrightness(bitmap,level);
}

void	AdjustContrast(void* buf,int width,int height,int stride,int bpp,
						 double level)
{
	TINYIMAGE_ASSERT_VOID(buf);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TINYIMAGE_ASSERT_VOID(level >= -1.0 && level <= 1.0);
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	AdjustContrast(bitmap,level);
}


void	AdjustHueSaturation(void* buf,int width,int height,int stride,int bpp,
								int hue,int saturation,int lightness,TINYIMAGE_HUERANGE hueRange)
{
	TINYIMAGE_ASSERT_VOID(buf);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TINYIMAGE_ASSERT_VOID(hue >= -180 && hue <= 180);
	TINYIMAGE_ASSERT_VOID(saturation >= -100 && saturation <= 100);
	TINYIMAGE_ASSERT_VOID(lightness >= -100 && lightness <= 100);
	TINYIMAGE_ASSERT_VOID(hueRange >= 0 && hueRange <= 6);
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	AdjustHueSaturation(bitmap,hue,saturation,lightness,hueRange);
}

void	AdjustLevels(void* buf,int width,int height,int stride,int bpp,
					 int blackThreshold,int whiteThreshold,double gamma,TINYIMAGE_CHANNEL channel)
{
	TINYIMAGE_ASSERT_VOID(buf);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TINYIMAGE_ASSERT_VOID(blackThreshold>= 0 && whiteThreshold>blackThreshold && whiteThreshold<=255);
	TINYIMAGE_ASSERT_VOID(gamma >= 0.0 && gamma <= 10.0);
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	AdjustLevels(bitmap,blackThreshold,whiteThreshold,gamma,channel);

}

void	BalanceColor(void* buf,int width,int height,int stride,int bpp,
					int cyan, int magenta, int yellow,TINYIMAGE_TRANSFERMODE mode,bool preserveLuminosity)
{
	TINYIMAGE_ASSERT_VOID(buf);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TINYIMAGE_ASSERT_VOID(cyan>= -100 && cyan<=100);
	TINYIMAGE_ASSERT_VOID(magenta>= -100 && magenta<=100);
	TINYIMAGE_ASSERT_VOID(yellow>= -100 && yellow<=100);
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	BalanceColor(bitmap,cyan,magenta,yellow,mode,preserveLuminosity);
}

void	GrayScale(void* buf,int width,int height,int stride,int bpp)
{
	TINYIMAGE_ASSERT_VOID(buf);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	GrayScale(bitmap);
}

void	Lomo(void* buf,int width,int height,int stride,int bpp)
{
	TINYIMAGE_ASSERT_VOID(buf);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	Lomo(bitmap);
}

void	Sketch(void* buf,int width,int height,int stride,int bpp)
{
	TINYIMAGE_ASSERT_VOID(buf);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	Sketch(bitmap);
}

void	OldPhoto(void* buf,int width,int height,int stride,int bpp)
{
	TINYIMAGE_ASSERT_VOID(buf);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	OldPhoto(bitmap);
}

void	Invert(void* buf,int width,int height,int stride,int bpp)
{
	TINYIMAGE_ASSERT_VOID(buf);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	Invert(bitmap);
}

void	NegativeFilm(void* buf,int width,int height,int stride,int bpp)
{
	TINYIMAGE_ASSERT_VOID(buf);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	NegativeFilm(bitmap);
}

void	SoftGlow(void* buf,int width,int height,int stride,int bpp)
{
	TINYIMAGE_ASSERT_VOID(buf);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	SoftGlow(bitmap);
}




TINY_IMAGE_API void BlendMode(void* buf,int width,int height,int stride,int bpp,TINYIMAGE_CHANNEL srcChannel,
							  void* blendBuf,int blendWidth,int blendHeight,int blendStride,int blendBpp,TINYIMAGE_CHANNEL blendChannel,
							  TINYIMAGE_BLENDMODE mode,double opacity)
{
	TINYIMAGE_ASSERT_VOID(buf);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);
	TINYIMAGE_ASSERT_VOID(blendBuf);
	TINYIMAGE_ASSERT_VOID(blendBpp == TiRGBBpp || blendBpp == TiRGBABpp);
	TINYIMAGE_ASSERT_VOID(width == blendWidth);
	TINYIMAGE_ASSERT_VOID(height == blendHeight);
	TINYIMAGE_ASSERT_VOID(stride == blendStride);
	TINYIMAGE_ASSERT_VOID(opacity >= 0.0 && opacity <= 1.0);
	
	TiBitmapData bitmap(buf,width,height,stride,bpp);
	TiBitmapData blendBitmap(blendBuf,blendWidth,blendHeight,blendStride,blendBpp);
	BlendMode(bitmap,srcChannel,blendBitmap,blendChannel,mode,opacity);
}

}