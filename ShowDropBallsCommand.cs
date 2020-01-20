using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ShowDropBallsCommand : ICommand<IBallMachineFactory>
    {
        ServiceLocator service;

        public ShowDropBallsCommand()
        {
            service = new ServiceLocator();
        }
        public void ExecuteCommand(IBallMachineFactory bingoComponent)
        {
            bingoComponent.CreateBallMachine(service).ShowExtractedBalls();
        }
    }
}
