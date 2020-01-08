using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class MiddleBingoDrawerBlankSpaces:IBlankSpaces
    {
        public ICard DrawBlankSpace(int quantity, ICard card)
        {
            decimal column = card.GetCardData().GetColumn() / 2;
            decimal row = card.GetCardData().GetRow() / 2;

            var middleColumn = Math.Floor(column);
            var middleRow = Math.Floor(row);
            var cardBoard = card.GetCard();

            cardBoard[decimal.ToInt32(middleColumn), decimal.ToInt32(middleRow)] = " ";

            return card;
        }
    }
}
