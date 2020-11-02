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
        class ParsedValues
        {
            public ParsedValues(MainForm form)
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
            ParsedValues values = new ParsedValues(this);
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
            ParsedValues values = new ParsedValues(this);
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
    }
}
