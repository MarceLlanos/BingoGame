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
        IGameConfiguration gameDataSetting;

        public CardPrototype(IColumnRangeGetter columnRangeGetter, IGameConfiguration gameDataSetting)
        {
            this.gameDataSetting = gameDataSetting;
            this.columnRangeGetter = columnRangeGetter;
            randomNumbersGenerator = new RandomNumbersGenerator();
        }

        public ICard CreateCardPrototype(ICard card)
        {
            var rowNumber = gameDataSetting.GetCardData().GetRowNumber();
            var columnNumber = gameDataSetting.GetCardData().GetColumnNumber();
            var fillerCard = new DataFiller(card);
            
            for (int i = 0; i < columnNumber; i++)
            {
                var numbers = randomNumbersGenerator.GenerateDistinctRandomNumbers(columnRangeGetter.GetRangeForColumn(i), rowNumber);
                fillerCard.FillData(numbers, i);
            }

            return card;
        }
    }
}
