using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IGameDataSetting
    {
        ICardData GetCardData();
        IGameData GetGameData();
        int OptionToWin();
        void SetOptionToWin(int optionToWin);
    }
}
