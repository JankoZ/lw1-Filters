using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class PerfectReflectorFilter : Filters
    {
        public double rMax = 0, gMax = 0, bMax = 0;

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int width, int height)
        {
            Color sourceColor = sourceImage.GetPixel(width, height);
            double rRes = sourceColor.R * (255 / rMax);
            double gRes = sourceColor.G * (255 / gMax);
            double bRes = sourceColor.B * (255 / bMax);
            Color resultColor = Color.FromArgb(Clamp((int)(rRes), 0, 255),
                Clamp((int)(gRes), 0, 255), Clamp((int)(bRes), 0, 255));
            return resultColor;
        }
    }
}
