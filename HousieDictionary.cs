using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HousieDictionary : ICardDictionary
    {
        IDictionary<int, IRange> dictionary;

        public HousieDictionary()
        {
            dictionary = new Dictionary<int, IRange>();
            AddDictionary();
        }

        private void AddDictionary()
        {
            dictionary.Add(0, new Range(1, 9));
            dictionary.Add(1, new Range(10, 19));
            dictionary.Add(2, new Range(20, 29));
            dictionary.Add(3, new Range(30, 39));
            dictionary.Add(4, new Range(40, 49));
            dictionary.Add(5, new Range(50, 59));
            dictionary.Add(6, new Range(60, 69));
            dictionary.Add(7, new Range(70, 79));
            dictionary.Add(8, new Range(80, 90));
        }

        public IDictionary<int, IRange> GetDictionaries()
        {
            return dictionary;
        }
    }
}
