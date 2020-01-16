using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Card : ICard
    {
        string[,] cardBoard;

        public Card(string[,] cardBoard)
        {
            this.cardBoard = cardBoard;
        }

        public string[,] GetCardBoard()
        {
            return cardBoard;
        }

        public void SetCardBoard(string[,] card)
        {
            this.cardBoard = card;
        }

        public string PrintRow(int rowIndex, int columnNumber)
        {
            string rowPrinted = string.Empty;

            for (int i = 0; i < columnNumber; i++)
            {
                rowPrinted += cardBoard[i, rowIndex] + " ";
            }

            return rowPrinted;
        }
    }
}
