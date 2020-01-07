using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class GeneratorCards : IGeneratorCards
    {
        List<ICard> cards;

        public GeneratorCards()
        {
            cards = new List<ICard>();
        }

        public List<ICard> GenerateCards(int quantityOfCards, ICard card)
        {
            while(quantityOfCards > 0)
            {
                cards.Add(new CardFactory().CreateCard(card));

                quantityOfCards = -1;
            }

            return cards;
        }
    }
}
