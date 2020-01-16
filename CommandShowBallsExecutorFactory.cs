using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandShowBallsExecutorFactory : ICommandExecutorFactory<IBallMachine>
    {
        public ICommandExecutor<IBallMachine> CreateCommandExecutor()
        {
            var showBallsExecute = new CommandExecutor<IBallMachine>();
            showBallsExecute.AddToDictionary("SHOW BALLS", new ShowBallsCommand());

            return showBallsExecute;
        }
    }
}
