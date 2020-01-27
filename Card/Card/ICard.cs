using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface ICard
    {
        ICell[,] GetCardBoard();
        ICell GetCell();
        string PrintRow(int rowIndex, int columnNumber);
        void CrossoutCard(List<IBall> ballsExtracted, int columnNumber, int rowNumber);
        void SetCell(ICell cell);
        IPattern GetPatterCompleted(IPattern pattern);
    }
}
