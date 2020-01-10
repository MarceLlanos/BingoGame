namespace BingoGame
{
    internal class DataCard : IDataCard
    {
        private int columnNumbers;
        private int rowNumbers;
        private int quantityBalls;

        public DataCard(int columnNumber, int rowNumbers, int quantityBalls)
        {
            this.columnNumbers = columnNumber;
            this.rowNumbers = rowNumbers;
            this.quantityBalls = quantityBalls;
        }

        public int GetColumnNumbers()
        {
            return columnNumbers;
        }

        public int GetQuantityOfBalls()
        {
            return quantityBalls;
        }

        public int GetRowNumbers()
        {
            return rowNumbers;
        }

        public void SetColumnNumbers(int columnNumbers)
        {
            this.columnNumbers = columnNumbers;
        }

        public void SetQuantityOfBalls(int quantityBalls)
        {
            this.quantityBalls = quantityBalls;
        }

        public void SetRowNumbers(int rowNumbers)
        {
            this.rowNumbers = rowNumbers;
        }
    }
}