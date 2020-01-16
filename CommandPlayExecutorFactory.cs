using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandPlayExecutorFactory:ICommandExecutorFactory<PlayAction>
    {
        
        public ICommandExecutor<PlayAction> CreateCommandExecutor()
        {
            var playExecute = new CommandExecutor<PlayAction>();
            playExecute.AddToDictionary("PLAY", new PlayCommand());
            return playExecute;
        }
    }
}
