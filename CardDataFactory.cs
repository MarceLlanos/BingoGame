using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardDataFactory : ICardDataFactory
    {
        public ICard GetCardData(string option)
        {
            switch (option)
            {
                case "1":
                    return new Card(new Range(5,5), 75);
                case "2":
                    return new Card(new Range(9,3), 90);
                default:
                    return new Card(new Range(5, 5), 75);

            }
        }
    }
}
