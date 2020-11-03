using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class GraphicsDrawer : IDrawer
    {
        public GraphicsDrawer(Graphics Canvas, bool BorderFlag = true)
        {
            my_graphics_canvas = Canvas;
            my_border_flag = BorderFlag;
        }
        public void DrawBorder(int rows, int columns)
        {
            my_graphics_canvas.Clear(Color.White);
            if (my_border_flag)
            {
                my_graphics_canvas.DrawRectangle(MY_PEN, LEFT_X_BEGIN, LEFT_Y_BEGIN,
                    (CELL_WIDTH + CELL_INDENTION) * columns + INDENTION * 2 - CELL_INDENTION, 
                    (CELL_HEIGHT + CELL_INDENTION) * rows + INDENTION * 2 - CELL_INDENTION);
            }
        }
        private Rectangle MakeRectangle(int row, int column)
        {
            Point begin_point = new Point(LEFT_X_BEGIN + INDENTION + column * (CELL_INDENTION + CELL_WIDTH),
                LEFT_Y_BEGIN + INDENTION + row * (CELL_INDENTION + CELL_HEIGHT));
            Size rect_size = new Size(CELL_WIDTH, CELL_HEIGHT);
            Rectangle cell_rectangle = new Rectangle(begin_point, rect_size);
            return cell_rectangle;
        }

        public void DrawCellBorder(int row, int column)
        {
            my_graphics_canvas.DrawRectangle(MY_PEN, MakeRectangle(row, column));
        }

        public void DrawCellValue(int row, int column, int value)
        {
            my_graphics_canvas.DrawString(value.ToString(), MY_FONT, MY_BRUSH, MakeRectangle(row, column));
        }

        public void SetBorderFlag(bool flag)
        {
            my_border_flag = flag;
        }
        private const int LEFT_X_BEGIN = 5;
        private const int LEFT_Y_BEGIN = 5;
        private const int INDENTION = 5;
        private const int CELL_INDENTION = 2;
        private const int CELL_WIDTH = 20;
        private const int CELL_HEIGHT = 20;

        private readonly Pen MY_PEN = new Pen(Color.Black);
        private readonly Brush MY_BRUSH = new SolidBrush(Color.DarkBlue);
        private readonly Font MY_FONT = new Font("Arial", 10);

        private Graphics my_graphics_canvas;
        private bool my_border_flag;
    }
}
