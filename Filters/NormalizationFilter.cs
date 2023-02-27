using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class NormalizationFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color sourceColor = sourceImage.GetPixel(i, j);
            Color resultColor = Color.FromArgb(Clamp((int)((sourceColor.R + 255) / 2), 0, 255),
                Clamp((int)((sourceColor.G + 255) / 2), 0, 255), Clamp((int)((sourceColor.B + 255) / 2), 0, 255));
            return resultColor;
        }
    }
}
