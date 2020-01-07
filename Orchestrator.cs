using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Orchestrator : IOrchestrator
    {
        ICard card;
        IRandomGenerator randomGenerator;

        public Orchestrator(ICard card, IRandomGenerator randomGenerator)
        {
            this.card = card;
            this.randomGenerator = randomGenerator;
        }

        public ICard Orchestrate(IConfigurationCard configurationCard)
        {
            var column = card.GetRange().GetStart();

            for (int i = 0; i < column; i++)
            {
                var numbers = randomGenerator.GenerateRandomUniqueNumbers(configurationCard.GetRangeForColumn(i), column);

                card.DrawCard(numbers, i);
                numbers.Clear();
            }

            return card;
        }
    }
}
