using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class SobelFilter : MatrixFilter
    {
        public SobelFilter(char orientation)
        {
            const int sizeX = 3;
            const int sizeY = 3;
            switch (orientation)
            {
                case 'X': kernel = new float[sizeX, sizeY] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } }; break;
                case 'Y': kernel = new float[sizeX, sizeY] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } }; break;
            }
        }
    }
}
