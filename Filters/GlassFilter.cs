using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class GlassFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int width, int height)
        {
            Color resultColor;
            Random rand = new Random();
            double resX = width + (rand.NextDouble() - 0.5f) * 10;
            double resY = height + (rand.NextDouble() - 0.5f) * 10;

            if (((int)resX < sourceImage.Width) && ((int)resY < sourceImage.Height) && (resX > 0) && (resY > 0)) resultColor = sourceImage.GetPixel((int)resX, (int)resY);
            else resultColor = Color.Black;

            return resultColor;
        }
    }
}
