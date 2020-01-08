using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BingoCardBlankSpaces : IBlankSpacesFactory
    {

        public ICard DrawBlankSpaces(IBlankSpaces blankSpaces, ICard card)
        {

            return blankSpaces.DrawBlankSpace(0, card);
            
        }
    }
}
