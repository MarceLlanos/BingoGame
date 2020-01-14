using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IBallsMachine
    {
        List<IBall> MachineBalls();
        void SetQuantityOfBallsToGenerate(int quantityOfBalls);

    }
}
