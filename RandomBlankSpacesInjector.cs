using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RandomBlankSpacesInjector : IBlankSpaceInjector
    {
        public ICard InjectBlankSpace(ICard card)
        {
            var row = card.GetCardData().GetRowNumber()-1;
            var cardBoard = card.GetCard();
            var positioner = new RandomPositionsGetter(card.GetCardData());

            while (row >= 0)
            {
                var columnPosition = positioner.GetRandomPositions(4);

                for (int j = 0; j < columnPosition.Count; j++)
                {
                    cardBoard[columnPosition[j], row] = " * ";
                }

                row -= 1;
            }
            

            return card;
        }
    }
}
