using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class GameSettingFactory : IGameSettingFactory
    {
        public IGameDataSetting CreateGameSetting(int optionNumber, int quantityOfCards, int optionToWin)
        {
            var cardData = new CardDataFactory().CreateCardData(optionNumber);
            var gameData = new GameDataFactory().CreateGameData(optionNumber, quantityOfCards);

            switch (optionNumber)
            {
                case 1: return new GameDataSetting(cardData, gameData, optionToWin);
                case 2: return new GameDataSetting(cardData, gameData, optionToWin);
            }

            return new GameDataSetting(cardData, gameData, optionToWin);
        }
    }
}
