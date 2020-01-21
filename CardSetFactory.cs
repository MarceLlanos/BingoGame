using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardSetFactory : ICardSetFactory
    {
        public ICardSet CreateCardSet(ServiceLocator service)
        {
            var gameConfiguration = service.GetService<IGameConfigurationFactory>("gameConfiguration");
            var quantityOfCardsToCreate = gameConfiguration.CreateGameSetting(service).GetGameData().GetQuantityOfCards();
            var cardPrototype = service.GetService<ICardPrototypeFactory>("cardPrototypeFactory");
            var cardSet = service.GetService<ICardSet>("cardSet");
            cardSet.DrawDeckOfCards(quantityOfCardsToCreate, cardPrototype);

            return cardSet;
            
        }
    }
}
