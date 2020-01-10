using System;
using System.Collections.Generic;

namespace BingoGame
{
    public interface IFillerDictionary
    {
        IDictionary<int, IRange> GetFilledDictionary();
    }
}
