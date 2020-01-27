using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Card : ICard
    {
        ICell[,] cardBoard;
        ICell cell;


        public Card(ICell[,] cardBoard)
        {
            this.cardBoard = cardBoard;
        }

        public ICell[,] GetCardBoard()
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
                        var cell = GetCardBoard()[i, j];

                        if (cell.GetValueCell().Equals(ballValue))
                        {
                            GetCardBoard()[i, j].SetCrossoutTheCell(true);
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
                var cell = cardBoard[i, rowIndex];
                if (cell.IsCrossoutTheCell() == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    cell.PrintCell();
                }
                else if(cell.IsCrossoutTheCell() == false)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    cell.PrintCell();
                }
            }

            return rowPrinted;
        }

        public ICell GetCell()
        {
            return cell;
        }

        public void SetCell(ICell cell)
        {
            this.cell = cell;
        }

        public IPattern GetPatterCompleted(IPattern pattern)
        {
            return pattern;
        }
    }
}
