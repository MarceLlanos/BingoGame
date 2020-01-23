using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HorizontalLineFourPattern:IPattern
    {
        public List<string> IsThisPatternPosition(ICard card)
        {
            var pattern = new List<string>();
            var cardBoard = card.GetCardBoard();

            pattern.Add(cardBoard[0, 3]);
            pattern.Add(cardBoard[1, 3]);
            pattern.Add(cardBoard[2, 3]);
            pattern.Add(cardBoard[3, 3]);
            pattern.Add(cardBoard[4, 3]);

            return pattern;
        }
    }
}
