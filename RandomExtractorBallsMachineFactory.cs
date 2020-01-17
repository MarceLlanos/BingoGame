using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RandomExtractorBallsMachineFactory : IRandomExtractorBallsMachineFactory
    {
        public IRandomExtractorBallsMachine CreateRandomExtractorBallsMachine( ServiceLocator service, int quantityBallsToExtract)
        {

            var ballMachine = service.GetService<IBallMachine>("ballsMachine");
            var unExtractedBalls = new UnExtractedBalls(ballMachine);
            var extractorMachine = new RandomExtractorBallsMachine(unExtractedBalls);
            extractorMachine.ExtractRandomBallsFromMachine(quantityBallsToExtract);

            return extractorMachine;
        }
    }
}
