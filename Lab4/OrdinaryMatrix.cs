using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class OrdinaryMatrix<T> : Matrix<T>
    {
        public OrdinaryMatrix(int rows, int columns) : 
            base(new OrdinaryVector<T>(rows * columns), rows, columns) { }

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawBorder(Rows, Columns);
            for (int row = 0; row < Rows; ++row)
            {
                for (int column = 0; column < Columns; ++column)
                {
                    drawer.DrawCellBorder(row, column);
                    drawer.DrawCellValue(row, column, Convert.ToInt32(Get(row, column)));
                }
            }
        }
    }
}
