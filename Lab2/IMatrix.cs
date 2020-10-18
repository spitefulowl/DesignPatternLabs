using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface IMatrix<T>
    {
        T Get(int row, int column);
        void Set(int row, int column, T value);
        int Rows { get; }
        int Columns { get; }
        void Draw(IDrawer drawer);
    }
}
