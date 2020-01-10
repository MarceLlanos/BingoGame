using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BingoCardBlankSpaces : IBlankSpacesFactory
    {
        IGameDataSetting gameDataSetting;

        public BingoCardBlankSpaces(IGameDataSetting gameDataSetting)
        {
            this.gameDataSetting = gameDataSetting;
        }

        public ICard InjectBlankSpaces(IBlankSpaceInjector blankSpaces, ICard card)
        {

            return blankSpaces.InjectBlankSpace(card, gameDataSetting);
            
        }
    }
}
