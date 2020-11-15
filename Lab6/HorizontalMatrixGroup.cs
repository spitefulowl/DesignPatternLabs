using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class HorizontalMatrixGroup<T> : IMatrix<T>
    {
        public HorizontalMatrixGroup()
        {
            my_matrices = new List<IMatrix<T>>();
        }
        public void ForEach(Action<int, int, T> action)
        {
            int real_column_offset = 0;
            foreach (IMatrix<T> matrix in my_matrices)
            {
                for (int row = 0; row < matrix.Rows; ++row)
                {
                    for (int column = 0; column < matrix.Columns; ++column)
                    {
                        int my_value = Convert.ToInt32(Get(row, real_column_offset + column));
                        if (my_value != 0)
                        {
                            action(row, real_column_offset + column, Get(row, real_column_offset + column));
                        }
                    }
                }
                real_column_offset += matrix.Columns;
            }
        }

        public T Get(int row, int column)
        {
            T result = default(T);
            try
            {
                if (row >= Rows || column >= Columns) throw new ArgumentOutOfRangeException();
                var matching = FindMatching(column);
                if (matching.Item1 == null) return default(T);
                result = matching.Item1.Get(row, matching.Item2);
            }
            catch (ArgumentOutOfRangeException e) { }
            return result;
        }

        public void Set(int row, int column, T value)
        {
            if (row >= Rows || column >= Columns) throw new ArgumentOutOfRangeException();
            var matching = FindMatching(column);
            matching.Item1.Set(row, matching.Item2, value);
        }

        public void AddMatrix(IMatrix<T> matrix)
        {
            my_matrices.Add(matrix);
        }

        public IMatrix<T> GetComponent()
        {
            return this;
        }

        public int Rows
        {
            get
            {
                return my_matrices.Max(element => element.Rows);
            }
        }
        public int Columns {
            get
            {
                return my_matrices.Sum(element => element.Columns);
            }
        }

        private Tuple<IMatrix<T>, int> FindMatching(int column)
        {
            int current_columns_count = 0;
            IMatrix<T> matching_matrix = null;
            foreach (IMatrix<T> matrix in my_matrices)
            {
                current_columns_count += matrix.Columns;
                if (current_columns_count > column)
                {
                    matching_matrix = matrix;
                    break;
                }
            }
            int real_column = column - (current_columns_count - matching_matrix.Columns);
            return new Tuple<IMatrix<T>, int>(matching_matrix, real_column);
        }

        private List<IMatrix<T>> my_matrices;
    }
}
