using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class FormMenu : IInvoker
    {
        ICommand command;
        ICommandExecutor commandExecutor;

        public void SetGameMenuCommand(ICommand command)
        {
            this.command = command;
        }

        public void SetCommandExecutor(ICommandExecutor commandExecutor)
        {
            this.commandExecutor = commandExecutor;
        }

        public string ShowInputOptionMenu()
        {
            return command.executeInputOption();
        }

        public string ShowInputMenu(string command)
        {
            return commandExecutor.GetCommandFromDictionary(command).executeInputOption();
        }
        
    }
}
