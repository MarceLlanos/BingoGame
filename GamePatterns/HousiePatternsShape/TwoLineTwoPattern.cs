using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class TwoLineTwoPattern : IPatternShape
    {
        IPatternShape pattern;

        public List<string> PatternShape(ICard card)
        {
            var pattern = new List<string>();
            var cardBoard = card.GetCardBoard();

            pattern.Add(cardBoard[0, 2]);
            pattern.Add(cardBoard[1, 2]);
            pattern.Add(cardBoard[2, 2]);
            pattern.Add(cardBoard[3, 2]);
            pattern.Add(cardBoard[4, 2]);
            pattern.Add(cardBoard[5, 2]);
            pattern.Add(cardBoard[6, 2]);
            pattern.Add(cardBoard[7, 2]);
            pattern.Add(cardBoard[8, 2]);
            pattern.Add(cardBoard[0, 1]);
            pattern.Add(cardBoard[1, 1]);
            pattern.Add(cardBoard[2, 1]);
            pattern.Add(cardBoard[3, 1]);
            pattern.Add(cardBoard[4, 1]);
            pattern.Add(cardBoard[5, 1]);
            pattern.Add(cardBoard[6, 1]);
            pattern.Add(cardBoard[7, 1]);
            pattern.Add(cardBoard[8, 1]);

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
