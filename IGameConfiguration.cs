using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IGameConfiguration
    {
        ICardData GetCardData();
        IGameData GetGameData();
        int OptionToWin();
        void SetCardData(ICardData cardData);
        void SetGameData(IGameData gameData);
        void SetOptionToWin(int optionToWin);
    }
}
