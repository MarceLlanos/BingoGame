using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class SquarePattern : IPattern
    {
        public List<string> IsThisPatternPosition(ICard card)
        {
            var pattern = new List<string>();
            var cardBoard = card.GetCardBoard();

            pattern.Add(cardBoard[0, 0]);
            pattern.Add(cardBoard[0, 1]);
            pattern.Add(cardBoard[0, 2]);
            pattern.Add(cardBoard[0, 3]);
            pattern.Add(cardBoard[0, 4]);
            pattern.Add(cardBoard[1, 4]);
            pattern.Add(cardBoard[2, 4]);
            pattern.Add(cardBoard[3, 4]);
            pattern.Add(cardBoard[4, 4]);
            pattern.Add(cardBoard[0, 4]);
            pattern.Add(cardBoard[4, 3]);
            pattern.Add(cardBoard[4, 2]);
            pattern.Add(cardBoard[4, 1]);
            pattern.Add(cardBoard[4, 0]);
            pattern.Add(cardBoard[3, 0]);
            pattern.Add(cardBoard[2, 0]);
            pattern.Add(cardBoard[1, 0]);
            pattern.Add(cardBoard[0, 0]);

            return pattern;
        }
    }
}
