using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RangeDictionaryFactory : IRangeDictionaryFactory
    {
        ServiceLocator serviceLocator;

        public RangeDictionaryFactory()
        {
            serviceLocator = new ServiceLocator();
        }

        public IRangeDictionary CreateRangeDictionary(int columnNumber)
        {
            var bingoRangeDictionary = serviceLocator.GetService<IRangeDictionaryFiller>("bingoDictonary").FillRangeDictionary();
            var housieRangeDictionary = serviceLocator.GetService<IRangeDictionaryFiller>("housieDictonary").FillRangeDictionary();

            switch (columnNumber)
            {
                case 5: return new RangeDictionary(bingoRangeDictionary);
                case 9: return new RangeDictionary(housieRangeDictionary);
                default:
                    return new RangeDictionary(bingoRangeDictionary);
            }

        }
    }
}
