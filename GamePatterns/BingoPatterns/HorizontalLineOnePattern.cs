using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HorizontalLineOnePattern : IPattern
    {
        public List<string> IsThisPatternPosition(ICard card)
        {
            var pattern = new List<string>();
            var cardBoard = card.GetCardBoard();

            pattern.Add(cardBoard[0, 0]);
            pattern.Add(cardBoard[1, 0]);
            pattern.Add(cardBoard[2, 0]);
            pattern.Add(cardBoard[3, 0]);
            pattern.Add(cardBoard[4, 0]);

            return pattern;
        }
    }
}
