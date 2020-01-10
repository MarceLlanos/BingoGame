using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class MiddleBlankSpaceInjector:IBlankSpaceInjector
    {
        public ICard InjectBlankSpace(ICard card)
        {
            decimal column = card.GetCardData().GetColumnNumber() / 2;
            decimal row = card.GetCardData().GetRowNumber() / 2;

            var middleColumn = Math.Floor(column);
            var middleRow = Math.Floor(row);
            var cardBoard = card.GetCard();

            cardBoard[decimal.ToInt32(middleColumn), decimal.ToInt32(middleRow)] = " * ";

            return card;
        }
    }
}
