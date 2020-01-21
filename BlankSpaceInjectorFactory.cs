using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BlankSpaceInjectorFactory : IBlankSpaceInjectorFactory
    {
        public ISpaceInjector CreateBlankSpacesInjector(ServiceLocator service, int columnNumber)
        {
            var generator = service.GetService<IRandomNumbersGenerator>("randomNumbersGenerator");

            switch (columnNumber)
            {
                case 5: return new MiddleBlankSpaceInjector();
                case 9: return new RandomSpacesInjector(generator);
                default:
                    return null;
            }
        }
    }
}
