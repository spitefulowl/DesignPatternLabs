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

        public override void ForEach(Action<int, int, T> action)
        {
            for (int row = 0; row < Rows; ++row)
            {
                for (int column = 0; column < Columns; ++column)
                {
                    action(row, column, Get(row, column));
                }
            }
        }
    }
}
