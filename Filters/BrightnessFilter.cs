using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class BrightnessFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color sourceColor = sourceImage.GetPixel(i, j);
            const float k = 20;
            Color resultColor = Color.FromArgb(Clamp((int)(sourceColor.R + k), 0, 255),
                Clamp((int)(sourceColor.G + k), 0, 255), Clamp((int)(sourceColor.B + k), 0, 255));
            return resultColor;
        }
    }
}
