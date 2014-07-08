/**
 * @file    ColorSpace.h
 * @brief   色彩空间
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2010-12
 * @website www.xiangwangfeng.com
 */
#pragma once

namespace TinyImage{

struct TinyRGBA;
struct TinyRGB;
struct TinyHSL;
/************************************************************************/
/*                   颜色空间转换函数                                   */
/************************************************************************/

//RGB转HSL
void Rgb2Hsl(const TinyRGB *rgb, TinyHSL *hsl);

//HSL转换RGB
void Hsl2Rgb(const TinyHSL *hsl, TinyRGB *rgb);

//RGB转HSL，只获取L
int Rgb2Hsl_L(u8 red,u8 green,u8 blue);


//RGB转HSL int(减少了最后一步除法运算)
void Rgb2Hsl_Int (int& red, int& green,int& blue);

//HSL转RGB int
void Hsl2Rgb_Int (int& hue,int& saturation,int& lightness);

}