using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BlankSpaceInjectorFactory : IBlankSpaceInjectorFactory
    {
        public ISpaceInjector CreateBlankSpacesInjector(int columnNumber)
        {
            switch (columnNumber)
            {
                case 5: return new MiddleBlankSpaceInjector();
                case 9: return new RandomSpacesInjector();
                default:
                    return null;
            }
        }
    }
}
