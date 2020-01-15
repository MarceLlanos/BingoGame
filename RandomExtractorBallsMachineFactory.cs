using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RandomExtractorBallsMachineFactory : IRandomExtractorBallsMachineFactory
    {
        IGameDataSetting gameData;

        public RandomExtractorBallsMachineFactory(IGameDataSetting gameData)
        {
            this.gameData = gameData;
        }

        public IRandomExtractorBallsMachine CreateRandomExtractorBallsMachine( int quantityBallsToExtract)
        {
            var service = new ServiceLocator();
            var ballMachine = new BallMachineFactory(gameData).CreateBallMachine(service);
            var unExtractedBalls = new UnExtractedBalls(ballMachine);

            return new RandomExtractorBallsMachine(unExtractedBalls, quantityBallsToExtract);
        }
    }
}
