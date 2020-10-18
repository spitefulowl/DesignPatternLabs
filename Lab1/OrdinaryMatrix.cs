using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class OrdinaryMatrix<T> : Matrix<T>
    {
        public OrdinaryMatrix(int rows, int columns)
        {
            OrdinaryVector<T> init_matrix = new OrdinaryVector<T>(rows * columns);
            Init(init_matrix, rows, columns);
        }

        internal InitMatrix InitMatrix
        {
            get => default;
            set
            {
            }
        }
    }
}
