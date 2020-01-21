using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IBall
    {
        int GetNumber();
        bool IsExtracted();
        void ShowBall();
        void SetNumberBall(int numberBall);
        void SetIsExtracted(bool extracted);
    }
}
