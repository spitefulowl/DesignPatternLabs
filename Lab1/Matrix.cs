using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class Matrix<T> : IMatrix<T>
    {
        public T Get(int row, int column)
        {
            if (row >= Rows || column >= Columns) throw new ArgumentOutOfRangeException();
            return internal_matrix.Get(row * Columns + column);
        }
        public void Set(int row, int column, T value)
        {
            internal_matrix.Set(row * Columns + column, value);
        }
        protected void Init(IVector<T> init_matrix, int rows, int columns)
        {
            internal_matrix = init_matrix;
            _rows = rows;
            _columns = columns;
        }

        private int _rows;
        private int _columns;

        public int Rows { get { return _rows; } }
        public int Columns { get { return _columns; } }
        protected IVector<T> internal_matrix;
    }
}
