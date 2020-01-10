using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RandomPositionsGetter : IRandomPositioner
    {
        IRandomNumbersGenerator generator;
        ICardData cardData;
        List<int> positions;

        public RandomPositionsGetter(ICardData cardData)
        {
            generator = new RandomNumbersGenerator();
            this.cardData = cardData;
            positions = new List<int>();
        }

        public List<int> GetRandomPositions(int quantity)
        {
            var range = new Range(1, cardData.GetColumnNumber());

            positions = generator.GenerateDistinctRandomNumbers(range, quantity);

            return positions;
        }
    }
}
