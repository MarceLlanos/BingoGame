using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HorizontalLineFivePattern:IPattern
    {
        public List<string> IsThisPatternPosition(ICard card)
        {
            var pattern = new List<string>();
            var cardBoard = card.GetCardBoard();

            pattern.Add(cardBoard[0, 4]);
            pattern.Add(cardBoard[1, 4]);
            pattern.Add(cardBoard[2, 4]);
            pattern.Add(cardBoard[3, 4]);
            pattern.Add(cardBoard[4, 4]);

            return pattern;
        }
    }
}
