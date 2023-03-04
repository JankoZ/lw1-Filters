using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class GrayWorldFilter : Filters
    {
        public double rAvg, gAvg, bAvg, avg;

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int width, int height)
        {
            Color sourceColor = sourceImage.GetPixel(width, height);
            double rRes = sourceColor.R * (avg / rAvg);
            double gRes = sourceColor.G * (avg / gAvg);
            double bRes = sourceColor.B * (avg / bAvg);
            Color resultColor = Color.FromArgb(Clamp((int)(rRes), 0, 255),
                Clamp((int)(gRes), 0, 255), Clamp((int)(bRes), 0, 255));
            return resultColor;
        }
    }
}
