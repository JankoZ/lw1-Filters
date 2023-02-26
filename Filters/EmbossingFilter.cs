using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class EmbossingFilter : MatrixFilter
    {
        public EmbossingFilter()
        {
            const int sizeX = 3;
            const int sizeY = 3;
            kernel = new float[sizeX, sizeY] { { 0, 1, 0 }, { 1, 0, -1 }, { 0, -1, 0 } };
        }
    }
}
