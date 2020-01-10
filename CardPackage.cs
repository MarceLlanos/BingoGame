using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardPackage : ICardPackage
    {
        List<ICard> cards;

        public CardPackage()
        {
            cards = new List<ICard>();
        }

        public List<ICard> DeckOfCards(IGameDataSetting gameDataSetting)
        {
            var columnNumber = gameDataSetting.GetCardData().GetColumnNumber();
            var cardFactory = new CardFactory(columnNumber, gameDataSetting);
            var quantityOfCards = gameDataSetting.GetGameData().GetQuantityOfCards();

            while (quantityOfCards > 0)
            {
                cards.Add(cardFactory.CreateCard());

                quantityOfCards -= 1;
            }

            return cards;
        }

        public void ShowCards()
        {
            foreach (var item in cards)
            {
                for (int i = 0; i < item.GetCardData().GetRowNumber(); i++)
                {
             
                    Console.WriteLine(item.PrintRow(i));
                }

                Console.WriteLine(" ");
            }

            
        }
    }
}
