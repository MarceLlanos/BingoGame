using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandShowCardsExecutorFactory : ICommandExecutorFactory<ICardSetFactory>
    {
        public ICommandExecutor<ICardSetFactory> CreateCommandExecutor()
        {
            var showExecute = new CommandExecutor<ICardSetFactory>();
            showExecute.AddToDictionary("SHOW CARDS", new ShowCardsCommand());

            return showExecute;
        }
    }
}
