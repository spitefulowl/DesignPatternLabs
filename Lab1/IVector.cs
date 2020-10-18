using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface IVector<T>
    {
        T Get(int idx);
        void Set(int idx, T value);
        int Size { get; }
    }
}
