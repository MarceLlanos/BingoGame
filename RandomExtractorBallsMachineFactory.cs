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
            var ballMachine = service.GetService<IBallMachineFactory>("ballMachine").CreateBallMachine(service);
            var extractorMachine = service.GetService<IRandomExtractorBallsMachine>("randomExtracted");
            extractorMachine.ExtractRandomBallsFromMachine(ballMachine, quantityBallsToExtract);

            return extractorMachine;
        }
    }
}
