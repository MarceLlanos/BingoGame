using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Card : ICard
    {
        ICardData data;
        string[,] card;
        ICardDrawer drawer;

        public Card(ICardData data)
        {
            this.data = data;
            card = new string[data.GetColumn(), data.GetRow()];
            drawer = new CardDrawer(this);
        }

        public ICardData GetCardData()
        {
            return data;
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
            return drawer.DrawCard(randomNumbers, columnIndex);
        }

        public string PrintRow(int rowIndex)
        {
            string row = string.Empty;

            for (int i = 0; i < data.GetColumn(); i++)
            {
                row += card[i, rowIndex] + " ";
            }

            return row;
        }
    }
}
