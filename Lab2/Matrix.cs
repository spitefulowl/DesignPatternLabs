using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class Matrix<T> : IMatrix<T>
    {
        public Matrix(IVector<T> init_matrix, int rows, int columns)
        {
            internal_matrix = init_matrix;
            Rows = rows;
            Columns = columns;
        }
        public T Get(int row, int column)
        {
            if (row >= Rows || column >= Columns) throw new ArgumentOutOfRangeException();
            return internal_matrix.Get(row * Columns + column);
        }
        public void Set(int row, int column, T value)
        {
            internal_matrix.Set(row * Columns + column, value);
        }

        public virtual void Draw(IDrawer drawer)
        {
            drawer.DrawBorder(Rows, Columns);
            for (int row = 0; row < Rows; ++row)
            {
                for (int column = 0; column < Columns; ++column)
                {
                    drawer.DrawCellBorder(row, column);
                    drawer.DrawCellValue(row, column, Convert.ToInt32(Get(row, column)));
                }
            }
        }

        public int Rows { get; }
        public int Columns { get; }
        protected IVector<T> internal_matrix;
    }
}
