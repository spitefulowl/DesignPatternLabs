using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface IDrawer
    {
        void DrawBorder(int rows, int columns);
        void DrawCellBorder(int row, int column);
        void DrawCellValue(int row, int column, int value);
        void SetBorderFlag(bool flag);
    }
}
