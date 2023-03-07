using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class MaximumFilter : Filters
    {
        public int radius = 3;

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int width, int height)
        {
            List<Color> color = new List<Color>();
            for (int l = -radius; l <= radius; l++)
                for (int k = -radius; k <= radius; k++)
                {
                    int idX = Clamp(width + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(height + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    color.Add(neighborColor);
                }
            for (int i = 0; i != color.Count; i++)
                for (int j = 0; j != color.Count - 1; j++)
                {
                    if (color[j].R > color[j + 1].R) Swap(color, j);
                    else if ((color[j].R == color[j + 1].R) && (color[j].G > color[j + 1].G)) Swap(color, j);
                    else if ((color[j].R == color[j + 1].R) && (color[j].G == color[j + 1].G) && (color[j].B > color[j + 1].B)) Swap(color, j);
                }
            Color resultColor = Color.FromArgb(color[color.Count - 1].R, color[color.Count - 1].G, color[color.Count - 1].B);

            return resultColor;
        }

        private void Swap(List<Color> color, int j)
        {
            Color tmp = color[j];
            color[j] = color[j + 1];
            color[j + 1] = tmp;
        }
    }
}
