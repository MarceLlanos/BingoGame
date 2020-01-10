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
            IBlankSpaceInjector blankSpaces = CreateBlanckSpaces(columnNumber);

            return new BingoCardBlankSpaces(gameDataSetting).InjectBlankSpaces(blankSpaces, bingoCardPrototype);
        }

        private IBlankSpaceInjector CreateBlanckSpaces(int column)
        {
            switch (column)
            {
                case 5: return new MiddleBlankSpaceInjector();
                case 9: return new RandomBlankSpacesInjector();
            }

            return new MiddleBlankSpaceInjector();
        }

        
    }
}
