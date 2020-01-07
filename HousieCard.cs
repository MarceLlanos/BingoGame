using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HousieCard 
    {
        int column;
        int row;
        int balls;
        string[,] card;

        public HousieCard()
        {
            column = 9;
            row = 3;
            balls = 90;
            card = new string[column, row];
        }
        public int GetColumn()
        {
            return column;
        }

        public int GetQuantityBalls()
        {
            return balls;
        }

        public int GetRow()
        {
            return row;
        }

        public void SetRow(int row)
        {
            this.row = row;
        }

        public void SetColumn(int column)
        {
            this.column = column;
        }

        public void SetQuantityBalls(int balls)
        {
            this.balls = balls;
        }

        public void showCard()
        {
            Console.WriteLine(card);
        }

        public string[,] DrawCard(List<int> numbers)
        {

            for (int i = 0; i < numbers.Count; i++)
            {
                card = new string[i, 0];
            }

            return card;
        }

        public void BlankSpaces(List<int> rowBlankSpaces)
        {
            throw new NotImplementedException();
        }
    }
}
