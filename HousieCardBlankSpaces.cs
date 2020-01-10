﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HousieCardBlankSpaces : IBlankSpacesFactory
    {
        public ICard InjectBlankSpaces(IBlankSpaceInjector blankSpaces, ICard card)
        {
            return blankSpaces.InjectBlankSpace(card);
        }
    }
}