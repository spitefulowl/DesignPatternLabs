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

        public override void ForEach(MatrixFunctor<T> functor)
        {
            for (int row = 0; row < Rows; ++row)
            {
                for (int column = 0; column < Columns; ++column)
                {
                    int my_value = Convert.ToInt32(Get(row, column));
                    if (my_value != 0)
                    {
                        functor(row, column, Get(row, column));
                    }
                }
            }
        }
    }
}
