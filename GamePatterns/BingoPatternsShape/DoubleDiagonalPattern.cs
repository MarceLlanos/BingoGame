using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class DoubleDiagonalPattern : IPatternShape
    {
        IPatternShape pattern;

        public List<string> PatternShape(ICard card)
        {
            var pattern = new List<string>();
            var cardBoard = card.GetCardBoard();

            pattern.Add(cardBoard[0, 0]);
            pattern.Add(cardBoard[1, 1]);
            pattern.Add(cardBoard[2, 2]);
            pattern.Add(cardBoard[3, 3]);
            pattern.Add(cardBoard[4, 4]);
            pattern.Add(cardBoard[4, 0]);
            pattern.Add(cardBoard[3, 1]);
            pattern.Add(cardBoard[1, 3]);
            pattern.Add(cardBoard[0, 4]);

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
