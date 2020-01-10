using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HousieRangeDictionaryFiller : IRangeDictionaryFiller
    {
        public IDictionary<int, IRange> FillRangeDictionary()
        {
            var dictiornary = new Dictionary<int, IRange>();

            dictiornary.Add(0, new Range(1, 9));
            dictiornary.Add(1, new Range(10, 19));
            dictiornary.Add(2, new Range(20, 29));
            dictiornary.Add(3, new Range(30, 39));
            dictiornary.Add(4, new Range(40, 49));
            dictiornary.Add(5, new Range(50, 59));
            dictiornary.Add(6, new Range(60, 69));
            dictiornary.Add(7, new Range(70, 79));
            dictiornary.Add(8, new Range(80, 90));

            return dictiornary;
        }
    }
}
