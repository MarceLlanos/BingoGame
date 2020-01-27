using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IPattern
    {
        List<bool> ShapeOfThePattern(ICard card);
        IPattern SetNextPattern(IPattern pattern);
        bool HasNext();
        string GetPatternName();
    }
}
