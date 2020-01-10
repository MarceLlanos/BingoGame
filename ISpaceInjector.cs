using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface ISpaceInjector
    {
        ICard InjectSpace(ICard card, IGameDataSetting gameDataSetting);
    }
}
