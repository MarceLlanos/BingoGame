using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class VerticalLineOnePattern : IPattern
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

            return pattern;
        }
    }
}
