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

        public BallMachine()
        {
            balls = new List<IBall>();
        }

        public void BallMaker(int quantityOfBalls)
        {
            int ballNumber = 0;
            IBall ball = null;

            for (int i = 0; i < quantityOfBalls; i++)
            {
                ballNumber += 1;
                ball = new Ball(ballNumber, false);
                balls.Add(ball);
            }
        }

        public List<IBall> GetBalls()
        {
            return balls;
        }

        public void ShowBallMachine()
        {
            foreach (var item in balls)
            {
                Console.WriteLine("");
                item.ShowBall();
            }
        }
    }
}
