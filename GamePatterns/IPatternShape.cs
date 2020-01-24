using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IPatternShape
    {
        List<string> PatternShape(ICard card);
        IPatternShape SetNextPattern(IPatternShape pattern);
        bool HasNext();
        bool IsthisFullHousePattern();
    }
}
