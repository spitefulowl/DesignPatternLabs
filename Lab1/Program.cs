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
            Matrix<int> ordinary_matrix = new OrdinaryMatrix<int>(10, 10);
            Matrix<int> sparse_matrix = new SparseMatrix<int>(10, 10);
            InitMatrix.generateMatrix(ordinary_matrix, 10, 8);
            InitMatrix.generateMatrix(sparse_matrix, 10, 8);
            MatrixStatistics ordinary_stats = new MatrixStatistics(ordinary_matrix);
            MatrixStatistics sparse_stats = new MatrixStatistics(sparse_matrix);
            Console.WriteLine("Ordinary:  Sum: {0}, Avg: {1}, Max: {2}, NonZero: {3}", ordinary_stats.Sum, 
                ordinary_stats.Avg, ordinary_stats.Max, ordinary_stats.NonZero);
            Console.WriteLine("Sparse:  Sum: {0}, Avg: {1}, Max: {2}, NonZero: {3}", sparse_stats.Sum,
                sparse_stats.Avg, sparse_stats.Max, sparse_stats.NonZero);
            Console.ReadKey();
        }
    }
}
