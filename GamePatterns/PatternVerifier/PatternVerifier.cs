using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class PatternVerifier : IPatternVerifier
    {
        public bool WasSomePatternCompletedInThisCard(IPattern patternShape, ICard card)
        {
            if(!patternShape.ShapeOfThePattern(card).Contains(false))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
