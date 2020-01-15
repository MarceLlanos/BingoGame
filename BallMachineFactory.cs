using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BallMachineFactory : IBallMachineFactory
    {
        IGameDataSetting gameDataSetting;

        public BallMachineFactory(IGameDataSetting gameDataSetting)
        {
            this.gameDataSetting = gameDataSetting;
        }

        public IBallMachine CreateBallMachine(ServiceLocator service)
        {
            var ballMachine = service.GetService<IBallMachine>("ballMachine");
            var quantityOfBalls = gameDataSetting.GetGameData().GetQuantityOfBalls();

            ballMachine.SetQuantityBalls(quantityOfBalls);
            return ballMachine;
        }
    }
}
