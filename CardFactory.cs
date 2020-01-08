using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardFactory : ICardFactory
    {
        IOrchestrator orchestrator;

        public CardFactory()
        {
            orchestrator = new Orchestrator(new ConfigurationCard(new BingoDictionary()), new RandomGenerator());

        }
        public ICard CreateCard(ICard prototype)
        {
            var column = prototype.GetCardData().GetColumn();
            ICardData cardData = CreateCardData(column);
            var card = orchestrator.Orchestrate(new Card(cardData));
            IBlankSpaces blankSpaces = CreateBlanckSpaces(column);

            return new BingoCardBlankSpaces().DrawBlankSpaces(blankSpaces, card);
        }

        private IBlankSpaces CreateBlanckSpaces(int column)
        {
            switch (column)
            {
                case 5: return new MiddleBingoDrawerBlankSpaces();
                case 9: return new HousieDrawerBlankSpaces();
            }

            return new MiddleBingoDrawerBlankSpaces();
        }

        private ICardData CreateCardData(int column)
        {
            switch (column)
            {
                case 5: return new BingoData();
                case 9: return new HousieData();
            }

            return new BingoData();
        }
    }
}
