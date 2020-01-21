using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RandomExtractorBallsMachine : IRandomExtractorBallsMachine
    {
        IRandomNumbersGenerator randomNumbers;

        public RandomExtractorBallsMachine()
        {
            randomNumbers = new RandomNumbersGenerator();
        }

        public IBallMachine ExtractRandomBallsFromMachine(IBallMachine ballMachine, int quantityToExtraction)
        {
            var balls = ballMachine.GetUnExtractedBalls();
            var ballsQuantity = balls.Count;
            var range = new Range(0, ballsQuantity-1);

            if (ballsQuantity <= quantityToExtraction)
            {
                foreach (var item in balls)
                {
                    item.SetIsExtracted(true);
                }

                return ballMachine;
            }

            var randomPositions = randomNumbers.GenerateDistinctRandomNumbers(range, quantityToExtraction);

            for (int i = 0; i < randomPositions.Count; i++)
            {
                var ball = balls[randomPositions[i]];
                ball.SetIsExtracted(true);
            }

            return ballMachine;
        }
    }
}
