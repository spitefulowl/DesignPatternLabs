using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab1
{
    class InitMatrix
    {
        private InitMatrix() { }
        public static void FillMatrix(Matrix<int> input, int non_zero_values, int max_value)
        {
            for (int idx = 0; idx < non_zero_values; ++idx)
            {
                Tuple<int, int> indexes = GetNonZeroIndexes(input);
                int r_value = random.Next(max_value) + 1;
                input.Set(indexes.Item1, indexes.Item2, r_value);
            }
        }
        private static Tuple<int, int> GetNonZeroIndexes(Matrix<int> input)
        {
            int m_row_idx = random.Next(input.Rows);
            int m_column_idx = random.Next(input.Columns);
            while (input.Get(m_row_idx, m_column_idx) != 0)
            {
                m_row_idx = random.Next(input.Rows);
                m_column_idx = random.Next(input.Columns);
            }
            return new Tuple<int, int>(m_row_idx, m_column_idx);
        }
        private static Random random = new Random();
    }
}
