using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class ReferenceColorCorrectionFilter : Filters
    {
        public Color src = Form1.srcColor;
        public Color dst = Form1.dstColor;

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int width, int height)
        {
            int sourceR = sourceImage.GetPixel(width, height).R;
            int sourceG = sourceImage.GetPixel(width, height).G;
            int sourceB = sourceImage.GetPixel(width, height).B;
            Color resultColor = Color.FromArgb(Clamp(sourceR * (dst.R / src.R), 0, 255), Clamp(sourceG * (dst.G / src.G), 0, 255), Clamp(sourceB * (dst.B / src.B), 0, 255));
            return resultColor;
        }
    }
}
