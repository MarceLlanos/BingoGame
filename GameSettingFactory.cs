using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class GameSettingFactory : IGameSettingFactory
    {
        public IGameDataSetting CreateGameSetting(int option, int quantityOfCards, int optionToWin)
        {
            var cardData = new CardDataFactory().CreateCardData(option);
            var gameData = new GameDataFactory().CreateGameData(option, quantityOfCards);

            switch (option)
            {
                case 1: return new GameDataSetting(cardData, gameData, optionToWin);
                case 2: return new GameDataSetting(cardData, gameData, optionToWin);
            }

            return new GameDataSetting(cardData, gameData, optionToWin);
        }
    }
}
