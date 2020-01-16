using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandShowCardsExecutorFactory : ICommandExecutorFactory<ICardPackage>
    {
        public ICommandExecutor<ICardPackage> CreateCommandExecutor()
        {
            var showExecute = new CommandExecutor<ICardPackage>();
            showExecute.AddToDictionary("SHOW CARDS", new ShowCommand());

            return showExecute;
        }
    }
}
