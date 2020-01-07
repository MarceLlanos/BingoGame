using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BingoDictionary : ICardDictionary
    {
        IDictionary<int, IRange> dictionary;

        public BingoDictionary()
        {
            dictionary = new Dictionary<int, IRange>();
            AddDictionary();
        }

        private void AddDictionary()
        {
            dictionary.Add(0, new Range(1, 15));
            dictionary.Add(1, new Range(16, 30));
            dictionary.Add(2, new Range(31, 45));
            dictionary.Add(3, new Range(46, 60));
            dictionary.Add(4, new Range(61, 75));
        }
       
        public IDictionary<int, IRange> GetDictionaries()
        {
            return dictionary;
        }
    }
}
