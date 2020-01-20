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
            var rangeDictionary = new RangeDictionaryFactory().CreateRangeDictionary(columnNumber);

            var cardPrototype = new CardPrototype(new ColumnRangeGetter(rangeDictionary), gameConfiguration);

            var cardData = gameConfiguration.GetCardData();

            var card = new CardFactory().CreateCard(service);
            var bingoCardPrototype = cardPrototype.CreateCardPrototype(card);

            var blankSpaces = new BlankSpaceInjectorFactory().CreateBlankSpacesInjector(columnNumber);
            
            return blankSpaces.InjectSpace(bingoCardPrototype, gameConfiguration);
        }
    }
}
