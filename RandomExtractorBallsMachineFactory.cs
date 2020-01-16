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

        public IRandomExtractorBallsMachine CreateRandomExtractorBallsMachine( ServiceLocator service, int quantityBallsToExtract)
        {
            var ballMachine = new BallMachineFactory(gameData).CreateBallMachine(service);
            var unExtractedBalls = new UnExtractedBalls(ballMachine);
            var extractorMachine = new RandomExtractorBallsMachine(unExtractedBalls);
            extractorMachine.ExtractRandomBallsFromMachine(quantityBallsToExtract);

            return extractorMachine;
        }
    }
}
