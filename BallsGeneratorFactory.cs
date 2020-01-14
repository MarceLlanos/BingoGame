using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BallsGeneratorFactory : IBallsGeneratorFactory
    {
        ServiceLocator serviceLocator;
        IGameDataSetting gameDataSetting;

        public BallsGeneratorFactory(IGameDataSetting gameDataSetting)
        {
            serviceLocator = new ServiceLocator();
            this.gameDataSetting = gameDataSetting;
        }

        public IBallsGenerator CreateBallsGenerator()
        {
            var quantityOfBalls = gameDataSetting.GetGameData().GetQuantityOfBalls();
            IBallsGenerator ballsGenerator = serviceLocator.GetService<IBallsGenerator>("ballsGenerator");
            ballsGenerator.SetQuantityOfBallsToGenerate(quantityOfBalls);
            return ballsGenerator;
        }
    }
}
