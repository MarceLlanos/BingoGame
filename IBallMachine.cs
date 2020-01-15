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
        void SetQuantityBalls(int quantityOfBall);
        void ShowBallMachine();

    }
}
