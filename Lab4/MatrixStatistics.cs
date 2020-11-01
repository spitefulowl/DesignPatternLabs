using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class MatrixStatistics
    {
        public MatrixStatistics(Matrix<int> matrix)
        {
            var result_tuple = Analyze(matrix);
            Sum = result_tuple.Item1;
            Max = result_tuple.Item2;
            NonZero = result_tuple.Item3;
            Avg = (double)(Sum) / (matrix.Rows * matrix.Columns);
        }
        private Tuple<int, int, int> Analyze(Matrix<int> matrix)
        {   
            int result_sum = default;
            int result_max = matrix.Get(0, 0);
            int non_zero_elements = 0;
            for (int row = 0; row < matrix.Rows; ++row)
            {
                for (int column = 0; column < matrix.Columns; ++column)
                {
                    dynamic element = (dynamic)matrix.Get(row, column);
                    if (!element.Equals(default(int)))
                    {
                        result_sum += element;
                        non_zero_elements++;
                        if (element > result_max) result_max = element;
                    }
                }
            }
            return new Tuple<int, int, int>(result_sum, result_max, non_zero_elements);
        }
        public int Sum { get; } 
        public double Avg { get; }
        public int Max { get; }
        public int NonZero { get; }
    }
}
