using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandExitExecutorFactory : ICommandExecutorFactory<ExitAction>
    {
        public ICommandExecutor<ExitAction> CreateCommandExecutor()
        {
            var exitExecute = new CommandExecutor<ExitAction>();
            exitExecute.AddToDictionary("EXIT", new ExitCommand());

            return exitExecute;
        }
    }
}
