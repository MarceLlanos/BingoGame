using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RandomBlankSpacesInjector : IBlankSpaceInjector
    {
        public ICard InjectBlankSpace(ICard card, IGameDataSetting gameDataSetting)
        {
            var rowNumber = gameDataSetting.GetCardData().GetRowNumber() - 1;
            var cardBoard = card.GetCard();
            var cardData = gameDataSetting.GetCardData();
            var positioner = new RandomPositionsGetter(cardData);

            while (rowNumber >= 0)
            {
                var columnPosition = positioner.GetRandomPositions(4);

                for (int j = 0; j < columnPosition.Count; j++)
                {
                    cardBoard[columnPosition[j], rowNumber] = " * ";
                }

                rowNumber -= 1;
            }

            return card;
        }
    }
}
