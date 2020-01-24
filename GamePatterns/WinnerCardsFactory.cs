using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class WinnerCardsFactory : IWinnerCardsFactory
    {
        List<ICard> cards;

        public WinnerCardsFactory()
        {
            cards = new List<ICard>();
        }

        public List<ICard> CreateCardsVerified(ServiceLocator service)
        {
            var pattern = service.GetService<IPatternShapeFactory>("patternShapeFactory").CreatePatternVerifier(service);
            var verifier = service.GetService<IPatternShapeVerifier>("patternShapeVerifier");
            var cardset = service.GetService<ICardSet>("cardSet");

            var cardVerified = verifier.VerifyIfCardCompleteAPattern(pattern, cardset);

            if (cardVerified != null)
            {
                cards.Add(cardVerified);

                return cards;
            }

            return cards;
        }
    }
}
