using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HelpCommand : ICommand<HelpAction>
    {
        public void ExecuteCommand(HelpAction bingoComponent)
        {
            bingoComponent.ShowAction();
        }
    }
}
