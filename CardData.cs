using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardData : ICardData
    {
        private int columnNumbers;
        private int rowNumbers;

        public CardData(int columnNumber, int rowNumbers)
        {
            this.columnNumbers = columnNumber;
            this.rowNumbers = rowNumbers;
        }


        public int[,] DataDimension(int column, int rowNumbers)
        {
            return new int[column, rowNumbers];
        }

        public int GetColumnNumber()
        {
            return columnNumbers;
        }

        public int GetRowNumber()
        {
            return rowNumbers;
        }

        public void SetColumnNumber(int columnNumbers)
        {
            this.columnNumbers = columnNumbers;
        }

        public void SetRowNumber(int rowNumbers)
        {
            this.rowNumbers = rowNumbers;
        }
    }
}
