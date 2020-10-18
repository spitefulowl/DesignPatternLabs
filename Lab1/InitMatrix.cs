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
        public static void generateMatrix(IMatrix<int> input, int non_zero_values, int max_value)
        {
            Random random = new Random();
            for (int idx = 0; idx < non_zero_values; ++idx)
            {
                int m_row_idx = random.Next(input.Rows);
                int m_column_idx = random.Next(input.Columns);
                int r_value = random.Next(max_value);
                input.Set(m_row_idx, m_column_idx, r_value);
            }
        }
    }
}
