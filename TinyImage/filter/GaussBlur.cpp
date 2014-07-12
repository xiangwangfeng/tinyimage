#include "filter/GaussBlur.h"
#include <cmath>

namespace TinyImage{


void	BlurLine (float *lookupTable, float *matrix, int matrixLength, u8* srcLine, u8* dstLine, int width, int bpp)
{
	TINYIMAGE_ASSERT_VOID(lookupTable);
	TINYIMAGE_ASSERT_VOID(matrix);
	TINYIMAGE_ASSERT_VOID(matrixLength >= 0);
	TINYIMAGE_ASSERT_VOID(srcLine);
	TINYIMAGE_ASSERT_VOID(dstLine);
	TINYIMAGE_ASSERT_VOID(width > 0);
	TINYIMAGE_ASSERT_VOID(bpp == TiRGBBpp || bpp == TiRGBABpp);



	float scale;
	float sum;
	int i=0, j=0;
	int row;
	int matrixMiddle = matrixLength/2;
	
	float *cmatrix_p;
	u8  *cur_col_p;
	u8  *cur_col_p1;
	u8  *dest_col_p;
	float *ctable_p;
	
	/* this first block is the same as the non-optimized version --
	* it is only used for very small pictures, so speed isn't a
	* big concern.
	*/
	if (matrixLength > width)
    {
		for (row = 0; row < width ; row++)
		{
			scale=0;
			/* find the scale factor */
			for (j = 0; j < width ; j++)
			{
				/* if the index is in bounds, add it to the scale counter */
				if ((j + matrixMiddle - row >= 0) &&
					(j + matrixMiddle - row < matrixLength))
					scale += matrix[j + matrixMiddle - row];
			}
			for (i = 0; i<bpp; i++)
			{
				sum = 0;
				for (j = 0; j < width; j++)
				{
					if ((j >= row - matrixMiddle) &&
						(j <= row + matrixMiddle))
						sum += srcLine[j*bpp + i] * matrix[j];
				}
				dstLine[row*bpp + i] = (u8)(0.5f + sum / scale);
			}
		}
    }
	else
    {
		/* for the edge condition, we only use available info and scale to one */
		for (row = 0; row < matrixMiddle; row++)
		{
			/* find scale factor */
			scale=0;
			for (j = matrixMiddle - row; j<matrixLength; j++)
				scale += matrix[j];
			for (i = 0; i<bpp; i++)
			{
				sum = 0;
				for (j = matrixMiddle - row; j<matrixLength; j++)
				{
					sum += srcLine[(row + j-matrixMiddle)*bpp + i] * matrix[j];
				}
				dstLine[row*bpp + i] = (u8)(0.5f + sum / scale);
			}
		}
		/* go through each pixel in each col */
		dest_col_p = dstLine + row*bpp;
		for (; row < width-matrixMiddle; row++)
		{
			cur_col_p = (row - matrixMiddle) * bpp + srcLine;
			for (i = 0; i<bpp; i++)
			{
				sum = 0;
				cmatrix_p = matrix;
				cur_col_p1 = cur_col_p;
				ctable_p = lookupTable;
				for (j = matrixLength; j>0; j--)
				{
					sum += *(ctable_p + *cur_col_p1);
					cur_col_p1 += bpp;
					ctable_p += 256;
				}
				cur_col_p++;
				*(dest_col_p++) = (u8)(0.5f + sum);
			}
		}
		
		/* for the edge condition , we only use available info, and scale to one */
		for (; row < width; row++)
		{
			/* find scale factor */
			scale=0;
			for (j = 0; j< width-row + matrixMiddle; j++)
				scale += matrix[j];
			for (i = 0; i<bpp; i++)
			{
				sum = 0;
				for (j = 0; j<width-row + matrixMiddle; j++)
				{
					sum += srcLine[(row + j-matrixMiddle)*bpp + i] * matrix[j];
				}
				dstLine[row*bpp + i] = (u8) (0.5f + sum / scale);
			}
		}
    }
}

int	GenConvolveMatrix (float radius, float **matrix)
{
	int matrix_length;
	int matrix_midpoint;
	float* cmatrix;
	int i,j;
	float std_dev;
	float sum;
	
	/* we want to generate a matrix that goes out a certain radius
	* from the center, so we have to go out ceil(rad-0.5) pixels,
	* inlcuding the center pixel.  Of course, that's only in one direction,
	* so we have to go the same amount in the other direction, but not count
	* the center pixel again.  So we double the previous result and subtract
	* one.
	* The radius parameter that is passed to this function is used as
	* the standard deviation, and the radius of effect is the
	* standard deviation * 2.  It's a little confusing.
	* <DP> modified scaling, so that matrix_lenght = 1+2*radius parameter
	*/
	radius = (float)fabs(0.5*radius) + 0.25f;
	
	std_dev = radius;
	radius = std_dev * 2;
	
	/* go out 'radius' in each direction */
	matrix_length = int (2 * ceil(radius-0.5) + 1);
	if (matrix_length <= 0) matrix_length = 1;
	matrix_midpoint = matrix_length/2 + 1;
	*matrix = new float[matrix_length];
	cmatrix = *matrix;
	
	/*  Now we fill the matrix by doing a numeric integration approximation
	* from -2*std_dev to 2*std_dev, sampling 50 points per pixel.
	* We do the bottom half, mirror it to the top half, then compute the
	* center point.  Otherwise asymmetric quantization errors will occur.
	*  The formula to integrate is e^-(x^2/2s^2).
	*/
	
	/* first we do the top (right) half of matrix */
	for (i = matrix_length/2 + 1; i < matrix_length; i++)
    {
		float base_x = i - (float)floor((float)(matrix_length/2)) - 0.5f;
		sum = 0;
		for (j = 1; j <= 50; j++)
		{
			if ( base_x+0.02*j <= radius ) 
				sum += (float)exp (-(base_x+0.02*j)*(base_x+0.02*j) / 
				(2*std_dev*std_dev));
		}
		cmatrix[i] = sum/50;
    }
	
	/* mirror the thing to the bottom half */
	for (i=0; i<=matrix_length/2; i++) {
		cmatrix[i] = cmatrix[matrix_length-1-i];
	}
	
	/* find center val -- calculate an odd number of quanta to make it symmetric,
	* even if the center point is weighted slightly higher than others. */
	sum = 0;
	for (j=0; j<=50; j++)
    {
		sum += (float)exp (-(0.5+0.02*j)*(0.5+0.02*j) /
			(2*std_dev*std_dev));
    }
	cmatrix[matrix_length/2] = sum/51;
	
	/* normalize the distribution by scaling the total sum to one */
	sum=0;
	for (i=0; i<matrix_length; i++) sum += cmatrix[i];
	for (i=0; i<matrix_length; i++) cmatrix[i] = cmatrix[i] / sum;
	
	return matrix_length;
}
////////////////////////////////////////////////////////////////////////////////
/**
 * generates a lookup table for every possible product of 0-255 and
 * each value in the convolution matrix.  The returned array is
 * indexed first by matrix position, then by input multiplicand (?)
 * value.
 * \author [nipper]
 */
float*	GenLookupTable (float *cmatrix, int cmatrix_length)
{
	float* lookup_table = new float[cmatrix_length * 256];
	float* lookup_table_p = lookup_table;
	float* cmatrix_p      = cmatrix;
	
	for (int i=0; i<cmatrix_length; i++)
    {
		for (int j=0; j<256; j++)
		{
			*(lookup_table_p++) = *cmatrix_p * (float)j;
		}
		cmatrix_p++;
    }
	
	return lookup_table;
}


void	GaussianBlur(TiBitmapData& bitmap,float radius)
{
	int width		= bitmap.GetWidth();
	int height		= bitmap.GetHeight();
	int stride		= bitmap.GetStride();
	int bpp			= bitmap.GetBpp();
	
	// generate convolution matrix and make sure it's smaller than each dimension
	float *cmatrix = 0;
	int cmatrix_length = GenConvolveMatrix(radius, &cmatrix);
	// generate lookup table
	float *ctable = GenLookupTable(cmatrix, cmatrix_length);

	TiBitmapData* clone = bitmap.Clone();

	//横向
	for (int i = 0; i < height; i++)
	{
		BlurLine(ctable,cmatrix,cmatrix_length,
					bitmap.GetRow(i),clone->GetRow(i),width,bpp);
	}

	//纵向
	u8* srcLine = new u8[bpp*height];
	u8* dstLine	= new u8[bpp*height];
	for (int i = 0; i < width; i++)
	{
		clone->GetColumn(srcLine,i);
		BlurLine(ctable,cmatrix,cmatrix_length,
			srcLine,dstLine,height,bpp);
		clone->SetColumn(dstLine,i);
	}

	delete[] srcLine;
	delete[] dstLine;
	

	size_t size = (size_t)stride*height;
	memcpy(bitmap.GetBmpData(),clone->GetBmpData(),size);

	delete clone;
	delete []cmatrix;
	delete []ctable;

}



}