这是一个在做闪印/相片管家编辑功能时整理出来的代码集合，并做了很大部分的修改。

这个库的特点：
1.命名规范更符合我个人对代码的审美要求(虽然这个东西是会与时俱进的，但是至少当时我还觉得这命名规则不错)
2.结构更清晰，整个模块分为base，filter和global部分，比较清晰
3.对各种算法进行了尽可能的优化


使用方法：
build出DLL文件和lib
头文件只需要TinyImage.h和GlobalData.h即可 (C#方法可以详见DEMO)

算法说明：
在我的个人博客上对这个小库涉及到的一些基础算法做了较多的说明
图像编辑之亮度调整	----	http://www.xiangwangfeng.com/2011/01/03/%E5%9B%BE%E5%83%8F%E7%BC%96%E8%BE%91%E4%B9%8B%E4%BA%AE%E5%BA%A6%E8%B0%83%E6%95%B4/
图像编辑之对比度调整	----	http://www.xiangwangfeng.com/2011/01/09/%E5%9B%BE%E5%83%8F%E7%BC%96%E8%BE%91%E4%B9%8B%E5%AF%B9%E6%AF%94%E5%BA%A6%E8%B0%83%E6%95%B4/
图像编辑之色彩平衡	----	http://www.xiangwangfeng.com/2011/01/20/%E5%9B%BE%E5%83%8F%E7%BC%96%E8%BE%91%E4%B9%8B%E8%89%B2%E5%BD%A9%E5%B9%B3%E8%A1%A1/
图像编辑之图层混合	----	http://www.xiangwangfeng.com/2011/02/26/%E5%9B%BE%E5%83%8F%E7%BC%96%E8%BE%91%E4%B9%8B%E5%9B%BE%E5%B1%82%E6%B7%B7%E5%90%88/
图像编辑之一键特效	----	http://www.xiangwangfeng.com/2011/02/28/%E5%9B%BE%E5%83%8F%E7%BC%96%E8%BE%91%E4%B9%8B%E4%B8%80%E9%94%AE%E7%89%B9%E6%95%88lomo%EF%BC%8C%E5%8F%8D%E8%BD%AC%E8%B4%9F%E5%86%B2%EF%BC%8C%E6%9F%94%E5%85%89/


如果发现里面的代码有任何bug请自行修正或联系我：
xiangwangfeng@gmail.com