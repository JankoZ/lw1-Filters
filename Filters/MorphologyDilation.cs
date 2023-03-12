using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class MorphologyDilation : Morphology
    {
        public MorphologyDilation(float[,] krn)
        {
            kernel = krn;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            Color resultColor = Color.Black;
            Color max = Color.Black;

            for (int k = -radiusY; k <= radiusY; k++)
            {
                for (int l = -radiusX; l <= radiusX; l++)
                {
                    int idX = Clamp(i + l, 0, sourceImage.Width - 1);
                    int idY = Clamp(j + k, 0, sourceImage.Height - 1);
                    if (kernel[l + radiusX, k + radiusY] == 1)
                    {
                        if (sourceImage.GetPixel(idX, idY).R > max.R)
                            max = sourceImage.GetPixel(idX, idY);
                        else if (sourceImage.GetPixel(idX, idY).R == max.R && sourceImage.GetPixel(idX, idY).G > max.G) max = sourceImage.GetPixel(idX, idY);
                        else if (sourceImage.GetPixel(idX, idY).R == max.R && sourceImage.GetPixel(idX, idY).G == max.G && sourceImage.GetPixel(idX, idY).B > max.B) max = sourceImage.GetPixel(idX, idY);
                    }
                }
                resultColor = Color.FromArgb(max.R, max.G, max.B);
            }

            return resultColor;
        }
    }
}