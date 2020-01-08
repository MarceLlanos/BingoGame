using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RandomPositioner : IRandomPositioner
    {
        IRandomGenerator generator;
        ICardData cardData;
        List<int> positions;

        public RandomPositioner(ICardData cardData)
        {
            generator = new RandomGenerator();
            this.cardData = cardData;
            positions = new List<int>();
        }

        public List<int> RandomPositions(int quantity)
        {
            var range = new Range(1, cardData.GetColumn());

            positions = generator.GenerateDistinctRandomNumbers(range, quantity);

            return positions;
        }
    }
}
