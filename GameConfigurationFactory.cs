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
            var cardData = new CardDataFactory().CreateCardData(optionNumber);
            var gameData = new GameDataFactory().CreateGameData(optionNumber, quantityOfCards);

            switch (optionNumber)
            {
                case 1: return new GameConfiguration(cardData, gameData, optionToWin);
                case 2: return new GameConfiguration(cardData, gameData, optionToWin);
            }

            return new GameConfiguration(cardData, gameData, optionToWin);
        }
    }
}
