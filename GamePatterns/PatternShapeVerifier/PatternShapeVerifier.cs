using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class PatternShapeVerifier : IPatternShapeVerifier
    {
        public ICard VerifyIfCardCompleteAPattern(IPatternShape patternShape, ICardSet cardset)
        {
            var cards = cardset.GetCards();
            ICard result = null;

            foreach (var card in cards)
            {
                var characters = patternShape.PatternShape(card);
                var asteriskCharacter = this.AllTheCharactersAreAsterisk(characters);

                if ( asteriskCharacter == true && patternShape.IsthisFullHousePattern() == true )
                {
                    return result = card;
                }

                if (asteriskCharacter == true && patternShape.IsthisFullHousePattern() == false)
                {
                    return result = card;
                }
            }

            return result;

        }

        private int CountAsterisk(List<string> characters)
        {
            var result = 0;

            foreach (var item in characters)
            {
                if (item == "*")
                {
                    result += 1;
                }
                else
                {
                    result -= 1;
                }
            }

            return result;
        }

        private bool AllTheCharactersAreAsterisk(List<string> characters)
        {
            if (this.CountAsterisk(characters) == characters.Count())
            {
                return true;
            }

            return false;
        }

    }
}
