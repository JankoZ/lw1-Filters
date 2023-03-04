using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class RotateFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int width, int height)
        {
            Color resultColor;
            int x0 = sourceImage.Width / 2;
            int y0 = sourceImage.Height / 2;
            double resX = (double)(width - x0) * Math.Cos(Math.PI / 2) - (double)(height - y0) * Math.Sin(Math.PI / 2) + x0;
            double resY = (double)(width - x0) * Math.Sin(Math.PI / 2) + (double)(height - y0) * Math.Cos(Math.PI / 2) + y0;

            if (((int)resX < sourceImage.Width) && ((int)resY < sourceImage.Height) && (resX > 0) && (resY > 0)) resultColor = sourceImage.GetPixel((int)resX, (int)resY);
            else resultColor = Color.Black;

            return resultColor;
        }
    }
}
