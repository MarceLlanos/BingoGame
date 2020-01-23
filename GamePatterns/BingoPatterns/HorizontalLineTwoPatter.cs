using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HorizontalLineTwoPatter:IPattern
    {
        public List<string> IsThisPatternPosition(ICard card)
        {
            var pattern = new List<string>();
            var cardBoard = card.GetCardBoard();

            pattern.Add(cardBoard[0, 1]);
            pattern.Add(cardBoard[1, 1]);
            pattern.Add(cardBoard[2, 1]);
            pattern.Add(cardBoard[3, 1]);
            pattern.Add(cardBoard[4, 1]);

            return pattern;
        }
    }
}
