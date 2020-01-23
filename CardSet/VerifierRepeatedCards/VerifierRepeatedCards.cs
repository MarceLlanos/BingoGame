using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class VerifierRepeatedCards : IVerifierRepetedCards
    {
        public bool HasRepeatedCards(List<ICard> cards)
        {
            bool result = false;
            int index = 1;

            foreach (var item in cards)
            {
                result = item.Equals(cards[index]);
                index += 1;
            }
            
            return result;
        }
    }
}
