using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class VerticalMatrixGroup<T> : IMatrix<T>
    {
        public VerticalMatrixGroup()
        {
            my_transposed_horizontal_group = new TransposedMatrix<T>(new HorizontalMatrixGroup<T>());
        }

        public int Rows
        {
            get => my_transposed_horizontal_group.Rows;
        }

        public int Columns
        {
            get => my_transposed_horizontal_group.Columns;
        }

        public void ForEach(Action<int, int, T> action)
        {
            for (int row = 0; row < Rows; ++row)
            {
                for (int column = 0; column < Columns; ++column)
                {
                    int my_value = Convert.ToInt32(Get(row, column));
                    if (my_value != 0)
                    {
                        action(row, column, Get(row, column));
                    }
                }
            }
        }

        public T Get(int row, int column)
        {
            return my_transposed_horizontal_group.Get(row, column);
        }

        public IMatrix<T> GetComponent()
        {
            return this;
        }

        public void Set(int row, int column, T value)
        {
            my_transposed_horizontal_group.Set(row, column, value);
        }

        public void AddMatrix(IMatrix<T> matrix)
        {
            TransposedMatrix<T> transposed_matrix = new TransposedMatrix<T>(matrix);
            HorizontalMatrixGroup<T> real_group = (HorizontalMatrixGroup<T>)my_transposed_horizontal_group.GetComponent();
            real_group.AddMatrix(transposed_matrix);
        }

        private IMatrix<T> my_transposed_horizontal_group;
    }
}
