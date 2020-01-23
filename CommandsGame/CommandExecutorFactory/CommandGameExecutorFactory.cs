using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandGameExecutorFactory : ICommandExecutorFactory<IUserInputConfiguration>
    {
        
        public ICommandExecutor<IUserInputConfiguration> CreateCommandExecutor()
        {
            var gameExecute = new CommandExecutor<IUserInputConfiguration>();
            gameExecute.AddToDictionary("Bingo", null);

            return gameExecute;
        }
    }
}
