using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class RenumberedMatrix<T> : IMatrix<T>
    {

        public RenumberedMatrix(IMatrix<T> matrix)
        {
            internal_matrix = matrix ?? throw new ArgumentNullException();
            renumbered_rows = new Dictionary<int, int>();
            renumbered_columns = new Dictionary<int, int>();
        }

        public void ForEach(MatrixFunctor<T> functor)
        {
            for (int row = 0; row < Rows; ++row)
            {
                for (int column = 0; column < Columns; ++column)
                {
                    functor(row, column, Get(row, column));
                }
            }
        }

        public T Get(int row, int column)
        {
            if (row >= Rows || column >= Columns) throw new ArgumentOutOfRangeException();
            var indexes_pair = GetIndexesPair(row, column);
            return internal_matrix.Get(indexes_pair.Item1, indexes_pair.Item2);
        }

        public void Set(int row, int column, T value)
        {
            if (row >= Rows || column >= Columns) throw new ArgumentOutOfRangeException();
            var indexes_pair = GetIndexesPair(row, column);
            internal_matrix.Set(indexes_pair.Item1, indexes_pair.Item2, value);
        }

        public void RenumberRow(int row_idx, int new_row_idx)
        {
            renumbered_rows[row_idx] = new_row_idx;
            renumbered_rows[new_row_idx] = row_idx;
        }

        public void RenumberColumn(int column_idx, int new_column_idx)
        {
            renumbered_columns[column_idx] = new_column_idx;
            renumbered_columns[new_column_idx] = column_idx;
        }

        public IMatrix<T> GetComponent()
        {
            return internal_matrix.GetComponent();
        }

        private Tuple<int, int> GetIndexesPair(int row, int column)
        {
            int row_idx = GetIdx(renumbered_rows, row);
            int column_idx = GetIdx(renumbered_columns, column);
            return new Tuple<int, int>(row_idx, column_idx);
        }

        private int GetIdx(Dictionary<int, int> renumbered, int idx)
        {
            int real_idx = 0;
            renumbered.TryGetValue(idx, out real_idx);
            if (real_idx == 0)
            {
                real_idx = idx;
            }
            return real_idx;
        }

        public int Rows { get { return internal_matrix.Rows; } }
        public int Columns { get { return internal_matrix.Columns; } }
        private IMatrix<T> internal_matrix;
        private Dictionary<int, int> renumbered_rows;
        private Dictionary<int, int> renumbered_columns;
    }
}
