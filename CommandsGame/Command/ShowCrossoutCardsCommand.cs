using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ShowCrossoutCardsCommand : ICommand<ServiceLocator>
    {
        public void ExecuteCommand(ServiceLocator bingoComponent)
        {
            var cardSet = bingoComponent.GetService<ICardSet>("cardSet");

            cardSet.ShowCards();
        }
    }
}
