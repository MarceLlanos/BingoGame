using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HousieDrawerBlankSpaces : IBlankSpaces
    {
        IRandomPositioner positioner;

        public HousieDrawerBlankSpaces()
        {
            positioner = new RandomPositioner(new HousieData());
        }

        public ICard DrawBlankSpace(int quantity, ICard card)
        {
            var row = card.GetCardData().GetRow()-1;
            var cardBoard = card.GetCard();

            while(row >= 0)
            {
                var columnPosition = positioner.RandomPositions(quantity);

                for (int j = 0; j < columnPosition.Count; j++)
                {
                    cardBoard[columnPosition[j], row] = " ";
                }

                row -= 1;
            }
            

            return card;
        }
    }
}
