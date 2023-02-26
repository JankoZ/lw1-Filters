using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class SepiaFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color sourceColor = sourceImage.GetPixel(i, j);
            float intensity = sourceColor.R * 0.36f + sourceColor.G * 0.53f + sourceColor.B * 0.11f;
            const float k = 20; 
            Color resultColor = Color.FromArgb(Clamp((int)(intensity + 2 * k), 0, 255),
                Clamp((int)(intensity + 0.5f * k), 0, 255), Clamp((int)(intensity - k), 0, 255));
            return resultColor;
        }
    }
}
