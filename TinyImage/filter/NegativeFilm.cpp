#include "base/BlendMode.h"
#include "filter/Invert.h"
#include "filter/NegativeFilm.h"

namespace TinyImage{

	void	NegativeFilm(TiBitmapData& bitmap)
	{
		TiBitmapData* clone = bitmap.Clone();
		Invert(*clone);

		BlendMode(bitmap,TINYIMAGE_CHANEL_B,*clone,TINYIMAGE_CHANEL_B,
				 TINYIMAGE_BLENDMODE_MULTIPLY,0.5);

		BlendMode(bitmap,TINYIMAGE_CHANEL_G,*clone,TINYIMAGE_CHANEL_G,
				 TINYIMAGE_BLENDMODE_MULTIPLY,0.2);

		BlendMode(bitmap,TINYIMAGE_CHANEL_R,bitmap,TINYIMAGE_CHANEL_R,
				 TINYIMAGE_BLENDMODE_COLORBURN,1);

		delete clone;
	}

}