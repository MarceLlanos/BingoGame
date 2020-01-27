using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class DataFiller : IDataFiller
    {
        ICard card;

        public DataFiller(ICard card)
        {
            this.card = card;
        }

        public ICell[,] FillData(List<int> randomNumbers, int columnIndex)
        {
            var rowNumber = randomNumbers.Count;
            var cardBoard = card.GetCardBoard();

            for (int j = 0; j < rowNumber; j++)
            {
                cardBoard[columnIndex, j] = new Cell(string.Format("{0}", randomNumbers[j]), false);
            }

            return cardBoard;
        }

    }
}
