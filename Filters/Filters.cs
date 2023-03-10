using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    abstract class Filters
    {
        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int width, int height);

        public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            if (sourceImage == null)
            {
                MessageBox.Show("Невоможно применить фильтр!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return sourceImage;
            } 
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i != sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (int j = 0; j != sourceImage.Height; j++) resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
            }

            return resultImage;
        }

        public Bitmap processImage(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i != sourceImage.Width; i++)
            {
                for (int j = 0; j != sourceImage.Height; j++) resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
            }

            return resultImage;
        }

        public int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}
