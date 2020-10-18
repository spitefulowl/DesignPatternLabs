using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenOrdinaryButton_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(RowsBox.Text);
            int columns = Convert.ToInt32(ColumnsBox.Text);
            int non_zero_values = Convert.ToInt32(NonZeroBox.Text);
            bool border_flag = BordersBox.Checked;
            IDrawer my_drawer = new GraphicsDrawer(MatrixCanvas.CreateGraphics(), border_flag);
            Matrix<int> my_matrix = new OrdinaryMatrix<int>(rows, columns);
            InitMatrix.FillMatrix(my_matrix, non_zero_values, 99);
            my_matrix.Draw(my_drawer);
            my_drawer = new ConsoleDrawer(border_flag);
            my_matrix.Draw(my_drawer);
        }

        private void GenSparseButton_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(RowsBox.Text);
            int columns = Convert.ToInt32(ColumnsBox.Text);
            int non_zero_values = Convert.ToInt32(NonZeroBox.Text);
            bool border_flag = BordersBox.Checked;
            IDrawer my_drawer = new GraphicsDrawer(MatrixCanvas.CreateGraphics(), border_flag);
            Matrix<int> my_matrix = new SparseMatrix<int>(rows, columns);
            InitMatrix.FillMatrix(my_matrix, non_zero_values, 99);
            my_matrix.Draw(my_drawer);
            my_drawer = new ConsoleDrawer(border_flag);
            my_matrix.Draw(my_drawer);
        }
    }
}
