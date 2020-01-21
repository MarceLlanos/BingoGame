using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class GameConfigurationFactory : IGameConfigurationFactory
    {
        public IGameConfiguration CreateGameSetting(ServiceLocator service)
        {
            var userConfiguration = service.GetService<IUserInputConfiguration>("userConfiguration");
            var optionNumber = userConfiguration.GetOptionGame();
            var quantityOfCards = userConfiguration.GetQuantityOfCards();
            var optionToWin = userConfiguration.GetOptionToWin();
            var cardData = service.GetService<ICardDataFactory>("cardDataFactory").CreateCardData(optionNumber);
            var gameData = service.GetService<IGameDataFactory>("gameDataFactory").CreateGameData(optionNumber, quantityOfCards);

            return new GameConfiguration(cardData, gameData, optionToWin);
        }
    }

}