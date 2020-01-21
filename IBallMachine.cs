using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IBallMachine
    {
        List<IBall> BallMaker(IBall ball);
        void SetQuantityOfBalls(int quantityOfBalls);
        List<IBall> GetBalls(int quantityOfBallsToExtract);
        void ShowBallMachine();
        void ShowExtractedBalls();
        void SetBalls(List<IBall> balls);
        List<IBall> GetExtractedBalls();
        List<IBall> GetUnExtractedBalls();
    }
}
