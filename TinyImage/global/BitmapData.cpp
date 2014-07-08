#include "BitmapData.h"
#include <cstring>

namespace TinyImage{



TiBitmapData::TiBitmapData(void* buf,int width,int height,int stride,int bpp,bool selfCreated)
{
	assert(buf);
	assert(bpp == TiRGBBpp || bpp == TiRGBABpp);
	m_bmpData		= (u8*)buf;
	m_width			= width;
	m_height		= height;
	m_stride		= stride;
	m_bpp			= bpp;
	m_totalPixels	= (long)width*height;
	m_selfCreated	= selfCreated;
}

TiBitmapData::~TiBitmapData()
{
	if (m_selfCreated)
	{
		delete []m_bmpData;
	}
}

TiBitmapData*	TiBitmapData::Clone()
{
	size_t size = (size_t)m_stride * m_height;
	u8* newBitmap = new u8[size];
	memcpy(newBitmap,m_bmpData,size);
	return new TiBitmapData(newBitmap,m_width,m_height,m_stride,m_bpp,true);
}

}