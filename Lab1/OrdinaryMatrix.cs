using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class OrdinaryMatrix<T> : Matrix<T>
    {
        public OrdinaryMatrix(int rows, int columns) : 
            base(new OrdinaryVector<T>(rows * columns), rows, columns) { }
    }
}
