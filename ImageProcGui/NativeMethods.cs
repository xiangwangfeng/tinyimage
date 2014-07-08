using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ImageProc
{
    //RGB通道
    public enum TINYIMAGE_CHANNEL
    {
        TINYIMAGE_CHANEL_RGB,
        TINYIMAGE_CHANEL_R,
        TINYIMAGE_CHANEL_G,
        TINYIMAGE_CHANEL_B,
    };

    //明暗调区域
    public enum TINYIMAGE_TRANSFERMODE
    {
        TINYIMAGE_TRANSFERMODE_SHADOWS,		//阴影
        TINYIMAGE_TRANSFERMODE_MIDTONES,	//中间调
        TINYIMAGE_TRANSFERMODE_HIGHLIGHTS,	//高光
    };

    //色彩范围
    public enum TINYIMAGE_HUERANGE
    {
        TINYIMAGE_HUERANGE_ALLHUES,		//全图
        TINYIMAGE_HUERANGE_RED,			//红
        TINYIMAGE_HUERANGE_YELLOW,		//黄
        TINYIMAGE_HUERANGE_GREEN,		//绿
        TINYIMAGE_HUERANGE_CYAN,		//青
        TINYIMAGE_HUERANGE_BLUE,		//蓝
        TINYIMAGE_HUERANGE_MAGENTA,		//洋红
    };

    //图层混合模式
    public enum TINYIMAGE_BLENDMODE
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
     
    [StructLayout(LayoutKind.Sequential)] 
    public class TiHistogram
    {
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=256)]
	    public int []rValues = new int[256];
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
	    public int []gValues = new int[256];
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
	    public int []bValues = new int[256];
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
	    public int []rgbValues = new int[256];
    };


    public class NativeMethods
    {
        //亮度调整
        [DllImport("TinyImage.dll")]
        public static extern void AdjustBrightness(IntPtr buf, int width, int height, int stride, int bpp, 
                                                    double level);

        //对比度调整
        [DllImport("TinyImage.dll")]
        public static extern void AdjustContrast(IntPtr buf, int width, int height, int stride, int bpp,
                                                    double level);

        //色相/饱和度调整
        [DllImport("TinyImage.dll")]
        public static extern void AdjustHueSaturation(IntPtr buf, int width, int height, int stride, int bpp,
                                                        int hue, int saturation, int lightness, TINYIMAGE_HUERANGE hueRange);

        //色阶调整
        [DllImport("TinyImage.dll")]
        public static extern void	AdjustLevels(IntPtr buf,int width,int height,int stride,int bpp,
                                                 int blackThreshold,int whiteThreshold,double gamma,TINYIMAGE_CHANNEL channel);

        //色彩平衡
        [DllImport("TinyImage.dll")]
        public static extern void BalanceColor(IntPtr buf,int width,int height,int stride,int bpp,
                                                int cyan, int magenta, int yellow,TINYIMAGE_TRANSFERMODE mode,bool preserveLuminosity);


        //直方图
        [DllImport("TinyImage.dll")]
        public static extern IntPtr GetImageHistogram(IntPtr buf, int width, int height, int stride, int bpp);


        //Lomo效果
        [DllImport("TinyImage.dll")]
        public static extern void Lomo(IntPtr buf, int width, int height, int stride, int bpp);


        //素描效果
        [DllImport("TinyImage.dll")]
        public static extern void Sketch(IntPtr buf, int width, int height, int stride, int bpp);

        //黑白
        [DllImport("TinyImage.dll")]
        public static extern void GrayScale(IntPtr buf, int width, int height, int stride, int bpp);

        //反相
        [DllImport("TinyImage.dll")]
        public static extern void Invert(IntPtr buf, int width, int height, int stride, int bpp);


        //旧照片
        [DllImport("TinyImage.dll")]
        public static extern void OldPhoto(IntPtr buf, int width, int height, int stride, int bpp);


        //反转负冲
        [DllImport("TinyImage.dll")]
        public static extern void NegativeFilm(IntPtr buf, int width, int height, int stride, int bpp);


        //柔光
        [DllImport("TinyImage.dll")]
        public static extern void SoftGlow(IntPtr buf, int width, int height, int stride, int bpp);










        //图层混合
        [DllImport("TinyImage.dll")]
        public static extern void BlendMode(IntPtr buf, int width, int height, int stride, int bpp, TINYIMAGE_CHANNEL srcChannel,
                                            IntPtr blendBuf, int blendWidth, int blendHeight, int blendStride, int blendBpp, TINYIMAGE_CHANNEL blendChannel,
                                            TINYIMAGE_BLENDMODE mode, double opacity);
                    
    
    }
}
