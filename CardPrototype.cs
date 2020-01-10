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

        public CardPrototype(IColumnRangeGetter columnRangeGetter)
        {
            this.columnRangeGetter = columnRangeGetter;
            randomNumbersGenerator = new RandomNumbersGenerator();
        }

        public ICard CreateCardPrototype(ICard card)
        {
            var row = card.GetCardData().GetRowNumber();
            var column = card.GetCardData().GetColumnNumber();

            for (int i = 0; i < column; i++)
            {
                var numbers = randomNumbersGenerator.GenerateDistinctRandomNumbers(columnRangeGetter.GetRangeForColumn(i), row);

                card.Draw(numbers, i);
            }

            return card;
        }
    }
}
