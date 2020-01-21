using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ShowDropBallsCommand : ICommand<ServiceLocator>
    {
        public void ExecuteCommand(ServiceLocator bingoComponent)
        {
            var ballMachine = bingoComponent.GetService<IBallMachineFactory>("ballMachine").CreateBallMachine(bingoComponent);
            ballMachine.ShowExtractedBalls();
        }
    }
}
