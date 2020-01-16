using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ShowBallsCommand : ICommand<IBallMachine>
    {
        public void ExecuteCommand(IBallMachine bingoComponent)
        {
            bingoComponent.ShowBallMachine();
        }
    }
}
