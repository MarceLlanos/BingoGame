using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandShowCardsExecutorFactory : ICommandExecutorFactory<ICardSet>
    {
        public ICommandExecutor<ICardSet> CreateCommandExecutor()
        {
            var showExecute = new CommandExecutor<ICardSet>();
            showExecute.AddToDictionary("SHOW CARDS", new ShowCommand());

            return showExecute;
        }
    }
}
