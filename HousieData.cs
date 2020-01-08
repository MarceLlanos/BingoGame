using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HousieData : ICardData
    {
        int column;
        int row;
        int quantity;

        public HousieData()
        {
            column = 9;
            row = 3;
            quantity = 90;
        }

        public int GetColumn()
        {
            return column;
        }

        public int GetQuantityBalls()
        {
            return quantity;
        }

        public int GetRow()
        {
            return row;
        }

        public void SetColumn(int column)
        {
            this.column = column;
        }

        public void SetQuantityBalls(int quantity)
        {
            this.quantity = quantity;
        }

        public void SetRow(int row)
        {
            this.row = row;
        }
    }
}
