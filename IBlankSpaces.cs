﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    interface IBlankSpaces
    {
        ICard DrawBlankSpace(int quantity, ICard card);
    }
}
