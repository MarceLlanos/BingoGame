using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandTakeOffBallsExecutorFactory : ICommandExecutorFactory<IRandomExtractorBallsMachineFactory>
    {
        public ICommandExecutor<IRandomExtractorBallsMachineFactory> CreateCommandExecutor()
        {
            var takeOffBallsExecute = new CommandExecutor<IRandomExtractorBallsMachineFactory>();
            takeOffBallsExecute.AddToDictionary("TAKE OFF BALLS", new TakeOffBallsCommand());

            return takeOffBallsExecute;
        }
    }
}
