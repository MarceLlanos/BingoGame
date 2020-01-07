using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Card : ICard
    {
        IRange range;
        int balls;
        string[,] card;

        public Card(IRange range, int balls)
        {
            this.range = range;
            this.balls = balls;
            card = new string[range.GetStart(), range.GetEnd()];
        }

        public int GetQuantityBalls()
        {
            return balls;
        }

        public void SetQuantityBalls(int balls)
        {
            this.balls = balls;
        }

        public void DrawCard(List<int> numbers, int column)
        {
            var row = range.GetEnd();

            for (int j = 0; j < row; j++)
            {
                card[column,j] = string.Format("{0}",numbers[j]);
            }

        }

        public void BlankSpaces(List<int> rowBlankSpaces)
        {
            for (int i = 0; i < range.GetStart(); i++)
            {
                for (int j = 0; j < range.GetEnd(); j++)
                {
                    if (rowBlankSpaces.Contains(i))
                    {
                        card[range.GetStart(), j] = " ";
                    }
                }
            }
        }
        public void showCard()
        {
            Console.WriteLine(card);
        }

        public IRange GetRange()
        {
            return range;
        }
    }
}
