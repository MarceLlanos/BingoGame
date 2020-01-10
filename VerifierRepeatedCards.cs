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

            foreach (var item in cards)
            {
                result = cards.Contains(item);
            }

            return result;
        }
    }
}
