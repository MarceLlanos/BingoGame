using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ConfigurationCard : IConfigurationCard
    {
        ICardDictionary cardDictionary;

        public ConfigurationCard(ICardDictionary cardDictionary)
        {
            this.cardDictionary = cardDictionary;
        }

        public IRange GetRangeForColumn(int column)
        {
            IRange range;

            foreach (KeyValuePair<int, IRange> item in cardDictionary.GetDictionaries())
            {
                if (column == item.Key)
                {
                    return range = item.Value;
                }
            }

            return range = null;
        }
    }
}
