using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class MatrixStatistics<T> where T : new()
    {
        public MatrixStatistics(IMatrix<T> matrix)
        {
            var result_tuple = Analyze(matrix);
            Sum = result_tuple.Item1;
            Max = result_tuple.Item2;
            NonZero = result_tuple.Item3;
            Avg = (dynamic)Sum / (matrix.Rows * matrix.Columns);
        }
        private Tuple<T, T, int> Analyze(IMatrix<T> matrix)
        {   
            T result_sum = default(T);
            T result_max = matrix.Get(0, 0);
            int non_zero_elements = 0;
            for (int row = 0; row < matrix.Rows; ++row)
            {
                for (int column = 0; column < matrix.Columns; ++column)
                {
                    dynamic element = (dynamic)matrix.Get(row, column);
                    if (!element.Equals(default(T)))
                    {
                        result_sum += element;
                        non_zero_elements++;
                        if (element > result_max) result_max = element;
                    }
                }
            }
            return new Tuple<T, T, int>(result_sum, result_max, non_zero_elements);
        }
        public T Sum { get; } 
        public T Avg { get; }
        public T Max { get; }
        public int NonZero { get; }
    }
}
