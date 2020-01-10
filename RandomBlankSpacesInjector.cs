using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RandomBlankSpacesInjector : IBlankSpaceInjector
    {
        IRandomNumbersGenerator generator;

        public RandomBlankSpacesInjector()
        {
            generator = new RandomNumbersGenerator();
        }

        public ICard InjectBlankSpace(ICard card, IGameDataSetting gameDataSetting)
        {
            var rowNumber = gameDataSetting.GetCardData().GetRowNumber();
            var columnNumber = gameDataSetting.GetCardData().GetColumnNumber();
            var spacesInjector = new CardSpacesFiller(card);

            for (int i = 0; i < rowNumber; i++)
            {
                var columnPositions = generator.GenerateDistinctRandomNumbers(new Range(1, columnNumber), 4);
                spacesInjector.FillCard(columnPositions, i);
            }

            return card;
        }

    }
}
