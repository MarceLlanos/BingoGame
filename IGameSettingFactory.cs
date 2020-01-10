using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IGameSettingFactory
    {
        IGameDataSetting CreateGameSetting(int option, int quantityOfCards, int optionToWin);
    }
}
