using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class PatternVerifier : IVerifierPattern
    {
        public bool IsThePatternCompleted(IPattern pattern, List<ICard> cards)
        {
            bool result = false;

            foreach (var item in cards)
            {
                var characters = pattern.IsThisPatternPosition(item);
                var charactersVerfied = VerifyIfAllTheElementsAreAsterisk(characters);

                return result = AllTheEllementAreAsterisk(charactersVerfied);
            }

            return result;
        }

        private List<string> VerifyIfAllTheElementsAreAsterisk(List<string> characters)
        {
            var result = new List<string>();

            foreach (var item in characters)
            {
                if (item == "*")
                {
                    result.Add("1");
                }
                else
                {
                    result.Add("0");
                }
            }

            return result;
        }

        private bool AllTheEllementAreAsterisk(List<string> characters)
        {
            if (characters.Contains("0"))
            {
                return false;
            }

            return true;
        }
    }
}
