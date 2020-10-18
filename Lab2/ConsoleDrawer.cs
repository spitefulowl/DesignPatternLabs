using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ConsoleDrawer : IDrawer
    {
        public ConsoleDrawer(bool BorderFlag = true)
        {
            my_border_flag = BorderFlag;
        }
        public void DrawBorder(int rows, int columns)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            if (my_border_flag)
            {
                string horizontal_border = new string('-', columns * 3 + INDENTION - 1);
                string internal_horizontal_border = "|" + new string('-', columns * 3 - 1) + "|";
                string empty_seq = new string(' ', columns * 3 - 1); // 2 cells for 2 digits, 1 cell for separator 
                Console.WriteLine(horizontal_border);

                for (int row = 1; row < rows * 2; ++row)
                {
                    if (row > 0 && (row % 2 == 0))
                    {
                        Console.WriteLine(internal_horizontal_border);
                        continue;
                    }
                    Console.WriteLine("|" + empty_seq + "|");
                }
                Console.WriteLine(horizontal_border);
            }
        }

        public void DrawCellBorder(int row, int column)
        {
            Console.SetCursorPosition((column + 1) * 3 - 3, row * 2 + 1);
            Console.Write('|');
            Console.SetCursorPosition((column + 1) * 3, row * 2 + 1);
            Console.Write('|');
        }

        public void DrawCellValue(int row, int column, int value)
        {
            Console.SetCursorPosition(1 + column * 3, row * 2 + 1);
            Console.Write(value);
        }

        public void FlipBorderFlag()
        {
            my_border_flag ^= true;
        }
        private const int INDENTION = 2;
        private bool my_border_flag;
    }
}
