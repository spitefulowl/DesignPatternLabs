using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    delegate void MatrixFunctor<T>(int row, int column, T value);
    interface IIterable<T>
    {
        void ForEach(MatrixFunctor<T> functor);
    }
}
