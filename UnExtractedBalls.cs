using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class UnExtractedBalls : IUnExtractedBalls
    {
        IBallMachine ballMachine;
        List<IBall> unExtractedBalls;

        public UnExtractedBalls(IBallMachine ballMachine)
        {
            this.ballMachine = ballMachine;
        }

        public List<IBall> GetUnExtracteBalls()
        {
            var balls = ballMachine.GetBalls();
            var unExtractedBalls = new List<IBall>();

            foreach (var item in balls)
            {
                if (item.IsExtracted() == false)
                {
                    unExtractedBalls.Add(item);
                }
            }

            return unExtractedBalls;
        }

        public void ShowUnExtractedBalls()
        {
            int index = 0;
            foreach (var item in GetUnExtracteBalls())
            {
                index += 1;

                Console.WriteLine("Balls {0}:", index);
                item.ShowBall();
            }
        }
    }
}
