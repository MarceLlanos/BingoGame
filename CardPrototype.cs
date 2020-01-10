using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardPrototype : ICardPrototype
    {
        IRandomNumbersGenerator randomNumbersGenerator;
        IColumnRangeGetter columnRangeGetter;
        IGameDataSetting gameDataSetting;

        public CardPrototype(IColumnRangeGetter columnRangeGetter, IGameDataSetting gameDataSetting)
        {
            this.gameDataSetting = gameDataSetting;
            this.columnRangeGetter = columnRangeGetter;
            randomNumbersGenerator = new RandomNumbersGenerator();
        }

        public ICard CreateCardPrototype(ICard card)
        {
            var rowNumber = gameDataSetting.GetCardData().GetRowNumber();
            var columnNumber = gameDataSetting.GetCardData().GetColumnNumber();
            var fillerCard = new CardFiller(card);
            
            for (int i = 0; i < columnNumber; i++)
            {
                var numbers = randomNumbersGenerator.GenerateDistinctRandomNumbers(columnRangeGetter.GetRangeForColumn(i), rowNumber);
                fillerCard.FillCard(numbers, i);
            }

            return card;
        }
    }
}
