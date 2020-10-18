using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class SparseMatrix<T> : Matrix<T>
    {
        public SparseMatrix(int rows, int columns) : 
            base(new SparseVector<T>(rows * columns), rows, columns) { }
    }
}
