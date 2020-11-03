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
        class ValuesParser
        {
            public ValuesParser(MainForm form)
            {
                Rows = Convert.ToInt32(form.RowsBox.Text);
                Columns = Convert.ToInt32(form.ColumnsBox.Text);
                NonZeroValues = Convert.ToInt32(form.NonZeroBox.Text);
                BorderFlag = form.BordersBox.Checked;
            }
            public int Rows { get; }
            public int Columns { get; }
            public int NonZeroValues { get; }
            public bool BorderFlag { get; }
        }

        public MainForm()
        {
            InitializeComponent();
            my_console_drawer = new ConsoleDrawer();
            my_graphics_drawer = new GraphicsDrawer(MatrixCanvas.CreateGraphics());
        }

        private void GenOrdinaryButton_Click(object sender, EventArgs e)
        {
            Clear();
            ValuesParser values = new ValuesParser(this);
            Matrix<int> matrix = new OrdinaryMatrix<int>(values.Rows, values.Columns);
            InitMatrix.FillMatrix(matrix, values.NonZeroValues, 99);
            latest_ordinary_matrix = matrix;
            my_console_drawer.SetBorderFlag(values.BorderFlag);
            my_graphics_drawer.SetBorderFlag(values.BorderFlag);
            Draw(matrix);
        }

        private void GenSparseButton_Click(object sender, EventArgs e)
        {
            Clear();
            ValuesParser values = new ValuesParser(this);
            Matrix<int> matrix = new SparseMatrix<int>(values.Rows, values.Columns);
            InitMatrix.FillMatrix(matrix, values.NonZeroValues, 99);
            latest_sparse_matrix = matrix;
            my_console_drawer.SetBorderFlag(values.BorderFlag);
            my_graphics_drawer.SetBorderFlag(values.BorderFlag);
            Draw(matrix);
        }

        private void Draw(IMatrix<int> matrix)
        {
            matrix.Draw(my_console_drawer);
            matrix.Draw(my_graphics_drawer);
        }

        private void Clear()
        {
            latest_ordinary_matrix = null;
            latest_sparse_matrix = null;
        }

        private IMatrix<int> latest_ordinary_matrix = null;
        private IMatrix<int> latest_sparse_matrix = null;
        private IDrawer my_console_drawer = null;
        private IDrawer my_graphics_drawer = null;

        private IMatrix<int> RenumberMatrix(IMatrix<int> matrix)
        {
            Random random = new Random();
            int row_old_idx = random.Next(0, matrix.Rows);
            int row_new_idx = random.Next(0, matrix.Rows);
            int column_old_idx = random.Next(0, matrix.Columns);
            int column_new_idx = random.Next(0, matrix.Columns);
            RenumberedMatrix<int> renumbered_matrix = new RenumberedMatrix<int>(matrix);
            renumbered_matrix.RenumberRow(row_old_idx, row_new_idx);
            renumbered_matrix.RenumberColumn(column_old_idx, column_new_idx);
            return renumbered_matrix;
        }

        private void RenumberButton_Click(object sender, EventArgs e)
        {
            if (latest_ordinary_matrix != null)
            {
                latest_ordinary_matrix = RenumberMatrix(latest_ordinary_matrix);
                Draw(latest_ordinary_matrix);
            }

            if (latest_sparse_matrix != null)
            {
                latest_sparse_matrix = RenumberMatrix(latest_sparse_matrix);
                Draw(latest_sparse_matrix);
            }
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            if (latest_ordinary_matrix != null)
            {
                latest_ordinary_matrix = latest_ordinary_matrix.GetComponent();
                Draw(latest_ordinary_matrix);
            }

            if (latest_sparse_matrix != null)
            {
                latest_sparse_matrix = latest_sparse_matrix.GetComponent();
                Draw(latest_sparse_matrix);
            }
        }

        private void MatrixGroupButton_Click(object sender, EventArgs e)
        {
            OrdinaryMatrix<int> matrix_first = new OrdinaryMatrix<int>(3, 3);
            OrdinaryMatrix<int> matrix_second = new OrdinaryMatrix<int>(2, 4);
            OrdinaryMatrix<int> matrix_third = new OrdinaryMatrix<int>(5, 3);
            InitMatrix.FillMatrix(matrix_first, 9, 42);
            InitMatrix.FillMatrix(matrix_second, 8, 42);
            InitMatrix.FillMatrix(matrix_third, 15, 42);
            HorizontalMatrixGroup<int> group_first = new HorizontalMatrixGroup<int>();
            group_first.AddMatrix(matrix_first);
            group_first.AddMatrix(matrix_second);
            group_first.AddMatrix(matrix_third);

            OrdinaryMatrix<int> matrix_fourth = new OrdinaryMatrix<int>(4, 4);
            OrdinaryMatrix<int> matrix_fifth = new OrdinaryMatrix<int>(3, 5);
            InitMatrix.FillMatrix(matrix_fourth, 16, 42);
            InitMatrix.FillMatrix(matrix_fifth, 15, 42);
            HorizontalMatrixGroup<int> group_second = new HorizontalMatrixGroup<int>();
            group_second.AddMatrix(matrix_fourth);
            group_second.AddMatrix(matrix_fifth);

            VerticalMatrixGroup<int> group_final = new VerticalMatrixGroup<int>();
            group_final.AddMatrix(group_first);
            group_final.AddMatrix(group_second);
            group_final.AddMatrix(matrix_first);
            group_final.Draw(my_graphics_drawer);
        }
    }
}
