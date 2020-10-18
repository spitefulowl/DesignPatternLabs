using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class SparseMatrix<T> : Matrix<T>
    {
        public SparseMatrix(int rows, int columns)
        {
            SparseVector<T> init_matrix = new SparseVector<T>(rows * columns);
            Init(init_matrix, rows, columns);
        }
    }
}
