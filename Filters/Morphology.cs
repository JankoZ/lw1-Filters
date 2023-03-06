using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class Morphology : MatrixFilter
    {
        public Morphology() 
        {
            kernel = new float[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 1, 0 } };
        }
        public Morphology(float[,] struct_elem)
        {
            kernel = struct_elem;
        }
        public void setStructElem()
        {

        }
    }
}
