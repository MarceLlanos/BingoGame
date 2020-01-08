using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardShuffler : ICardShuffler
    {
        List<ICard> cards;

        public CardShuffler()
        {
            cards = new List<ICard>();
        }

        public List<ICard> DeckOfCards(int quantityOfCards, ICard card)
        {
            var cardFactory = new CardFactory();

            while (quantityOfCards > 0)
            {
                cards.Add(cardFactory.CreateCard(card));

                quantityOfCards -= 1;
            }

            return cards;
        }

        public void ShowDeckOfCards()
        {
            foreach (var item in cards)
            {
                for (int i = 0; i < item.GetCardData().GetRow(); i++)
                {
             
                    Console.WriteLine(item.PrintRow(i));
                }

                Console.WriteLine(" ");
            }

            
        }
    }
}
