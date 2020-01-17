using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandDropBallsExecutorFactory : ICommandExecutorFactory<IRandomExtractorBallsMachine>
    {
        public ICommandExecutor<IRandomExtractorBallsMachine> CreateCommandExecutor()
        {
            var dropBallsExecute = new CommandExecutor<IRandomExtractorBallsMachine>();
            
            dropBallsExecute.AddToDictionary("SHOW TAKE OFF BALLS", new ShowDropBallsCommand());

            return dropBallsExecute;
        }
    }
}
