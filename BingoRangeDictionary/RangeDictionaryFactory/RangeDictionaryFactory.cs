using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RangeDictionaryFactory : IRangeDictionaryFactory
    {

        public IRangeDictionary CreateRangeDictionary(ServiceLocator service)
        {
            var bingoRangeDictionary = service.GetService<IRangeDictionaryFiller>("bingoDictonary").FillRangeDictionary();
            var housieRangeDictionary = service.GetService<IRangeDictionaryFiller>("housieDictonary").FillRangeDictionary();
            var columnNumber = service.GetService<IGameConfigurationFactory>("gameConfiguration").CreateGameSetting(service).GetCardData().GetColumnNumber();

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
