using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class VerticalLineFourPattern : IPattern
    {
        public List<string> IsThisPatternPosition(ICard card)
        {
            var pattern = new List<string>();
            var cardBoard = card.GetCardBoard();

            pattern.Add(cardBoard[3, 0]);
            pattern.Add(cardBoard[3, 1]);
            pattern.Add(cardBoard[3, 2]);
            pattern.Add(cardBoard[3, 3]);
            pattern.Add(cardBoard[3, 4]);

            return pattern;
        }
    }
}
