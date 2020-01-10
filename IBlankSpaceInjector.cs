﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IBlankSpaceInjector
    {
        ICard InjectBlankSpace(ICard card, IGameDataSetting gameDataSetting);
    }
}
