using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class TransposedMatrix<T> : IMatrix<T>
    {
        public TransposedMatrix(IMatrix<T> matrix)
        {
            internal_matrix = matrix;
        }

        public void Draw(IDrawer drawer)
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

        public T Get(int row, int column)
        {
            if (row >= Rows || column >= Columns) throw new ArgumentOutOfRangeException();
            return internal_matrix.Get(column, row);
        }

        public void Set(int row, int column, T value)
        {
            internal_matrix.Set(column, row, value);
        }

        public IMatrix<T> GetComponent()
        {
            return internal_matrix.GetComponent();
        }

        private IMatrix<T> internal_matrix;
        public int Rows { get { return internal_matrix.Columns; } }
        public int Columns { get { return internal_matrix.Rows; } }
    }
}
