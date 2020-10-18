using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            SparseMatrix<int> matrix = new SparseMatrix<int>(10, 10);
            InitMatrix.generateMatrix(matrix, 10, 8);
            MatrixStatistics<int> stats = new MatrixStatistics<int>(matrix);
            Console.WriteLine("Sum: {0}, Avg: {1}, Max: {2}, NonZero: {3}", stats.Sum, stats.Avg, stats.Max, stats.NonZero);
            Console.ReadKey();
        }
    }
}
