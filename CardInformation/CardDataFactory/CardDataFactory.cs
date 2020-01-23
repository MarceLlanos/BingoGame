using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardDataFactory : ICardDataFactory
    {
        public ICardData CreateCardData(int optionNumber)
        {
            switch (optionNumber)
            {
                case 1: return new CardData(5, 5);
                    
                case 2: return new CardData(9, 3);
            }

            return new CardData(5, 5);
        }
    }
}
