using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class WinnerCardsPrinted : IWinnerCardsPrinted
    {
        List<ICard> cards;

        public WinnerCardsPrinted()
        {
            cards = new List<ICard>();
        }

        public List<ICard> ShowWinnerCards(ServiceLocator service)
        {
            var pattern = service.GetService<IPatternFactory>("patternShapeFactory").CreatePatternVerifier(service);
            var verifier = service.GetService<IPatternVerifier>("patternShapeVerifier");
            var cardset = service.GetService<ICardSet>("cardSet");
            var cards = cardset.GetCards();

            foreach (var item in cards)
            {
                var isPatternCompleted = verifier.WasSomePatternCompletedInThisCard(pattern, item);

                if (isPatternCompleted == true)
                {
                    
                }
            }

            return null;
            
        }
    }
}
