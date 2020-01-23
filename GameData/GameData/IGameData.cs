using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IGameData
    {
        int GetQuantityOfBalls();
        int GetQuantityOfCards();
        void SetQuantityOfBalls(int quantityOfBalls);
        void SetQuantityOfCards(int quantityOfCards);
    }
}
