using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandGameExecutorFactory : ICommandExecutorFactory<IGameSettingFactory>
    {
        
        public ICommandExecutor<IGameSettingFactory> CreateCommandExecutor()
        {
            var gameExecute = new CommandExecutor<IGameSettingFactory>();
            gameExecute.AddToDictionary("Bingo", new GameMenuCommand());

            return gameExecute;
        }
    }
}
