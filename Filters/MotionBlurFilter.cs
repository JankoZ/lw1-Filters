using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class MotionBlurFilter : MatrixFilter
    {
        public MotionBlurFilter(int n) 
        {
            kernel = new float[n, n];

            for (int i = 0; i != n; i++) for (int j = 0; j != n; j++)
            {
                if (i == j) kernel[i, j] = 1;
                else kernel[i, j] = 0;
                kernel[i, j] /= n;
            }
        }
    }
}