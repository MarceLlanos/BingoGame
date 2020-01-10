using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardFactory : ICardFactory
    {
        ICardPrototype cardPrototype;
        int columnNumber;
        IGameDataSetting gameDataSetting;

        public CardFactory(int columnNumber, IGameDataSetting gameDataSetting)
        {
            this.gameDataSetting = gameDataSetting;
            this.columnNumber = columnNumber;
            var dictionary = new RangeDictionaryFactory().CreateRangeDictionary(columnNumber);
            cardPrototype = new CardPrototype(new ColumnRangeGetter(dictionary));

        }

        public ICard CreateCard()
        {
            var cardData = gameDataSetting.GetCardData();
            var card = cardPrototype.CreateCardPrototype(new Card(cardData));
            IBlankSpaceInjector blankSpaces = CreateBlanckSpaces(columnNumber);

            return new BingoCardBlankSpaces().InjectBlankSpaces(blankSpaces, card);
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
