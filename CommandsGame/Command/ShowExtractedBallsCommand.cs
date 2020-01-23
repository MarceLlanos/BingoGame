using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ShowExtractedBallsCommand : ICommand<ServiceLocator>
    {
        public void ExecuteCommand(ServiceLocator bingoComponent)
        {
            var ballMachine = bingoComponent.GetService<IBallMachine>("ballMachine");
            ballMachine.ShowExtractedBalls();
        }
    }
}
