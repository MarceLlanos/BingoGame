using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ColumnRangeGetter : IColumnRangeGetter
    {
        IRangeDictionary cardDictionary;

        public ColumnRangeGetter(IRangeDictionary cardDictionary)
        {
            this.cardDictionary = cardDictionary;
        }

        public IRange GetRangeForColumn(int columnIndex)
        {
            IRange range;

            foreach (KeyValuePair<int, IRange> item in cardDictionary.GetRangeDictionary())
            {
                if (columnIndex == item.Key)
                {
                    return range = item.Value;
                }
            }

            return range = null;
        }
    }
}
