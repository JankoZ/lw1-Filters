using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class MorphologyErosion : Morphology
    {
        public MorphologyErosion(float[,] krn)
        {
            kernel = krn;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            Color resultColor = Color.White;
            Color min = Color.White;

            for (int k = -radiusY; k <= radiusY; k++)
            {
                for (int l = -radiusX; l <= radiusX; l++)
                {
                    int idX = Clamp(i + l, 0, sourceImage.Width - 1);
                    int idY = Clamp(j + k, 0, sourceImage.Height - 1);
                    if (kernel.GetLength(0) % 2 != 0)
                        if (kernel[l + radiusX, k + radiusY] == 1)
                        {
                            if (sourceImage.GetPixel(idX, idY).R < min.R)
                            min = sourceImage.GetPixel(idX, idY);
                            else if (sourceImage.GetPixel(idX, idY).R == min.R && sourceImage.GetPixel(idX, idY).G < min.G) min = sourceImage.GetPixel(idX, idY);
                            else if (sourceImage.GetPixel(idX, idY).R == min.R && sourceImage.GetPixel(idX, idY).G == min.G && sourceImage.GetPixel(idX, idY).B < min.B) min = sourceImage.GetPixel(idX, idY);
                        }
                }
                resultColor = Color.FromArgb(min.R, min.G, min.B);
            }

            return resultColor;
        }
    }
}
