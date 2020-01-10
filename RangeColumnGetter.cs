using System;
using System.Collections.Generic;

namespace BingoGame
{
    public class RangeColumnGetter: IRangeColumnGetter
    {

        public RangeColumnGetter()
        {
        }

        public IRange GetRangeForColumn(int columnIndex, int columnNumber)
        {
            IRange range = null;
            var dictionary = new RangeDictionaryFactory().CreateRangeDictionary(columnNumber);

            foreach (KeyValuePair<int, IRange> item in dictionary)
            {
                if (item.Key == columnIndex)
                {
                    range = item.Value;
                }
            }

            return range;
        }
    }
}
