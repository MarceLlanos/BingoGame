using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BallsMachineFactory : IBallsMachineFactory
    {
        ServiceLocator serviceLocator;
        IGameDataSetting gameDataSetting;

        public BallsMachineFactory(IGameDataSetting gameDataSetting)
        {
            serviceLocator = new ServiceLocator();
            this.gameDataSetting = gameDataSetting;
        }

        public IBallsMachine CreateBingoBallsMachine()
        {
            var quantityOfBalls = gameDataSetting.GetGameData().GetQuantityOfBalls();
            IBallsMachine ballsGenerator = serviceLocator.GetService<IBallsMachine>("ballsMachine");
            ballsGenerator.SetQuantityOfBallsToGenerate(quantityOfBalls);

            return ballsGenerator;
        }
    }
}
