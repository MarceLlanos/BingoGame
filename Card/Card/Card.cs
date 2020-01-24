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

        public void CrossoutCard(List<IBall> ballsExtracted, int columnNumber, int rowNumber)
        {
            for (int i = 0; i < columnNumber; i++)
            {
                for (int j = 0; j < rowNumber; j++)
                {
                    foreach (var ball in ballsExtracted)
                    {
                        var ballValue = string.Format("{0}", ball.GetNumber());

                        if (GetCardBoard()[i, j].Equals(ballValue))
                        {
                            GetCardBoard()[i, j] = " *";
                        }
                    }
                }

            }
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
