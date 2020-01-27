using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class TwoLineTwoPattern : IPattern
    {
        IPattern pattern;

        public List<bool> ShapeOfThePattern(ICard card)
        {
            var pattern = new List<bool>();
            var cardBoard = card.GetCardBoard();

            pattern.Add(cardBoard[0, 2].IsCrossoutTheCell());
            pattern.Add(cardBoard[1, 2].IsCrossoutTheCell());
            pattern.Add(cardBoard[2, 2].IsCrossoutTheCell());
            pattern.Add(cardBoard[3, 2].IsCrossoutTheCell());
            pattern.Add(cardBoard[4, 2].IsCrossoutTheCell());
            pattern.Add(cardBoard[5, 2].IsCrossoutTheCell());
            pattern.Add(cardBoard[6, 2].IsCrossoutTheCell());
            pattern.Add(cardBoard[7, 2].IsCrossoutTheCell());
            pattern.Add(cardBoard[8, 2].IsCrossoutTheCell());
            pattern.Add(cardBoard[0, 1].IsCrossoutTheCell());
            pattern.Add(cardBoard[1, 1].IsCrossoutTheCell());
            pattern.Add(cardBoard[2, 1].IsCrossoutTheCell());
            pattern.Add(cardBoard[3, 1].IsCrossoutTheCell());
            pattern.Add(cardBoard[4, 1].IsCrossoutTheCell());
            pattern.Add(cardBoard[5, 1].IsCrossoutTheCell());
            pattern.Add(cardBoard[6, 1].IsCrossoutTheCell());
            pattern.Add(cardBoard[7, 1].IsCrossoutTheCell());
            pattern.Add(cardBoard[8, 1].IsCrossoutTheCell());

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

        public IPattern SetNextPattern(IPattern pattern)
        {
            this.pattern = pattern;

            return this.pattern;
        }

        public string GetPatternName()
        {
            return "Two Lines";
        }
    }
}
