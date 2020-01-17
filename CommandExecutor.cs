using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandExecutor<T> : ICommandExecutor<T>
    {
        IDictionary<string, ICommand<T>> commands;

        public CommandExecutor()
        {
            commands = new Dictionary<string, ICommand<T>>();
        }

        public void AddToDictionary(string commandName, ICommand<T> command)
        {
            commands[commandName] = command;
        }

        public void ExecuteCommand(string commandName, T bingoComponent)
        {
            if (commands.ContainsKey(commandName))
            {
                commands[commandName].ExecuteCommand(bingoComponent);
            }

        }
    }
}
