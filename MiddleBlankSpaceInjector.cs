using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class MiddleBlankSpaceInjector:IBlankSpaceInjector
    {

        public ICard InjectBlankSpace(ICard card, IGameDataSetting gameDataSetting)
        {
            var columnNumber = gameDataSetting.GetCardData().GetColumnNumber();
            var rowNumber = gameDataSetting.GetCardData().GetRowNumber();

            decimal columnDivition = columnNumber / 2;
            decimal rowDivition = rowNumber / 2;

            var middleColumn = Math.Floor(columnDivition);
            var middleRow = Math.Floor(rowDivition);
            var cardBoard = card.GetCard();

            cardBoard[decimal.ToInt32(middleColumn), decimal.ToInt32(middleRow)] = " * ";

            return card;
        }
    }
}
