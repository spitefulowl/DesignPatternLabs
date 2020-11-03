using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class SparseVector<T> : IVector<T>
    {
        public SparseVector(int size)
        {
            Size = size;
            internal_vector = new Dictionary<int, T>();
        }
        public int Size { get; }

        public T Get(int idx)
        {
            if (idx >= Size) throw new ArgumentOutOfRangeException();
            T return_value = default(T);
            internal_vector.TryGetValue(idx, out return_value);
            return return_value;
        }

        public void Set(int idx, T value)
        {
            if (idx >= Size) throw new ArgumentOutOfRangeException();
            internal_vector[idx] = value;
        }
        private Dictionary<int, T> internal_vector;
    }
}
