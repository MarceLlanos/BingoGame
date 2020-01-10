using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Card : ICard
    {
        string[,] card;

        public Card(string[,] card)
        {
            this.card = card;
        }

        public string[,] GetCard()
        {
            return card;
        }

        public void SetCard(string[,] card)
        {
            this.card = card;
        }

        public string PrintRow(int rowIndex, int columnNumber)
        {
            string row = string.Empty;

            for (int i = 0; i < columnNumber; i++)
            {
                row += card[i, rowIndex] + " ";
            }

            return row;
        }
    }
}
