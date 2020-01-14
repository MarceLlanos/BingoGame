using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BallsGenerator : IBallsGenerator
    {
        List<IBall> balls;
        int quantityOfBalls;

        public BallsGenerator(int quantityOfBalls)
        {
            this.quantityOfBalls = quantityOfBalls;
            balls = new List<IBall>();
        }

        public List<IBall> GenerateBalls()
        {
            int ballNumber = 0;
            IBall ball = null;

            for (int i = 0; i < quantityOfBalls; i++)
            {
                ballNumber += 1;
                ball = new Ball(ballNumber, false);
                balls.Add(ball);
            }

            return balls;
        }

        public void SetQuantityOfBallsToGenerate(int quantityOfBalls)
        {
            this.quantityOfBalls = quantityOfBalls;
        }
    }
}
