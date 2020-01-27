﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class DiagonalInvertedPattern : IPattern
    {
        IPattern pattern;

        public List<bool> ShapeOfThePattern(ICard card)
        {
            var pattern = new List<bool>();
            var cardBoard = card.GetCardBoard();

            pattern.Add(cardBoard[0, 4].IsCrossoutTheCell());
            pattern.Add(cardBoard[3, 1].IsCrossoutTheCell());
            pattern.Add(cardBoard[2, 2].IsCrossoutTheCell());
            pattern.Add(cardBoard[1, 3].IsCrossoutTheCell());
            pattern.Add(cardBoard[0, 4].IsCrossoutTheCell());

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
            return "Diagonal Inverted";
        }
    }
}