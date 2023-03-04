using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class MovingFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int width, int height)
        {
            Color resultColor;

            if (width + 50 < sourceImage.Width) resultColor = sourceImage.GetPixel(width + 50, height);
            else resultColor = Color.Black;

            return resultColor;
        }
    }
}
