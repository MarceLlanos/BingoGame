using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HousieCardBlankSpaces : IBlankSpacesFactory
    {
        public ICard DrawBlankSpaces(IBlankSpaces blankSpaces, ICard card)
        {
            return blankSpaces.DrawBlankSpace(4, card);
        }
    }
}
