using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RangeDictionaryFactory : IRangeDictionaryFactory
    {
        public IRangeDictionary CreateRangeDictionary(int columnNumber)
        {
            var bingoRangeDictionary = new BingoRangeDictionaryFiller().FillRangeDictionary();
            var housieRangeDictionary = new HousieRangeDictionaryFiller().FillRangeDictionary();

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
