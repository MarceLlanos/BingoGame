using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface ICardData
    {
        int GetColumn();
        int GetRow();
        int GetQuantityBalls();
        void SetColumn(int column);
        void SetRow(int row);
        void SetQuantityBalls(int quantity);
    }
}
