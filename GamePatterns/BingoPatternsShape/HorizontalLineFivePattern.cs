using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HorizontalLineFivePattern:IPatternShape
    {
        IPatternShape pattern;

        public List<string> PatternShape(ICard card)
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

        public bool HasNext()
        {
            if (this.SetNextPattern(this) != null)
            {
                return true;
            }

            return false;
        }

        public IPatternShape SetNextPattern(IPatternShape pattern)
        {
            this.pattern = pattern;

            return this.pattern;
        }

        public bool IsthisFullHousePattern()
        {
            return false;
        }
    }
}
