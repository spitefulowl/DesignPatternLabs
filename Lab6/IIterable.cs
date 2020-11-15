using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface IIterable<T>
    {
        void ForEach(Action<int, int, T> action);
    }
}
