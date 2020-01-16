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
        List<IBall> extractedBalls;

        public RandomExtractorBallsMachine(IUnExtractedBalls unextractedBalls)
        {
            this.unextractedBalls = unextractedBalls;
            randomNumbers = new RandomNumbersGenerator();
        }

        public List<IBall> ExtractRandomBallsFromMachine(int quantityToExtraction)
        {
            var balls = unextractedBalls.GetUnExtracteBalls();
            var ballsQuantity = balls.Count;
            var range = new Range(0, ballsQuantity-1);
            var extractedBalls = new List<IBall>();

            if (ballsQuantity <= quantityToExtraction)
            {
                return extractedBalls = balls;
            }

            var randomPositions = randomNumbers.GenerateDistinctRandomNumbers(range, quantityToExtraction);

            for (int i = 0; i < randomPositions.Count; i++)
            {
                var ball = balls[randomPositions[i]];
                ball.SetIsExtracted(true);
                extractedBalls.Add(ball);
            }

            return extractedBalls;
        }

        public void ShowExtractedBallsFromMachine()
        {
            foreach (var item in extractedBalls)
            {
                item.ShowBall();
            }
        }
    }
}
