using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class VerifierPattern : IVerifierPatter
    {
        public bool IsThePatternCompleted(IPattern pattern, ICard card)
        {
            bool result = false;

            foreach (var item in pattern.IsThisPatternPosition(card))
            {
                if (item == " * ")
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
