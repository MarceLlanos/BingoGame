using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IBallsGenerator
    {
        List<IBall> GenerateBalls();
        void SetQuantityOfBallsToGenerate(int quantityOfBalls);

    }
}
