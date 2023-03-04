using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class WavesFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int width, int height)
        {
            Color resultColor;
            double resX = width + 20 * Math.Sin((2 * Math.PI * height) / 60);

            if (((int)resX < sourceImage.Width) && (resX > 0)) resultColor = sourceImage.GetPixel((int)resX, height);
            else resultColor = Color.Black;

            return resultColor;
        }
    }
}
