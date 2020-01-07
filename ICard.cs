using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface ICard
    {
        int GetQuantityBalls();
        void SetQuantityBalls(int balls);
        IRange GetRange();
        //string[,] DrawCard(List<int> columnNumber);
        void DrawCard(List<int> columnNumber, int column);
        void BlankSpaces(List<int> rowBlankSpaces);
        void showCard();


    }
}
