using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BallMachine : IBallMachine
    {
        List<IBall> balls;
        List<IBall> extractedBalls;
        List<IBall> unextractedBalls;
        
        IRandomNumbersGenerator randomNumbers;
        int quantityOfBalls;

        public BallMachine(int quantityOfBalls)
        {
            this.quantityOfBalls = quantityOfBalls;
            unextractedBalls = new List<IBall>();
            balls = new List<IBall>();
            randomNumbers = new RandomNumbersGenerator();
        }

        public List<IBall> BallMaker(IBall ball)
        {
            int ballNumber = 0;

            for (int i = 0; i < quantityOfBalls; i++)
            {
                ballNumber += 1;
                ball = new Ball(ballNumber);
                ball.SetIsExtracted(false);
                balls.Add(ball);
            }

            return balls;
        }

        public List<IBall> GetBalls(int quantityOfBallsToExtract)
        {
            extractedBalls = new List<IBall>();
            for (int i = 0; i < quantityOfBallsToExtract; i++)
            {
                var ball = this.GetBall();
                extractedBalls.Add(ball);
            }

            return extractedBalls;
        }

        public List<IBall> GetUnExtractedBalls()
        {
            foreach (var item in balls)
            {
                if (item.IsExtracted() == false)
                {
                    unextractedBalls.Add(item);
                }
            }

            return unextractedBalls;
        }

        public List<IBall> GetExtractedBalls()
        {
            foreach (var item in balls)
            {
                if (item.IsExtracted() == true)
                {
                    extractedBalls.Add(item);
                }
            }

            return extractedBalls;
        }

        public void SetQuantityOfBalls(int quantityOfBalls)
        {
            this.quantityOfBalls = quantityOfBalls;
        }


        public void ShowBallMachine()
        {

            foreach (var item in balls)
            {
                Console.Write("");
                item.ShowBall();
            }
        }

        public void ShowExtractedBalls()
        {
            foreach (var item in balls)
            {
                if (item.IsExtracted() == true)
                {
                    Console.Write("");
                    item.ShowBall();
                }

            }
        }

        public void SetBalls(List<IBall> balls)
        {
            this.balls = balls;
        }

        private IBall GetBall()
        {
            IBall result = null;

            while (true)
            {
                var range = new Range(0, quantityOfBalls-1);
                var index = randomNumbers.GenerateDistinctRandomNumbers(range, 1);

                if (!balls[index[0]].IsExtracted())
                {
                    result = balls[index[0]];
                    result.SetIsExtracted(true);
                    break;
                }
            }

            return result;
        }
    }
}
