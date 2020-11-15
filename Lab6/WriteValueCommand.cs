using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class WriteValueCommand : Command
    {
        public WriteValueCommand(IMatrix<int> matrix, int row, int column, int value)
        {
            my_matrix = matrix;
            my_row = row;
            my_column = column;
            my_value = value;
        }

        private WriteValueCommand(WriteValueCommand command)
        {
            my_matrix = command.my_matrix;
            my_row = command.my_row;
            my_column = command.my_column;
            my_value = command.my_value;
        }

        public override object Clone()
        {
            return new WriteValueCommand(this);
        }

        protected override void doExecute()
        {
            my_matrix.Set(my_row, my_column, my_value);
        }

        private IMatrix<int> my_matrix;
        private int my_row;
        private int my_column;
        private int my_value;
    }
}
