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

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawBorder(Rows, Columns);
            for (int row = 0; row < Rows; ++row)
            {
                for (int column = 0; column < Columns; ++column)
                {
                    int my_value = Convert.ToInt32(Get(row, column));
                    if (my_value != 0)
                    {
                        drawer.DrawCellBorder(row, column);
                        drawer.DrawCellValue(row, column, my_value);
                    }
                }
            }
        }
    }
}
