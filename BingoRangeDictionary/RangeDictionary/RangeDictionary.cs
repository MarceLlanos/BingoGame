using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RangeDictionary : IRangeDictionary
    {
        IDictionary<int, IRange> dictionary;

        public RangeDictionary(IDictionary<int, IRange> dictionary)
        {
            this.dictionary = dictionary;
        }

        public IDictionary<int, IRange> GetRangeDictionary()
        {
            return dictionary;
        }
    }
}
