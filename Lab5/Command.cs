using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class Command : ICommand, ICloneable
    {
        public abstract object Clone();

        public void Execute()
        {
            CommandManager manager = CommandManager.GetInstance();
            manager.Register(this.Clone() as Command);
            doExecute();
        }
        protected abstract void doExecute();
    }
}
