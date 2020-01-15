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
        int quantityOfBalls;

        public BallMachine(int quantityOfBalls)
        {
            this.quantityOfBalls = quantityOfBalls;
            balls = new List<IBall>();
        }

        public List<IBall> BallMaker()
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

        public void SetQuantityBalls(int quantityOfBall)
        {
            this.quantityOfBalls = quantityOfBall;
        }

        public void ShowBallMachine()
        {
            foreach (var item in balls)
            {
                Console.WriteLine("");
                item.ShowBall();
                Console.WriteLine("");
            }
        }
    }
}
