using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardSet : ICardSet
    {
        List<ICard> cards;
        ServiceLocator service;

        public CardSet(ServiceLocator service)
        {
            this.service = service;
            cards = new List<ICard>();
        }

        public List<ICard> DrawDeckOfCards(int quantityOfCards, ICardPrototypeFactory cardPrototype)
        {
            while (quantityOfCards > 0)
            {
                cards.Add(cardPrototype.CreateCardForPlay(service));
                quantityOfCards -= 1;
            }

            return cards;
        }

        public void ShowCards()
        {
            var gameConfiguration = service.GetService<IGameConfigurationFactory>("gameConfiguration");
            var rowNumber = gameConfiguration.CreateGameSetting(service).GetCardData().GetRowNumber();
            var columnNumber = gameConfiguration.CreateGameSetting(service).GetCardData().GetColumnNumber();

            foreach (var item in cards)
            {
                for (int i = 0; i < rowNumber; i++)
                {
             
                    Console.WriteLine(item.PrintRow(i, columnNumber));
                }

                Console.WriteLine(" ");
            }
        }
    }
}
