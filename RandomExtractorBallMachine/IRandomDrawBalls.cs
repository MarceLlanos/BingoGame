﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IRandomDrawBalls
    {
        List<int> TakenOutBalls(int quantityOfDrawOut);
    }
}
