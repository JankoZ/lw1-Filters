using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class MorphologyGrad : Morphology
    {
        public MorphologyGrad(Bitmap image, Bitmap tmp)
        {
            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                {
                    Color firstColor = image.GetPixel(i, j);
                    Color secondColor = tmp.GetPixel(i, j);
                    int resR = firstColor.R - secondColor.R;
                    int resG = firstColor.G - secondColor.G;
                    int resB = firstColor.B - secondColor.B;
                    Color resultColor = Color.FromArgb(Clamp(resR, 0, 255), Clamp(resG, 0, 255), Clamp(resB, 0, 255));

                    image.SetPixel(i, j, resultColor);
                }
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            return sourceImage.GetPixel(i, j);
        }
    }
}
