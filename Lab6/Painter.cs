using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    static class Painter
    {
        public static void Draw(IMatrix<int> matrix, IDrawer drawer)
        {
            drawer.DrawBorder(matrix.Rows, matrix.Columns);

            matrix.ForEach((row, column, value) =>
            {
                drawer.DrawCellBorder(row, column);
                drawer.DrawCellValue(row, column, value);
            });
        }
    }
}
