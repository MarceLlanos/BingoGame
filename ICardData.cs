using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface ICardData
    {
        int GetColumnNumber();
        int GetRowNumber();
        void SetColumnNumber(int column);
        void SetRowNumber(int row);
    }
}
