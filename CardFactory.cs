using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardFactory : ICardFactory
    {
        public ICard CreateCard(ServiceLocator service)
        {
            var gameconfiguration = service.GetService<IGameConfigurationFactory>("gameConfiguration").CreateGameSetting(service);
            var columnNumbers = gameconfiguration.GetCardData().GetColumnNumber();
            var rowNumbers = gameconfiguration.GetCardData().GetRowNumber();
            var cardBoard = new string[columnNumbers, rowNumbers];

            return new Card(cardBoard);
        }
    }
}
