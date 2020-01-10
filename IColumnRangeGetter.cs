using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IColumnRangeGetter
    {
        IRange GetRangeForColumn(int column);
    }
}
