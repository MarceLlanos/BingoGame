using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardSpaceFiller : IDataFiller
    {
        ICard card;

        public CardSpaceFiller(ICard card)
        {
            this.card = card;
        }

        public ICell[,] FillData(List<int> randomNumbers, int rowIndex)
        {
            var columnsNumber = randomNumbers.Count;
            var cardBoard = card.GetCardBoard();

            for (int i = 0; i < columnsNumber; i++)
            {
                cardBoard[randomNumbers[i], rowIndex].SetCrossoutTheCell(true);
                cardBoard[randomNumbers[i], rowIndex].SetVelueOfCell(" * ");
            }

            return cardBoard;
        }
    }
}
