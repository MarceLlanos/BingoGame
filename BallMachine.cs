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
        int quantityOfBalls;

        public BallMachine(int quantityOfBalls)
        {
            this.quantityOfBalls = quantityOfBalls;
            balls = new List<IBall>();
            unextractedBalls = new List<IBall>();
            extractedBalls = new List<IBall>();
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

        public List<IBall> GetBalls()
        {
            return balls;
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
    }
}
