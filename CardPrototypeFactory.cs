using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardPrototypeFactory : ICardPrototypeFactory
    {
        ICardPrototype cardPrototype;
        IGameDataSetting gameDataSetting;

        public CardPrototypeFactory(IGameDataSetting gameDataSetting)
        {
            this.gameDataSetting = gameDataSetting;
            var columnNumber = gameDataSetting.GetCardData().GetColumnNumber();
            var dictionary = new RangeDictionaryFactory().CreateRangeDictionary(columnNumber);
            cardPrototype = new CardPrototype(new ColumnRangeGetter(dictionary), gameDataSetting);

        }

        public ICard CreateCardForPlay()
        {
            var columnNumber = gameDataSetting.GetCardData().GetColumnNumber();
            var cardData = gameDataSetting.GetCardData();
            var card = new CardFactory().CreateCard(gameDataSetting);
            var bingoCardPrototype = cardPrototype.CreateCardPrototype(card);

            var blankSpaces = new BlankSpaceInjectorFactory().CreateBlankSpacesInjector(columnNumber);
            
            return blankSpaces.InjectBlankSpace(bingoCardPrototype, gameDataSetting);
        }

        

        
    }
}
