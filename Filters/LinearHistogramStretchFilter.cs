using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class LinearHistogramStretchFilter : Filters
    {
        public float fMax = 0, fMin = 1;

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int width, int height)
        {
            Color sourceColor = sourceImage.GetPixel(width, height);
            float rRes = (sourceColor.R - fMin) / (fMax - fMin);
            float gRes = (sourceColor.G - fMin) / (fMax - fMin);
            float bRes = (sourceColor.B - fMin) / (fMax - fMin);

            Color resultColor = Color.FromArgb((int)rRes, (int)gRes, (int)bRes);
            return resultColor;
        }
    }
}
