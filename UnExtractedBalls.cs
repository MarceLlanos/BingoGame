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

        public UnExtractedBalls(IBallMachine ballMachine)
        {
            this.ballMachine = ballMachine;
        }

        public List<IBall> GetUnExtracteBalls()
        {
            var balls = ballMachine.BallMaker();
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
    }
}
