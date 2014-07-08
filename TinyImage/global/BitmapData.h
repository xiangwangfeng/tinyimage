/**
 * @file    BitmapData.h
 * @brief   对图片数据的封装类
 * @author  xiangwangfeng <xiangwangfeng@gmail.com>
 * @since   2010-12
 * @website www.xiangwangfeng.com
 */

#pragma once
#include "GlobalData.h"
#include <cstring>

namespace TinyImage{

//对图片数据块的简单包装类
class TiBitmapData
{
public:
	explicit TiBitmapData(void* buf,int width,int height,int stride,int bpp,bool selfCreated = false);
	~TiBitmapData();
public:
	int		GetWidth();
	int		GetHeight();
	int		GetStride();
	int		GetBpp();
	long	GetTotalPixels();
	u8*		GetBmpData();
	u8*		GetPixel(int x,int y);
	u8*		GetRow(int y);
	void	GetColumn(u8* col,int x);
	void	SetColumn(u8* col,int x);
	TiBitmapData*	Clone();
private:
	u8*		m_bmpData;
	int		m_width;
	int		m_height;
	long	m_totalPixels;
	int		m_stride;
	int		m_bpp;
	bool	m_selfCreated;
};


inline int	TiBitmapData::GetWidth()
{
	return m_width;
}

inline int	TiBitmapData::GetHeight()
{
	return m_height;
}

inline int	TiBitmapData::GetStride()
{
	return m_stride;
}

inline int	TiBitmapData::GetBpp()
{
	return m_bpp;
}

inline long	TiBitmapData::GetTotalPixels()
{
	return m_totalPixels;
}

inline u8*	TiBitmapData::GetBmpData()
{
	return m_bmpData;
}

inline u8*	TiBitmapData::GetPixel(int x, int y)
{
	assert(x >=0 && x < m_width);
	assert(y >=0 && y < m_height);
	return m_bmpData + y * m_stride + x * m_bpp;
}

inline u8*	TiBitmapData::GetRow(int y)
{
	assert(y >=0 && y < m_height);
	return m_bmpData + y * m_stride;
}

inline void	TiBitmapData::GetColumn(u8* col,int x)
{
	assert(x >=0 && x < m_width);
	assert(col);
	u8* currentCol = col;
	for (int i = 0 ; i < m_height; i ++)
	{
		memcpy(currentCol,m_bmpData + i * m_stride + x * m_bpp,m_bpp);
		currentCol += m_bpp;
	}
	
}

inline void	TiBitmapData::SetColumn(u8* col,int x)
{
	assert(x >=0 && x < m_width);
	assert(col);
	u8* currentCol = col;
	for (int i = 0 ; i < m_height; i ++)
	{
		memcpy(m_bmpData + i * m_stride + x * m_bpp,currentCol,m_bpp);
		currentCol += m_bpp;
	}
}

}