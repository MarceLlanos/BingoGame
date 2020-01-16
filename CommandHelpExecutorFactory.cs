using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandHelpExecutorFactory : ICommandExecutorFactory<HelpAction>
    {
        public ICommandExecutor<HelpAction> CreateCommandExecutor()
        {
            var helpExecute = new CommandExecutor<HelpAction>();
            helpExecute.AddToDictionary("HELP", new HelpCommand());

            return helpExecute;
        }
    }
}
