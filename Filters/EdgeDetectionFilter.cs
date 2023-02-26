using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class EdgeDetectionFilter : MatrixFilter
    {
        public EdgeDetectionFilter(int oper, char orientation)
        {
            const int sizeX = 3;
            const int sizeY = 3;
            if (oper == 0) switch (orientation)
            {
                case 'X': kernel = new float[sizeX, sizeY] { { 3, 0, -3 }, { 10, 0,-10 }, { 3, 0, -3 } }; break;
                case 'Y': kernel = new float[sizeX, sizeY] { { 3, 10, 3 }, { 0, 0, 0 },{ -3, -10, -3 } }; break;
            }
            else switch (orientation)
            {
                case 'X': kernel = new float[sizeX, sizeY] { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } }; break;
                case 'Y': kernel = new float[sizeX, sizeY] { { -1, -1, -1 }, { 0, 0, 0 },{ 1, 1, 1 } }; break;
            }
        }
    }
}
