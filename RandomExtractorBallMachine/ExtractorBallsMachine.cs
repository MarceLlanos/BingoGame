using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ExtractorBallsMachine : IExtractorBallsMachine
    {
        IRandomNumbersGenerator randomNumbers;
        public ExtractorBallsMachine()
        {
            randomNumbers = new RandomNumbersGenerator();
        }

        public List<IBall> ExtractBallsFromMachine( int quantityOfExtraction)
        {
            return null;
        }
    }
}
