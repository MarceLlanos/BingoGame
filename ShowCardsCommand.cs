using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ShowCardsCommand : ICommand<ICardSetFactory>
    {
        ServiceLocator service;

        public ShowCardsCommand()
        {
            service = new ServiceLocator();
        }

        public void ExecuteCommand(ICardSetFactory bingoComponent)
        {
            var gameConfiguration = service.GetService<IGameConfigurationFactory>("gameConfiguration");
            var quantityOfCards = gameConfiguration.CreateGameSetting(service).GetGameData().GetQuantityOfCards();
            var cardPrototype = service.GetService<ICardPrototypeFactory>("cardPrototype");

            bingoComponent.CreateCardSet(service).DrawDeckOfCards(quantityOfCards, cardPrototype);
        }
    }
}
