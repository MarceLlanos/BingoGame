using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RandomSpacesInjector : ISpaceInjector
    {
        IRandomNumbersGenerator generator;

        public RandomSpacesInjector(IRandomNumbersGenerator generator)
        {
            this.generator = generator;
        }

        public ICard InjectSpace(ICard card, IGameConfiguration gameDataSetting)
        {
            var rowNumber = gameDataSetting.GetCardData().GetRowNumber();
            var columnNumber = gameDataSetting.GetCardData().GetColumnNumber();
            var spacesInjector = new CardSpaceFiller(card);

            for (int i = 0; i < rowNumber; i++)
            {
                var columnPositions = generator.GenerateDistinctRandomNumbers(new Range(1, columnNumber), 4);
                spacesInjector.FillData(columnPositions, i);
            }

            return card;
        }

    }
}
