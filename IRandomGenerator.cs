using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    interface IRandomGenerator
    {
        List<int> GenerateRandomUniqueNumbers(IRange range, int quantity);
    }
}
