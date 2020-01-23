using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class VerticalLineThreePattern : IPattern
    {
        public List<string> IsThisPatternPosition(ICard card)
        {
            var pattern = new List<string>();
            var cardBoard = card.GetCardBoard();

            pattern.Add(cardBoard[2, 0]);
            pattern.Add(cardBoard[2, 1]);
            pattern.Add(cardBoard[2, 2]);
            pattern.Add(cardBoard[2, 3]);
            pattern.Add(cardBoard[2, 4]);

            return pattern;
        }
    }
}
