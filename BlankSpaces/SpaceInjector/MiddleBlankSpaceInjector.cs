using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class MiddleBlankSpaceInjector:ISpaceInjector
    {

        public ICard InjectSpace(ICard card, IGameConfiguration gameDataSetting)
        {
            var columnNumber = gameDataSetting.GetCardData().GetColumnNumber();
            var rowNumber = gameDataSetting.GetCardData().GetRowNumber();

            decimal columnDivision = columnNumber / 2;
            decimal rowDivision = rowNumber / 2;

            var middleColumn = Math.Floor(columnDivision);
            var middleRow = Math.Floor(rowDivision);
            var cardBoard = card.GetCardBoard();

            cardBoard[decimal.ToInt32(middleColumn), decimal.ToInt32(middleRow)] = " * ";

            return card;
        }
    }
}
