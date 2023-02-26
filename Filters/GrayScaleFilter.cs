using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class GrayScaleFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color sourceColor = sourceImage.GetPixel(i, j);
            float intensity = sourceColor.R * 0.36f + sourceColor.G * 0.53f + sourceColor.B * 0.11f;
            Color resultColor = Color.FromArgb((int)intensity,
                (int)intensity, (int)intensity);
            return resultColor;
        }
    }
}
