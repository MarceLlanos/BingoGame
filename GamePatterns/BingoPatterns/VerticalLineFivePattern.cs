﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class VerticalLineFivePattern : IPattern
    {
        public List<string> IsThisPatternPosition(ICard card)
        {
            var pattern = new List<string>();
            var cardBoard = card.GetCardBoard();

            pattern.Add(cardBoard[4, 0]);
            pattern.Add(cardBoard[4, 1]);
            pattern.Add(cardBoard[4, 2]);
            pattern.Add(cardBoard[4, 3]);
            pattern.Add(cardBoard[4, 4]);

            return pattern;
        }
    }
}
