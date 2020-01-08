using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Orchestrator : IOrchestrator
    {
        IRandomGenerator randomGenerator;
        IConfigurationCard configurationCard;

        public Orchestrator(IConfigurationCard configurationCard, IRandomGenerator randomGenerator)
        {
            this.configurationCard = configurationCard;
            this.randomGenerator = randomGenerator;
        }

        public ICard Orchestrate(ICard card)
        {
            var row = card.GetCardData().GetRow();
            var column = card.GetCardData().GetColumn();

            for (int i = 0; i < column; i++)
            {
                var numbers = randomGenerator.GenerateDistinctRandomNumbers(configurationCard.GetRangeForColumn(i), row);

                card.Draw(numbers, i);
            }

            return card;
        }
    }
}
