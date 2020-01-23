using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IBallMachine
    {
        void BallMaker(IBall ball, int quantityOfBalls);
        List<IBall> GetBalls(int quantityOfBallsToExtract);
        void ShowBallMachine();
        void ShowAllExtractedBalls();
        void ShowExtractedBalls();
        List<IBall> GetExtractedBalls();
        List<IBall> GetUnExtractedBalls();
    }
}
