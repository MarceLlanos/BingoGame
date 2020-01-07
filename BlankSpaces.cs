using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BlankSpaces : IBlankSpaces
    {
        ICard card;
        IRandomGenerator randomGenerator;
        List<int> randomPositons;

        public BlankSpaces(ICard card)
        {
            this.card = card;
            randomGenerator = new RandomGenerator();
            randomPositons = new List<int>();
        }

        public List<int> BlankRowSpaces(int quantity)
        {
            for (int i = 0; i < card.GetRange().GetEnd(); i++)
            {
                var range = new Range(1, card.GetRange().GetStart());

                randomPositons = randomGenerator.GenerateRandomUniqueNumbers(range, 4);
            }

            return randomPositons;
        }
    }
}
