using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardSpacesFiller : IDataFiller
    {
        ICard card;

        public CardSpacesFiller(ICard card)
        {
            this.card = card;
        }

        public string[,] FillData(List<int> randomNumbers, int rowIndex)
        {
            var columnsNumber = randomNumbers.Count;
            var cardBoard = card.GetCardBoard();

            for (int i = 0; i < columnsNumber; i++)
            {
                cardBoard[randomNumbers[i], rowIndex] = " * ";
            }

            return cardBoard;
        }
    }
}
