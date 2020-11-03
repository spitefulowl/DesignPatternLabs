using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class CommandManager
    {
        private CommandManager()
        {
            my_commands = new List<ICommand>();
        }

        public static CommandManager GetInstance()
        {
            if (instance == null)
            {
                instance = new CommandManager();
            }
            return instance;
        }

        public void Register(ICommand command)
        {
            if (my_register_flag)
            {
                my_commands.Add(command);
            }
        }

        public void Undo()
        {
            if (my_commands.Count <= 1) return;
            my_register_flag = false;
            my_commands.RemoveAt(my_commands.Count - 1);
            my_commands.ForEach(command => command.Execute());
            my_register_flag = true;
        }

        private bool my_register_flag = true;
        private List<ICommand> my_commands;

        private static CommandManager instance = null;
    }
}
