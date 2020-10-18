using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class OrdinaryVector<T> : IVector<T>
    {
        public OrdinaryVector(int size)
        {
            Size = size;
            internal_vector = new T[size];
        }
        public int Size { get; }

        public T Get(int idx)
        {
            if (idx >= Size) throw new ArgumentOutOfRangeException();
            return internal_vector[idx];
        }

        public void Set(int idx, T value)
        {
            if (idx >= Size) throw new ArgumentOutOfRangeException();
            internal_vector[idx] = value;
        }
        private T[] internal_vector;
    }
}
