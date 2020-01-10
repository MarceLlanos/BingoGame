using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    interface IBlankSpacesFactory
    {
        ICard InjectBlankSpaces(IBlankSpaceInjector blankSpaces, ICard card);
    }
}
