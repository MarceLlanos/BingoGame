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
        List<ICard> cardsCrossOut;
        ServiceLocator service;

        public CardSet(ServiceLocator service)
        {
            this.service = service;
            cards = new List<ICard>();
        }

        public void DrawDeckOfCards(int quantityOfCards, ICardPrototypeFactory cardPrototype)
        {
            while (quantityOfCards > 0)
            {
                cards.Add(cardPrototype.CreateCardForPlay(service));
                quantityOfCards -= 1;
            }

            cardsCrossOut = new List<ICard>(cards);

        }

        public List<ICard> GetCards()
        {
            return cards;
        }

        public void CrossoutCards(List<IBall> ballsExtracted)
        {
            var cardInformation = service.GetService<IGameConfigurationFactory>("gameConfiguration").CreateGameSetting(service);
            var columnNumber = cardInformation.GetCardData().GetColumnNumber();
            var rowNumber = cardInformation.GetCardData().GetRowNumber();

            foreach (var card in cardsCrossOut)
            {
                card.CrossoutCard(ballsExtracted, columnNumber, rowNumber);
            }
        }


        public void ShowCrosoutCards()
        {
            PrintCards(cardsCrossOut);
        }

        public void ShowCards()
        {
            PrintCards(cards);
        }

        public void PrintCards(List<ICard> cardSet)
        {
            var gameConfiguration = service.GetService<IGameConfigurationFactory>("gameConfiguration");
            var rowNumber = gameConfiguration.CreateGameSetting(service).GetCardData().GetRowNumber();
            var columnNumber = gameConfiguration.CreateGameSetting(service).GetCardData().GetColumnNumber();

            foreach (var item in cardSet)
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
