using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardFactory : ICardFactory
    {
        public ICard CreateCard(ICard card)
        {
            switch (card.GetRange().GetStart())
            {
                case 5:
                    return new Orchestrator(new Card(new BingoRange(), 75), new RandomGenerator()).Orchestrate( new ConfigurationCard(new BingoDictionary()));
                case 9:
                    return new Orchestrator(new Card(new HousieRange(), 90), new RandomGenerator()).Orchestrate( new ConfigurationCard(new HousieDictionary()));
                default:
                    return new Orchestrator(new Card(new BingoRange(), 75), new RandomGenerator()).Orchestrate(new ConfigurationCard(new BingoDictionary()));


            }
        }
    }
}
