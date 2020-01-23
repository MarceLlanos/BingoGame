using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ShowBallsCommand : ICommand<ServiceLocator>
    {
        public void ExecuteCommand(ServiceLocator service)
        {
            var ballMachine = service.GetService<IBallMachine>("ballMachine");
            ballMachine.ShowBallMachine();
        }
    }
}
