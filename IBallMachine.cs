using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IBallMachine
    {
        List<IBall> BallMaker();
        void SetQuantityOfBalls(int quantityOfBalls);
        List<IBall> GetBalls();
        void ShowBallMachine();
        void ShowExtractedBalls();
        List<IBall> GetExtractedBalls();
        List<IBall> GetUnExtractedBalls();
    }
}
