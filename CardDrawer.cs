using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardDrawer : ICardDrawer
    {
        ICard card;
        public CardDrawer(ICard card)
        {
            this.card = card;
        }

        public string[,] DrawCard(List<int> randomNumbers, int column)
        {
            var row = card.GetCardData().GetRow();
            var cardBoard = card.GetCard();

            for (int j = 0; j < row; j++)
            {
                cardBoard[column, j] = string.Format("{0}", randomNumbers[j]);
            }

            return cardBoard;
        }

    }
}
