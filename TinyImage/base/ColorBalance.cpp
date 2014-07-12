#include "GlobalData.h"
#include "base/ColorBalance.h"
#include "base/Curve.h"

namespace TinyImage{


static bool transferInit = false;

//变亮的转换数组
static double  highlights_add[256] = { 0 };
static double  midtones_add[256]   = { 0 };
static double  shadows_add[256]    = { 0 };

//变暗的转换数组
static double  highlights_sub[256] = { 0 };
static double  midtones_sub[256]   = { 0 };
static double  shadows_sub[256]    = { 0 };


void InitTransferArray()
{
	if (!transferInit)
	{
		for (int i = 0; i < 256; i++) 
		{
			highlights_add[i] = shadows_sub[255 - i] = (1.075 - 1 / ((double) i / 16.0 + 1));
			midtones_add[i] = midtones_sub[i] = 0.667 * (1 - SQR(((double) i - 127.0) / 127.0));
			shadows_add[i] = highlights_sub[i] = 0.667 * (1 - SQR (((double) i - 127.0) / 127.0));
		}
		transferInit = true;
	}
}


void BalanceColor(TiBitmapData& bitmap,int cyan, int magenta, int yellow,
		TINYIMAGE_TRANSFERMODE mode,bool preserveLuminosity)
{

	TINYIMAGE_ASSERT_VOID(cyan>= -100 && cyan<=100);
	TINYIMAGE_ASSERT_VOID(magenta>= -100 && magenta<=100);
	TINYIMAGE_ASSERT_VOID(yellow>= -100 && yellow<=100);

	//初始化色彩调整区域参数
	double  cyan_red[3];
	double  magenta_green[3];
	double  yellow_blue[3];
	for (int i = TINYIMAGE_TRANSFERMODE_SHADOWS; i <= TINYIMAGE_TRANSFERMODE_HIGHLIGHTS; i++)
	{
		cyan_red[i] = 0.0;
		magenta_green[i] = 0.0;
		yellow_blue[i] = 0.0;
	}
	cyan_red[mode] = cyan;
	magenta_green[mode] = magenta;
	yellow_blue[mode] = yellow;


	//初始化转换用的数组
	InitTransferArray();


	//创建LOOKUP TABLE
	double  *cyan_red_transfer[3];
	double  *magenta_green_transfer[3];
	double  *yellow_blue_transfer[3];
	int   red, green, blue;
	u8 r_lookup[256],g_lookup[256],b_lookup[256];


	//设置转换数组
	cyan_red_transfer[TINYIMAGE_TRANSFERMODE_SHADOWS] = (cyan_red[TINYIMAGE_TRANSFERMODE_SHADOWS] > 0) ? shadows_add : shadows_sub;
	cyan_red_transfer[TINYIMAGE_TRANSFERMODE_MIDTONES] = (cyan_red[TINYIMAGE_TRANSFERMODE_MIDTONES] > 0) ? midtones_add : midtones_sub;
	cyan_red_transfer[TINYIMAGE_TRANSFERMODE_HIGHLIGHTS] = (cyan_red[TINYIMAGE_TRANSFERMODE_HIGHLIGHTS] > 0) ? highlights_add : highlights_sub;

	magenta_green_transfer[TINYIMAGE_TRANSFERMODE_SHADOWS] = (magenta_green[TINYIMAGE_TRANSFERMODE_SHADOWS] > 0) ? shadows_add : shadows_sub;
	magenta_green_transfer[TINYIMAGE_TRANSFERMODE_MIDTONES] =   (magenta_green[TINYIMAGE_TRANSFERMODE_MIDTONES] > 0) ? midtones_add : midtones_sub;
	magenta_green_transfer[TINYIMAGE_TRANSFERMODE_HIGHLIGHTS] = (magenta_green[TINYIMAGE_TRANSFERMODE_HIGHLIGHTS] > 0) ? highlights_add : highlights_sub;

	yellow_blue_transfer[TINYIMAGE_TRANSFERMODE_SHADOWS] = (yellow_blue[TINYIMAGE_TRANSFERMODE_SHADOWS] > 0) ? shadows_add : shadows_sub;
	yellow_blue_transfer[TINYIMAGE_TRANSFERMODE_MIDTONES] = (yellow_blue[TINYIMAGE_TRANSFERMODE_MIDTONES] > 0) ? midtones_add : midtones_sub;
	yellow_blue_transfer[TINYIMAGE_TRANSFERMODE_HIGHLIGHTS] =   (yellow_blue[TINYIMAGE_TRANSFERMODE_HIGHLIGHTS] > 0) ? highlights_add : highlights_sub;

	for (int i = 0; i < 256; i++) 
	{
		red = i;
		green = i;
		blue = i;

		red += (int)( cyan_red[TINYIMAGE_TRANSFERMODE_SHADOWS] * cyan_red_transfer[TINYIMAGE_TRANSFERMODE_SHADOWS][red] 
	                + cyan_red[TINYIMAGE_TRANSFERMODE_MIDTONES] * cyan_red_transfer[TINYIMAGE_TRANSFERMODE_MIDTONES][red]
					+ cyan_red[TINYIMAGE_TRANSFERMODE_HIGHLIGHTS] * cyan_red_transfer[TINYIMAGE_TRANSFERMODE_HIGHLIGHTS][red]);
		red = CLAMP0255 (red);

		green += (int)( magenta_green[TINYIMAGE_TRANSFERMODE_SHADOWS] * magenta_green_transfer[TINYIMAGE_TRANSFERMODE_SHADOWS][green]
					  + magenta_green[TINYIMAGE_TRANSFERMODE_MIDTONES] * magenta_green_transfer[TINYIMAGE_TRANSFERMODE_MIDTONES][green]
					  + magenta_green[TINYIMAGE_TRANSFERMODE_HIGHLIGHTS] * magenta_green_transfer[TINYIMAGE_TRANSFERMODE_HIGHLIGHTS][green]);
		green = CLAMP0255 (green);

		blue +=(int)( yellow_blue[TINYIMAGE_TRANSFERMODE_SHADOWS] * yellow_blue_transfer[TINYIMAGE_TRANSFERMODE_SHADOWS][blue]
				    + yellow_blue[TINYIMAGE_TRANSFERMODE_MIDTONES] * yellow_blue_transfer[TINYIMAGE_TRANSFERMODE_MIDTONES][blue]
				    + yellow_blue[TINYIMAGE_TRANSFERMODE_HIGHLIGHTS] * yellow_blue_transfer[TINYIMAGE_TRANSFERMODE_HIGHLIGHTS][blue]);
		blue = CLAMP0255 (blue);

		r_lookup[i] = (u8)red;
		g_lookup[i] = (u8)green;
		b_lookup[i] = (u8)blue;

	}

	//如果不需要保证亮度不变化，直接赋值就可以了
	if (!preserveLuminosity)
	{
		AdjustCurve(bitmap,r_lookup,g_lookup,b_lookup);
	}
	else
	{
		PreserveLuminosityAdjustCurve(bitmap,r_lookup,g_lookup,b_lookup);
	}
	
}




}