using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardFactory : ICardFactory
    {
        public ICard CreateCard(IGameDataSetting gameDataSetting)
        {
            var columnNumbers = gameDataSetting.GetCardData().GetColumnNumber();
            var rowNumbers = gameDataSetting.GetCardData().GetRowNumber();
            var cardBoard = new string[columnNumbers, rowNumbers];

            return new Card(cardBoard);
        }
    }
}
