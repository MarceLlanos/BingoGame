using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardPrototypeFactory : ICardPrototypeFactory
    {

        public ICard CreateCardForPlay(ServiceLocator service)
        {
            var gameConfiguration = service.GetService<IGameConfigurationFactory>("gameConfiguration").CreateGameSetting(service);
            var columnNumber = gameConfiguration.GetCardData().GetColumnNumber();
            var rangeDictionary = service.GetService<IRangeDictionaryFactory>("rangeDictionaryFactory").CreateRangeDictionary(service);

            var cardPrototype = new CardPrototype(new ColumnRangeGetter(rangeDictionary), gameConfiguration);
            var cardData = gameConfiguration.GetCardData();
            var card = service.GetService<ICardFactory>("cardFactory").CreateCard(service);
            var random = service.GetService<IRandomNumbersGenerator>("randomNumbersGenerator");
            var bingoCard = cardPrototype.CreateCardPrototype(card, random);
            
            var blankSpaces = service.GetService<IBlankSpaceInjectorFactory>("blankSpace").CreateBlankSpacesInjector(service, columnNumber);
            
            return blankSpaces.InjectSpace(bingoCard, gameConfiguration);
        }
    }
}
