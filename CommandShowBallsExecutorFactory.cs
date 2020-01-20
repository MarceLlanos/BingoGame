using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandShowBallsExecutorFactory : ICommandExecutorFactory<IBallMachineFactory>
    {
        public ICommandExecutor<IBallMachineFactory> CreateCommandExecutor()
        {
            var showBallsExecute = new CommandExecutor<IBallMachineFactory>();
            showBallsExecute.AddToDictionary("SHOW BALLS", new ShowBallsCommand());
            showBallsExecute.AddToDictionary("SHOW TAKE OFF BALLS ", new ShowDropBallsCommand());

            return showBallsExecute;
        }
    }
}
