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
        IUnExtractedBalls unextractedBalls; 
        int quantityToExtraction;

        public RandomExtractorBallsMachine(IUnExtractedBalls unextractedBalls, int quantityToExtraction)
        {
            this.unextractedBalls = unextractedBalls;
            this.quantityToExtraction = quantityToExtraction;
            randomNumbers = new RandomNumbersGenerator();
        }

        public List<IBall> ExtractRandomBallsFromMachine()
        {
            var balls = unextractedBalls.GetUnExtracteBalls();
            var ballsQuantity = balls.Count;
            var range = new Range(0, ballsQuantity-1);
            var result = new List<IBall>();

            if (ballsQuantity <= quantityToExtraction)
            {
                return result = balls;
            }

            var randomPositions = randomNumbers.GenerateDistinctRandomNumbers(range, quantityToExtraction);

            for (int i = 0; i < randomPositions.Count; i++)
            {
                var ball = balls[randomPositions[i]];
                ball.SetIsExtracted(true);
                result.Add(ball);
            }

            return result;
        }
    }
}
