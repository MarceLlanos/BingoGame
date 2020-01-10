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
        ICardFiller drawer;

        public Card(string[,] card)
        {
            this.card = card;
            drawer = new CardFiller(this);
        }

        public string[,] GetCard()
        {
            return card;
        }


        public void SetCard(string[,] card)
        {
            this.card = card;
        }

        public string[,] Draw(List<int> randomNumbers, int columnIndex)
        {
            return drawer.FillCard(randomNumbers, columnIndex);
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
