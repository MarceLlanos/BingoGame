using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class GameDataSetting : IGameDataSetting
    {
        ICardData cardData;
        IGameData gameData;
        int optionToWin;

        public GameDataSetting( ICardData cardData, IGameData gameData, int optionToWin)
        {
            this.cardData = cardData;
            this.gameData = gameData;
            this.optionToWin = optionToWin;
        }

        public ICardData GetCardData()
        {
            return cardData;
        }

        public IGameData GetGameData()
        {
            return gameData;
        }

        public int OptionToWin()
        {
            return optionToWin;
        }

        public void SetCardData(ICardData cardData)
        {
            this.cardData = cardData;
        }

        public void SetGameData(IGameData gameData)
        {
            this.gameData = gameData;
        }

        public void SetOptionToWin(int optionToWin)
        {
            this.optionToWin = optionToWin;
        }

    }
}
