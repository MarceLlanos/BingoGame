using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BingoRangeDictionaryFiller : IRangeDictionaryFiller
    {

        public IDictionary<int, IRange> FillRangeDictionary()
        {
            var dictionary = new Dictionary<int, IRange>();
            dictionary.Add(0, new Range(1, 15));
            dictionary.Add(1, new Range(16, 30));
            dictionary.Add(2, new Range(31, 45));
            dictionary.Add(3, new Range(46, 60));
            dictionary.Add(4, new Range(61, 75));

            return dictionary;
        }
    }
}
